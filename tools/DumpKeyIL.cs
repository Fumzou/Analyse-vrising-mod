using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Mono.Cecil;
using Mono.Cecil.Cil;

/// <summary>
/// Dumps IL instructions of Oam4On22qR, specifically focusing on:
/// - stelem.i1 instructions (byte array assignments)
/// - ldc.i4 constants used to build the key
/// Then uses a different approach: searches for byte array initialization patterns.
/// </summary>
class DumpKeyIL
{
    static void Main(string[] args)
    {
        string dllPath = args.Length > 0 ? args[0] : "VRisingBephinex.dll";

        var readerParams = new ReaderParameters { ReadSymbols = false };
        var assembly = AssemblyDefinition.ReadAssembly(dllPath, readerParams);

        TypeDefinition targetType = null;
        foreach (var type in assembly.MainModule.Types)
        {
            if (type.Name == "jiUnG6yLcp99YsGsEb2")
            {
                targetType = type;
                break;
            }
        }

        // Find Oam4On22qR
        MethodDefinition oamMethod = null;
        foreach (var method in targetType.Methods)
        {
            if (method.Name == "Oam4On22qR")
            {
                oamMethod = method;
                break;
            }
        }

        var body = oamMethod.Body;
        var instructions = body.Instructions;

        // Strategy: Find all stelem.i1 instructions (byte array element stores)
        // These are the key byte assignments: array2[idx] = value
        //
        // The IL pattern for "array2[5] = 138;" is:
        //   ldloc.X    (load array2)
        //   ldc.i4.5   (load index 5)
        //   ldc.i4 138 (load value)
        //   stelem.i1  (store byte)
        //
        // The IL pattern for "array2[5] = (byte)num7;" is:
        //   ldloc.X    (load array2)
        //   ldc.i4.5   (load index 5)
        //   ldloc.Y    (load num7)
        //   conv.u1    (convert to byte)
        //   stelem.i1  (store byte)

        Console.WriteLine($"Total instructions: {instructions.Count}");
        Console.WriteLine($"IL size: {body.CodeSize} bytes");
        Console.WriteLine($"Locals: {body.Variables.Count}");

        // Find all stelem.i1 and their contexts
        Console.WriteLine("\n=== All stelem.i1 instructions ===");
        int stelemCount = 0;
        for (int i = 0; i < instructions.Count; i++)
        {
            if (instructions[i].OpCode == OpCodes.Stelem_I1)
            {
                stelemCount++;
                // Look back to find the array, index, and value
                string arrayVar = "?";
                string indexVal = "?";
                string valueVal = "?";

                // Walk backwards to find the 3 pushes
                // stelem.i1 pops: array, index, value (in that order on stack)
                // So preceding instructions should be: push_array, push_index, push_value

                if (i >= 3)
                {
                    var arrInstr = instructions[i - 3];
                    var idxInstr = instructions[i - 2];
                    var valInstr = instructions[i - 1];

                    // Handle conv.u1 before stelem
                    if (valInstr.OpCode == OpCodes.Conv_U1 && i >= 4)
                    {
                        valInstr = instructions[i - 2];
                        idxInstr = instructions[i - 3];
                        arrInstr = instructions[i - 4];
                    }

                    // Get array variable
                    if (arrInstr.OpCode == OpCodes.Ldloc_0) arrayVar = "local0";
                    else if (arrInstr.OpCode == OpCodes.Ldloc_1) arrayVar = "local1";
                    else if (arrInstr.OpCode == OpCodes.Ldloc_2) arrayVar = "local2";
                    else if (arrInstr.OpCode == OpCodes.Ldloc_3) arrayVar = "local3";
                    else if (arrInstr.OpCode == OpCodes.Ldloc || arrInstr.OpCode == OpCodes.Ldloc_S)
                        arrayVar = $"local{((VariableDefinition)arrInstr.Operand).Index}";
                    else arrayVar = arrInstr.OpCode.ToString();

                    // Get index
                    indexVal = GetConstValue(idxInstr);

                    // Get value
                    if (instructions[i - 1].OpCode == OpCodes.Conv_U1)
                        valueVal = GetConstValue(instructions[i - 2]) + " (conv.u1)";
                    else
                        valueVal = GetConstValue(instructions[i - 1]);
                }

                // Only print if it looks like a byte[] assignment to the key array
                if (stelemCount <= 500)
                {
                    Console.WriteLine($"  [{stelemCount:D3}] @{instructions[i].Offset:X4}: {arrayVar}[{indexVal}] = {valueVal}");
                }
            }
        }
        Console.WriteLine($"\nTotal stelem.i1 count: {stelemCount}");

        // Also find all newarr byte[] instructions to identify which local is array2
        Console.WriteLine("\n=== newarr System.Byte instructions ===");
        for (int i = 0; i < instructions.Count; i++)
        {
            if (instructions[i].OpCode == OpCodes.Newarr)
            {
                var elemType = (TypeReference)instructions[i].Operand;
                if (elemType.FullName == "System.Byte")
                {
                    // Check the size (should be on stack = previous instruction)
                    string size = "?";
                    if (i > 0) size = GetConstValue(instructions[i - 1]);

                    // Check where it's stored
                    string storeVar = "?";
                    if (i + 1 < instructions.Count)
                    {
                        var storeInstr = instructions[i + 1];
                        if (storeInstr.OpCode == OpCodes.Stloc_0) storeVar = "local0";
                        else if (storeInstr.OpCode == OpCodes.Stloc_1) storeVar = "local1";
                        else if (storeInstr.OpCode == OpCodes.Stloc_2) storeVar = "local2";
                        else if (storeInstr.OpCode == OpCodes.Stloc_3) storeVar = "local3";
                        else if (storeInstr.OpCode == OpCodes.Stloc || storeInstr.OpCode == OpCodes.Stloc_S)
                            storeVar = $"local{((VariableDefinition)storeInstr.Operand).Index}";
                        else if (storeInstr.OpCode == OpCodes.Dup) storeVar = "(dup)";
                    }

                    Console.WriteLine($"  @{instructions[i].Offset:X4}: new byte[{size}] -> {storeVar}");
                }
            }
        }

        // Also look for the switch instruction to understand the state machine
        Console.WriteLine("\n=== Switch instructions ===");
        for (int i = 0; i < instructions.Count; i++)
        {
            if (instructions[i].OpCode == OpCodes.Switch)
            {
                var targets = (Instruction[])instructions[i].Operand;
                Console.WriteLine($"  @{instructions[i].Offset:X4}: switch with {targets.Length} targets");
                for (int j = 0; j < Math.Min(targets.Length, 250); j++)
                {
                    Console.WriteLine($"    case {j}: @{targets[j].Offset:X4}");
                }
                if (targets.Length > 250) Console.WriteLine($"    ... ({targets.Length - 250} more)");
            }
        }

        assembly.Dispose();
    }

