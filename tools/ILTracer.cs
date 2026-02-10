using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Mono.Cecil;
using Mono.Cecil.Cil;

/// <summary>
/// Traces the IL code of Oam4On22qR to extract the decryption key.
/// Uses Mono.Cecil to read the actual IL instructions, avoiding decompiler inaccuracies.
/// </summary>
class ILTracer
{
    static void Main(string[] args)
    {
        string dllPath = args.Length > 0 ? args[0] : "VRisingBephinex.dll";
        string resourcePath = "tools/extracted/e76hfvnUuLT8Tw03QQ_w56xu2OeVGRUMquo4r.bin";

        var readerParams = new ReaderParameters { ReadSymbols = false };
        var assembly = AssemblyDefinition.ReadAssembly(dllPath, readerParams);

        // Find the jiUnG6yLcp99YsGsEb2 type
        TypeDefinition targetType = null;
        foreach (var type in assembly.MainModule.Types)
        {
            if (type.Name == "jiUnG6yLcp99YsGsEb2")
            {
                targetType = type;
                break;
            }
        }

        if (targetType == null)
        {
            Console.WriteLine("ERROR: Cannot find jiUnG6yLcp99YsGsEb2 type");
            return;
        }

        Console.WriteLine($"Found type: {targetType.FullName}");

        // Find the Oam4On22qR method
        MethodDefinition oamMethod = null;
        MethodDefinition decryptMethod = null;
        MethodDefinition keySchedMethod = null;

        foreach (var method in targetType.Methods)
        {
            if (method.Name == "Oam4On22qR") oamMethod = method;
            if (method.Name == "l084oTo8hr") decryptMethod = method;
            if (method.Name == "iww4yX1iDE") keySchedMethod = method;
            Console.WriteLine($"  Method: {method.Name} ({method.Parameters.Count} params, {(method.HasBody ? method.Body.CodeSize.ToString() + " bytes IL" : "no body")})");
        }

        if (oamMethod == null)
        {
            Console.WriteLine("ERROR: Cannot find Oam4On22qR method");
            return;
        }

        Console.WriteLine($"\n=== Analyzing Oam4On22qR ===");
        Console.WriteLine($"IL size: {oamMethod.Body.CodeSize} bytes");
        Console.WriteLine($"Max stack: {oamMethod.Body.MaxStackSize}");
        Console.WriteLine($"Locals: {oamMethod.Body.Variables.Count}");
        for (int i = 0; i < oamMethod.Body.Variables.Count; i++)
        {
            Console.WriteLine($"  Local {i}: {oamMethod.Body.Variables[i].VariableType}");
        }

        // Execute IL simulation to find the key
        Console.WriteLine("\n=== Simulating IL execution ===");
        byte[] key = SimulateOam4On22qR(oamMethod);

        if (key != null)
        {
            Console.WriteLine($"\nExtracted key: {BitConverter.ToString(key).Replace("-", "").ToLower()}");
            Console.WriteLine($"Key bytes: [{string.Join(", ", key)}]");

            // IV from case 180 (verified manually)
            byte[] iv = new byte[] { 167, 23, 121, 20, 238, 154, 131, 247, 82, 162, 14, 87, 119, 73, 26, 249 };

            // Read and decrypt resource
            byte[] encrypted = File.ReadAllBytes(resourcePath);
            Console.WriteLine($"\nResource size: {encrypted.Length} bytes");

            byte[] decrypted = Decrypt(key, encrypted);
            File.WriteAllBytes("tools/extracted/strings_decrypted.bin", decrypted);

            Console.Write("First 64 bytes decrypted: ");
            for (int i = 0; i < Math.Min(64, decrypted.Length); i++)
                Console.Write(decrypted[i].ToString("x2"));
            Console.WriteLine();

            // Decode strings
            var strings = DecodeStrings(decrypted);
            Console.WriteLine($"\nDecoded {strings.Count} strings");

            using (var w = new StreamWriter("tools/extracted/decrypted_strings.txt", false, Encoding.UTF8))
            {
                w.WriteLine("# Decrypted strings from VRisingBephinex.dll");
                w.WriteLine($"# Key: {BitConverter.ToString(key).Replace("-", "").ToLower()}");
                w.WriteLine($"# Total: {strings.Count} strings\n");
                foreach (var kv in strings)
                    w.WriteLine($"[0x{kv.Key:X4}] {kv.Value}");
            }

            Console.WriteLine("\n=== Decoded strings ===");
            int count = 0;
            foreach (var kv in strings)
            {
                if (count++ >= 80) { Console.WriteLine("..."); break; }
                Console.WriteLine($"  [0x{kv.Key:X4}] {kv.Value}");
            }
        }

        assembly.Dispose();
    }

