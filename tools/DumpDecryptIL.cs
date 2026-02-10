using System;
using System.Collections.Generic;
using Mono.Cecil;
using Mono.Cecil.Cil;

/// <summary>
/// Dumps IL of l084oTo8hr and iww4yX1iDE methods to verify against decompiled C#.
/// Also runs the IL interpreter on l084oTo8hr with the actual key and resource data.
/// </summary>
class DumpDecryptIL
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

        // Find and dump l084oTo8hr
        MethodDefinition decryptMethod = null;
        MethodDefinition keySchedMethod = null;

        foreach (var method in targetType.Methods)
        {
            if (method.Name == "l084oTo8hr")
                decryptMethod = method;
            if (method.Name == "iww4yX1iDE")
                keySchedMethod = method;
        }

        // Dump l084oTo8hr IL
        Console.WriteLine("=== l084oTo8hr IL ===");
        Console.WriteLine($"Parameters: {decryptMethod.Parameters.Count}");
        Console.WriteLine($"HasThis: {decryptMethod.HasThis}");
        Console.WriteLine($"Locals: {decryptMethod.Body.Variables.Count}");
        for (int i = 0; i < decryptMethod.Body.Variables.Count; i++)
            Console.WriteLine($"  Local {i}: {decryptMethod.Body.Variables[i].VariableType.FullName}");

        Console.WriteLine($"\nIL size: {decryptMethod.Body.CodeSize}");
        Console.WriteLine($"Instructions: {decryptMethod.Body.Instructions.Count}");

        foreach (var instr in decryptMethod.Body.Instructions)
        {
            string operandStr = "";
            if (instr.Operand is Instruction target)
                operandStr = $"@{target.Offset:X4}";
            else if (instr.Operand is Instruction[] targets)
                operandStr = $"[{targets.Length} targets]";
            else if (instr.Operand is VariableDefinition v)
                operandStr = $"local{v.Index}";
            else if (instr.Operand is MethodReference m)
                operandStr = m.Name;
            else if (instr.Operand is FieldReference f)
                operandStr = f.Name;
            else if (instr.Operand is TypeReference t)
                operandStr = t.Name;
            else if (instr.Operand != null)
                operandStr = instr.Operand.ToString();

            Console.WriteLine($"  @{instr.Offset:X4} {instr.OpCode} {operandStr}");
        }

        // Dump iww4yX1iDE IL
        Console.WriteLine("\n=== iww4yX1iDE IL ===");
        Console.WriteLine($"Parameters: {keySchedMethod.Parameters.Count}");
        Console.WriteLine($"HasThis: {keySchedMethod.HasThis}");
        Console.WriteLine($"Locals: {keySchedMethod.Body.Variables.Count}");
        for (int i = 0; i < keySchedMethod.Body.Variables.Count; i++)
            Console.WriteLine($"  Local {i}: {keySchedMethod.Body.Variables[i].VariableType.FullName}");

        Console.WriteLine($"\nIL size: {keySchedMethod.Body.CodeSize}");

        foreach (var instr in keySchedMethod.Body.Instructions)
        {
            string operandStr = "";
            if (instr.Operand is Instruction target)
                operandStr = $"@{target.Offset:X4}";
            else if (instr.Operand is VariableDefinition v)
                operandStr = $"local{v.Index}";
            else if (instr.Operand is MethodReference m)
                operandStr = m.Name;
            else if (instr.Operand is FieldReference f)
                operandStr = f.Name;
            else if (instr.Operand is TypeReference t)
                operandStr = t.Name;
            else if (instr.Operand != null)
                operandStr = instr.Operand.ToString();

            Console.WriteLine($"  @{instr.Offset:X4} {instr.OpCode} {operandStr}");
        }

        // Print instance fields
        Console.WriteLine("\n=== Instance fields ===");
        foreach (var field in targetType.Fields)
        {
            if (!field.IsStatic)
                Console.WriteLine($"  {field.Name}: {field.FieldType.FullName}");
        }

        assembly.Dispose();
    }
}