    static string GetConstValue(Instruction instr)
    {
        if (instr.OpCode == OpCodes.Ldc_I4) return instr.Operand.ToString();
        if (instr.OpCode == OpCodes.Ldc_I4_S) return ((sbyte)instr.Operand).ToString();
        if (instr.OpCode == OpCodes.Ldc_I4_0) return "0";
        if (instr.OpCode == OpCodes.Ldc_I4_1) return "1";
        if (instr.OpCode == OpCodes.Ldc_I4_2) return "2";
        if (instr.OpCode == OpCodes.Ldc_I4_3) return "3";
        if (instr.OpCode == OpCodes.Ldc_I4_4) return "4";
        if (instr.OpCode == OpCodes.Ldc_I4_5) return "5";
        if (instr.OpCode == OpCodes.Ldc_I4_6) return "6";
        if (instr.OpCode == OpCodes.Ldc_I4_7) return "7";
        if (instr.OpCode == OpCodes.Ldc_I4_8) return "8";
        if (instr.OpCode == OpCodes.Ldc_I4_M1) return "-1";
        if (instr.OpCode == OpCodes.Ldloc_0) return "local0";
        if (instr.OpCode == OpCodes.Ldloc_1) return "local1";
        if (instr.OpCode == OpCodes.Ldloc_2) return "local2";
        if (instr.OpCode == OpCodes.Ldloc_3) return "local3";
        if (instr.OpCode == OpCodes.Ldloc || instr.OpCode == OpCodes.Ldloc_S)
            return $"local{((VariableDefinition)instr.Operand).Index}";
        return instr.OpCode.ToString();
    }
}