    /// <summary>
    /// Simulate the Oam4On22qR method to extract the key.
    /// This is a simplified IL interpreter that handles the state machine pattern.
    /// </summary>
    static byte[] SimulateOam4On22qR(MethodDefinition method)
    {
        var body = method.Body;
        var instructions = body.Instructions;

        // Map from instruction offset to index
        var offsetMap = new Dictionary<int, int>();
        for (int i = 0; i < instructions.Count; i++)
            offsetMap[instructions[i].Offset] = i;

        // State
        var stack = new Stack<object>();
        var locals = new object[body.Variables.Count];

        // Initialize locals to default values
        for (int i = 0; i < locals.Length; i++)
        {
            var vtype = body.Variables[i].VariableType;
            if (vtype.FullName == "System.Int32" || vtype.FullName == "System.UInt32")
                locals[i] = 0;
            else if (vtype.FullName == "System.Byte[]")
                locals[i] = null;
            else
                locals[i] = null;
        }

        // Find which local is array2 (byte[32] key), num3 (state), num5, num6, num7
        // We'll identify them by tracing the code

        int pc = 0;
        int maxSteps = 100000;
        byte[] extractedKey = null;

        // Track array2 content
        byte[] array2 = null;

        for (int step = 0; step < maxSteps && pc < instructions.Count; step++)
        {
            var instr = instructions[pc];
            var op = instr.OpCode;
            int nextPc = pc + 1;
            bool jumped = false;

            try
            {
                // Handle each opcode
                if (op == OpCodes.Nop)
                {
                    // Nothing
                }
                else if (op == OpCodes.Ldc_I4 || op == OpCodes.Ldc_I4_S)
                {
                    int val = Convert.ToInt32(instr.Operand);
                    stack.Push(val);
                }
                else if (op == OpCodes.Ldc_I4_0) stack.Push(0);
                else if (op == OpCodes.Ldc_I4_1) stack.Push(1);
                else if (op == OpCodes.Ldc_I4_2) stack.Push(2);
                else if (op == OpCodes.Ldc_I4_3) stack.Push(3);
                else if (op == OpCodes.Ldc_I4_4) stack.Push(4);
                else if (op == OpCodes.Ldc_I4_5) stack.Push(5);
                else if (op == OpCodes.Ldc_I4_6) stack.Push(6);
                else if (op == OpCodes.Ldc_I4_7) stack.Push(7);
                else if (op == OpCodes.Ldc_I4_8) stack.Push(8);
                else if (op == OpCodes.Ldc_I4_M1) stack.Push(-1);
                else if (op == OpCodes.Stloc_0) { locals[0] = stack.Pop(); }
                else if (op == OpCodes.Stloc_1) { locals[1] = stack.Pop(); }
                else if (op == OpCodes.Stloc_2) { locals[2] = stack.Pop(); }
                else if (op == OpCodes.Stloc_3) { locals[3] = stack.Pop(); }
                else if (op == OpCodes.Stloc || op == OpCodes.Stloc_S)
                {
                    var v = (VariableDefinition)instr.Operand;
                    locals[v.Index] = stack.Pop();
                }
                else if (op == OpCodes.Ldloc_0) stack.Push(locals[0]);
                else if (op == OpCodes.Ldloc_1) stack.Push(locals[1]);
                else if (op == OpCodes.Ldloc_2) stack.Push(locals[2]);
                else if (op == OpCodes.Ldloc_3) stack.Push(locals[3]);
                else if (op == OpCodes.Ldloc || op == OpCodes.Ldloc_S)
                {
                    var v = (VariableDefinition)instr.Operand;
                    stack.Push(locals[v.Index]);
                }
                else if (op == OpCodes.Ldarg_0)
                {
                    // P_0 = Stream argument
                    stack.Push("stream_arg");
                }
                else if (op == OpCodes.Add)
                {
                    var b = stack.Pop();
                    var a = stack.Pop();
                    if (a is int ai && b is int bi)
                        stack.Push(ai + bi);
                    else
                        stack.Push(0);
                }
                else if (op == OpCodes.Sub)
                {
                    var b = stack.Pop();
                    var a = stack.Pop();
                    if (a is int ai && b is int bi)
                        stack.Push(ai - bi);
                    else
                        stack.Push(0);
                }
                else if (op == OpCodes.Conv_U1)
                {
                    var v = stack.Pop();
                    if (v is int iv)
                        stack.Push((int)(byte)iv);
                    else
                        stack.Push(0);
                }
                else if (op == OpCodes.Newarr)
                {
                    var size = stack.Pop();
                    int arrSize = (size is int si) ? si : 0;
                    var arr = new byte[arrSize];
                    stack.Push(arr);
                    if (arrSize == 32)
                    {
                        array2 = arr;
                    }
                }
                else if (op == OpCodes.Stelem_I1)
                {
                    var val = stack.Pop();
                    var idx = stack.Pop();
                    var arr = stack.Pop();
                    if (arr is byte[] ba && idx is int ii && val is int vi)
                    {
                        if (ii >= 0 && ii < ba.Length)
                            ba[ii] = (byte)vi;
                    }
                }
                else if (op == OpCodes.Dup)
                {
                    var v = stack.Peek();
                    stack.Push(v);
                }
                else if (op == OpCodes.Pop)
                {
                    if (stack.Count > 0)
                        stack.Pop();
                }
                else if (op == OpCodes.Br || op == OpCodes.Br_S)
                {
                    var target = (Instruction)instr.Operand;
                    if (offsetMap.ContainsKey(target.Offset))
                    {
                        nextPc = offsetMap[target.Offset];
                        jumped = true;
                    }
                }
                else if (op == OpCodes.Brtrue || op == OpCodes.Brtrue_S)
                {
                    var v = stack.Pop();
                    bool cond = false;
                    if (v is int iv) cond = iv != 0;
                    else if (v is bool bv) cond = bv;
                    else if (v != null && !(v is string s && s == "null")) cond = true;

                    if (cond)
                    {
                        var target = (Instruction)instr.Operand;
                        if (offsetMap.ContainsKey(target.Offset))
                        {
                            nextPc = offsetMap[target.Offset];
                            jumped = true;
                        }
                    }
                }
                else if (op == OpCodes.Brfalse || op == OpCodes.Brfalse_S)
                {
                    var v = stack.Pop();
                    bool cond = true;
                    if (v is int iv) cond = iv == 0;
                    else if (v is bool bv) cond = !bv;
                    else if (v == null) cond = true;
                    else if (v is string s && s == "null") cond = true;

                    if (cond)
                    {
                        var target = (Instruction)instr.Operand;
                        if (offsetMap.ContainsKey(target.Offset))
                        {
                            nextPc = offsetMap[target.Offset];
                            jumped = true;
                        }
                    }
                }
                else if (op == OpCodes.Beq || op == OpCodes.Beq_S)
                {
                    var b = stack.Pop();
                    var a = stack.Pop();
                    bool eq = false;
                    if (a is int ai && b is int bi) eq = ai == bi;
                    if (eq)
                    {
                        var target = (Instruction)instr.Operand;
                        if (offsetMap.ContainsKey(target.Offset))
                        {
                            nextPc = offsetMap[target.Offset];
                            jumped = true;
                        }
                    }
                }
                else if (op == OpCodes.Bgt || op == OpCodes.Bgt_S ||
                         op == OpCodes.Bgt_Un || op == OpCodes.Bgt_Un_S)
                {
                    var b = stack.Pop();
                    var a = stack.Pop();
                    bool gt = false;
                    if (a is int ai && b is int bi) gt = ai > bi;
                    if (gt)
                    {
                        var target = (Instruction)instr.Operand;
                        if (offsetMap.ContainsKey(target.Offset))
                        {
                            nextPc = offsetMap[target.Offset];
                            jumped = true;
                        }
                    }
                }
                else if (op == OpCodes.Blt || op == OpCodes.Blt_S)
                {
                    var b = stack.Pop();
                    var a = stack.Pop();
                    bool lt = false;
                    if (a is int ai && b is int bi) lt = ai < bi;
                    if (lt)
                    {
                        var target = (Instruction)instr.Operand;
                        if (offsetMap.ContainsKey(target.Offset))
                        {
                            nextPc = offsetMap[target.Offset];
                            jumped = true;
                        }
                    }
                }
                else if (op == OpCodes.Ble || op == OpCodes.Ble_S ||
                         op == OpCodes.Ble_Un || op == OpCodes.Ble_Un_S)
                {
                    var b = stack.Pop();
                    var a = stack.Pop();
                    bool le = false;
                    if (a is int ai && b is int bi) le = ai <= bi;
                    if (le)
                    {
                        var target = (Instruction)instr.Operand;
                        if (offsetMap.ContainsKey(target.Offset))
                        {
                            nextPc = offsetMap[target.Offset];
                            jumped = true;
                        }
                    }
                }
                else if (op == OpCodes.Bge || op == OpCodes.Bge_S)
                {
                    var b = stack.Pop();
                    var a = stack.Pop();
                    bool ge = false;
                    if (a is int ai && b is int bi) ge = ai >= bi;
                    if (ge)
                    {
                        var target = (Instruction)instr.Operand;
                        if (offsetMap.ContainsKey(target.Offset))
                        {
                            nextPc = offsetMap[target.Offset];
                            jumped = true;
                        }
                    }
                }
                else if (op == OpCodes.Bne_Un || op == OpCodes.Bne_Un_S)
                {
                    var b = stack.Pop();
                    var a = stack.Pop();
                    bool ne = true;
                    if (a is int ai && b is int bi) ne = ai != bi;
                    if (ne)
                    {
                        var target = (Instruction)instr.Operand;
                        if (offsetMap.ContainsKey(target.Offset))
                        {
                            nextPc = offsetMap[target.Offset];
                            jumped = true;
                        }
                    }
                }
                else if (op == OpCodes.Switch)
                {
                    var targets = (Instruction[])instr.Operand;
                    var idx = stack.Pop();
                    if (idx is int ii && ii >= 0 && ii < targets.Length)
                    {
                        if (offsetMap.ContainsKey(targets[ii].Offset))
                        {
                            nextPc = offsetMap[targets[ii].Offset];
                            jumped = true;
                        }
                    }
                }
                else if (op == OpCodes.Ceq)
                {
                    var b = stack.Pop();
                    var a = stack.Pop();
                    bool eq = false;
                    if (a is int ai && b is int bi) eq = ai == bi;
                    else if (a == null && b == null) eq = true;
                    else if (a is string sa && b is string sb) eq = sa == sb;
                    else if (a == null && b is string sbn && sbn == "null") eq = true;
                    else if (b == null && a is string san && san == "null") eq = true;
                    stack.Push(eq ? 1 : 0);
                }
                else if (op == OpCodes.Cgt || op == OpCodes.Cgt_Un)
                {
                    var b = stack.Pop();
                    var a = stack.Pop();
                    bool gt = false;
                    if (a is int ai && b is int bi) gt = ai > bi;
                    stack.Push(gt ? 1 : 0);
                }
                else if (op == OpCodes.Clt || op == OpCodes.Clt_Un)
                {
                    var b = stack.Pop();
                    var a = stack.Pop();
                    bool lt = false;
                    if (a is int ai && b is int bi) lt = ai < bi;
                    stack.Push(lt ? 1 : 0);
                }
                else if (op == OpCodes.Ldnull)
                {
                    stack.Push(null);
                }
                else if (op == OpCodes.Call || op == OpCodes.Callvirt)
                {
                    var calledMethod = (MethodReference)instr.Operand;
                    string methodName = calledMethod.Name;

                    if (methodName == "caC120Il6QhJUxYlgMd")
                    {
                        stack.Push(1); // Always true (null == null)
                    }
                    else if (methodName == "rqDaSCIfBibcCJvS3cF")
                    {
                        stack.Push(null); // Always returns null
                    }
                    else
                    {
                        // Unknown method - pop args and push null/0
                        int paramCount = calledMethod.Parameters.Count;
                        if (calledMethod.HasThis) paramCount++;
                        for (int i = 0; i < paramCount; i++)
                        {
                            if (stack.Count > 0) stack.Pop();
                        }
                        if (calledMethod.ReturnType.FullName != "System.Void")
                        {
                            if (calledMethod.ReturnType.FullName == "System.Int32" ||
                                calledMethod.ReturnType.FullName == "System.Int64")
                                stack.Push(0);
                            else if (calledMethod.ReturnType.FullName == "System.Boolean")
                                stack.Push(0);
                            else
                                stack.Push(null);
                        }
                    }
                }
                else if (op == OpCodes.Newobj)
                {
                    var ctor = (MethodReference)instr.Operand;
                    int paramCount = ctor.Parameters.Count;
                    for (int i = 0; i < paramCount; i++)
                    {
                        if (stack.Count > 0) stack.Pop();
                    }
                    stack.Push("new_obj");
                }
                else if (op == OpCodes.Ret)
                {
                    // Method returns void, so just break
                    Console.WriteLine($"  Reached RET at step {step}, PC={pc}");
                    break;
                }
                else if (op == OpCodes.Leave || op == OpCodes.Leave_S)
                {
                    var target = (Instruction)instr.Operand;
                    if (offsetMap.ContainsKey(target.Offset))
                    {
                        nextPc = offsetMap[target.Offset];
                        jumped = true;
                    }
                    stack.Clear();
                }
                else if (op == OpCodes.Endfinally)
                {
                    // End of finally block
                    Console.WriteLine($"  Reached ENDFINALLY at step {step}");
                    break;
                }
                else if (op == OpCodes.Ldelem_U1 || op == OpCodes.Ldelem_I1)
                {
                    var idx = stack.Pop();
                    var arr = stack.Pop();
                    if (arr is byte[] ba && idx is int ii && ii >= 0 && ii < ba.Length)
                        stack.Push((int)ba[ii]);
                    else
                        stack.Push(0);
                }
                else if (op == OpCodes.Ldlen)
                {
                    var arr = stack.Pop();
                    if (arr is byte[] ba)
                        stack.Push(ba.Length);
                    else
                        stack.Push(0);
                }
                else if (op == OpCodes.Conv_I4)
                {
                    // Already int in our simulation
                    var v = stack.Pop();
                    stack.Push(v is int i ? i : 0);
                }
                else if (op == OpCodes.Ldfld || op == OpCodes.Ldsfld)
                {
                    var field = (FieldReference)instr.Operand;
                    if (op == OpCodes.Ldfld && stack.Count > 0)
                        stack.Pop(); // pop 'this'
                    // Push default value
                    stack.Push(0);
                }
                else if (op == OpCodes.Stfld || op == OpCodes.Stsfld)
                {
                    var field = (FieldReference)instr.Operand;
                    if (stack.Count > 0) stack.Pop(); // value
                    if (op == OpCodes.Stfld && stack.Count > 0)
                        stack.Pop(); // this
                }
                else if (op == OpCodes.Initobj)
                {
                    if (stack.Count > 0) stack.Pop();
                }
                else if (op == OpCodes.Ldloca || op == OpCodes.Ldloca_S)
                {
                    // Push address of local (we'll push the local index as ref)
                    var v = (VariableDefinition)instr.Operand;
                    stack.Push($"ref_local_{v.Index}");
                }
                else if (op == OpCodes.Conv_I8)
                {
                    var v = stack.Pop();
                    stack.Push(v is int i ? (long)i : 0L);
                }
                else
                {
                    // Unknown opcode - try to handle it generically
                    // Console.WriteLine($"  [WARN] Unknown opcode: {op} at offset {instr.Offset}");
                }
            }
            catch (Exception ex)
            {
                // Stack underflow or other issues - continue
                // Console.WriteLine($"  [ERR] at step {step}, PC={pc}, op={op}: {ex.Message}");
            }

            if (!jumped)
                pc = nextPc;
            else
                pc = nextPc;  // jumped already set nextPc
        }

        return array2;
    }

    static uint iww4yX1iDE(uint P_0)
    {
        uint num = P_0;
        uint num2 = 973202305u;
        uint num3 = 1582787682u;
        uint num4 = 1577548636u;
        uint num5 = 332884210u;
        ulong num6 = (ulong)num4 * 1313243236uL;
        num6 |= 1;
        num3 = (uint)((ulong)num3 * (ulong)num3 % num6);
        ulong num7 = 1907532890uL * (ulong)num4;
        if (num7 == 0L) num7--;
        num2 = (uint)(-502326134 - (int)num3);
        ulong num8 = (ulong)num3 * 183835789uL;
        num8 |= 1;
        num4 = (uint)((ulong)num4 * (ulong)num4 % num8);
        uint num9 = ((num5 >> 6) | (num5 << 26)) ^ num3;
        uint num10 = num9 & 0xF0F0F0Fu;
        num5 = ((num9 & 0xF0F0F0F0u) >> 4) | (num10 << 4);
        num ^= num << 3;
        num += num2;
        num ^= num << 11;
        num += num4;
        num ^= num >> 27;
        num += num5;
        return (((num2 << 11) - num3) ^ num4) - num;
    }

    static byte[] Decrypt(byte[] key, byte[] data)
    {
        if (data.Length == 0) return new byte[0];
        int remainder = data.Length % 4;
        int numBlocks = data.Length / 4;
        byte[] result = new byte[data.Length];
        int keyBlocks = key.Length / 4;
        uint acc = 0;
        if (remainder > 0) numBlocks++;
        for (int i = 0; i < numBlocks; i++)
        {
            int keyIdx = i % keyBlocks;
            int boff = i * 4;
            uint ki = (uint)(keyIdx * 4);
            uint kv = (uint)((key[ki+3] << 24) | (key[ki+2] << 16) | (key[ki+1] << 8) | key[ki]);
            if (i == numBlocks - 1 && remainder > 0)
            {
                uint dv = 0;
                for (int j = 0; j < remainder; j++)
                {
                    if (j > 0) dv <<= 8;
                    dv |= data[data.Length - 1 - j];
                }
                acc += kv;
                acc += iww4yX1iDE(acc);
                uint x = acc ^ dv;
                uint mask = 0xFF; int shift = 0;
                for (int k = 0; k < remainder; k++)
                {
                    if (k > 0) { mask <<= 8; shift += 8; }
                    result[boff + k] = (byte)((x & mask) >> shift);
                }
            }
            else
            {
                uint di = (uint)boff;
                uint dv = (uint)((data[di+3] << 24) | (data[di+2] << 16) | (data[di+1] << 8) | data[di]);
                acc += kv;
                acc += iww4yX1iDE(acc);
                uint x = acc ^ dv;
                result[boff] = (byte)(x & 0xFF);
                result[boff+1] = (byte)((x >> 8) & 0xFF);
                result[boff+2] = (byte)((x >> 16) & 0xFF);
                result[boff+3] = (byte)((x >> 24) & 0xFF);
            }
        }
        return result;
    }

    static SortedDictionary<int, string> DecodeStrings(byte[] data)
    {
        var strings = new SortedDictionary<int, string>();
        int offset = 0;
        while (offset + 4 <= data.Length)
        {
            int strLen = BitConverter.ToInt32(data, offset);
            if (strLen <= 0 || strLen > 10000 || offset + 4 + strLen > data.Length || strLen % 2 != 0)
            {
                offset++;
                continue;
            }
            try
            {
                string s = Encoding.Unicode.GetString(data, offset + 4, strLen);
                bool valid = s.Length > 0;
                foreach (char c in s)
                {
                    if (c < 0x20 && c != '\t' && c != '\n' && c != '\r') { valid = false; break; }
                }
                if (valid) { strings[offset] = s; offset += 4 + strLen; }
                else offset++;
            }
            catch { offset++; }
        }
        return strings;
    }
}
