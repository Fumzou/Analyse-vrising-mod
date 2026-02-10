using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using Mono.Cecil;
using Mono.Cecil.Cil;

/// <summary>
/// Full IL interpreter for Oam4On22qR using Mono.Cecil.
/// Tracks all local variables and follows control flow precisely.
/// </summary>
class ILInterpreter
{
    static TypeDefinition parentType;
    static ModuleDefinition module;

    static void Main(string[] args)
    {
        string dllPath = args.Length > 0 ? args[0] : "VRisingBephinex.dll";

        var readerParams = new ReaderParameters { ReadSymbols = false };
        var assembly = AssemblyDefinition.ReadAssembly(dllPath, readerParams);
        module = assembly.MainModule;

        TypeDefinition targetType = null;
        foreach (var type in module.Types)
        {
            if (type.Name == "jiUnG6yLcp99YsGsEb2")
            {
                targetType = type;
                break;
            }
        }
        parentType = targetType;

        MethodDefinition oamMethod = null;
        foreach (var method in targetType.Methods)
        {
            if (method.Name == "Oam4On22qR")
            {
                oamMethod = method;
                break;
            }
        }

        Console.WriteLine($"Method: {oamMethod.Name}");
        Console.WriteLine($"IL size: {oamMethod.Body.CodeSize}");
        Console.WriteLine($"Locals: {oamMethod.Body.Variables.Count}");
        Console.WriteLine($"Exception handlers: {oamMethod.Body.ExceptionHandlers.Count}");

        // Print exception handler info
        foreach (var eh in oamMethod.Body.ExceptionHandlers)
        {
            Console.WriteLine($"  Handler: {eh.HandlerType} try@{eh.TryStart.Offset:X4}-{eh.TryEnd.Offset:X4} handler@{eh.HandlerStart.Offset:X4}-{eh.HandlerEnd.Offset:X4}");
        }

        // Build offset -> instruction index map
        var instructions = oamMethod.Body.Instructions;
        var offsetMap = new Dictionary<int, int>();
        for (int i = 0; i < instructions.Count; i++)
        {
            offsetMap[instructions[i].Offset] = i;
        }

        // Execute
        var locals = new object[oamMethod.Body.Variables.Count];
        for (int i = 0; i < locals.Length; i++)
        {
            var vt = oamMethod.Body.Variables[i].VariableType;
            if (vt.FullName == "System.Int32" || vt.FullName == "System.Boolean")
                locals[i] = (int)0;
            else if (vt.FullName == "System.Int64")
                locals[i] = (long)0;
            else
                locals[i] = null;
        }

        // Print local types
        for (int i = 0; i < oamMethod.Body.Variables.Count; i++)
        {
            Console.WriteLine($"  Local {i}: {oamMethod.Body.Variables[i].VariableType.FullName}");
        }

        // The method parameter P_0 is an object (MemoryStream)
        // We pass a fake stream since we only care about key construction
        object[] methodArgs = new object[] { null };

        var stack = new Stack<object>();
        int pc = 0;
        int maxSteps = 500000;
        int stepCount = 0;
        bool running = true;

        // Track exception handlers
        var handlers = oamMethod.Body.ExceptionHandlers;

        // To handle finally blocks properly
        Stack<int> leaveTargets = new Stack<int>();

        while (running && stepCount < maxSteps)
        {
            if (pc < 0 || pc >= instructions.Count)
            {
                Console.WriteLine($"PC out of bounds: {pc}");
                break;
            }

            var instr = instructions[pc];
            var opcode = instr.OpCode;
            stepCount++;

            // Debug output for key events
            bool isKeyEvent = false;
            if (opcode == OpCodes.Stelem_I1 || opcode == OpCodes.Newarr || opcode == OpCodes.Switch)
                isKeyEvent = true;

            // Only print occasionally to avoid flooding
            if (stepCount <= 20 || stepCount % 10000 == 0 || isKeyEvent)
            {
                // Don't flood with stelem
                if (stepCount <= 20 || stepCount % 10000 == 0)
                    Console.WriteLine($"[{stepCount}] @{instr.Offset:X4} {opcode} stack={stack.Count}");
            }

            try
            {
                switch (opcode.Code)
                {
                    case Code.Nop:
                        pc++;
                        break;

                    case Code.Ret:
                        Console.WriteLine($"  RET at step {stepCount}, offset {instr.Offset:X4}");
                        running = false;
                        break;

                    case Code.Ldarg_0:
                        stack.Push(methodArgs[0]);
                        pc++;
                        break;

                    case Code.Ldarg_1:
                        stack.Push(methodArgs.Length > 1 ? methodArgs[1] : null);
                        pc++;
                        break;

                    // Local variable loads
                    case Code.Ldloc_0: stack.Push(locals[0]); pc++; break;
                    case Code.Ldloc_1: stack.Push(locals[1]); pc++; break;
                    case Code.Ldloc_2: stack.Push(locals[2]); pc++; break;
                    case Code.Ldloc_3: stack.Push(locals[3]); pc++; break;
                    case Code.Ldloc:
                    case Code.Ldloc_S:
                        stack.Push(locals[((VariableDefinition)instr.Operand).Index]);
                        pc++;
                        break;

                    // Local variable stores
                    case Code.Stloc_0: locals[0] = stack.Pop(); pc++; break;
                    case Code.Stloc_1: locals[1] = stack.Pop(); pc++; break;
                    case Code.Stloc_2: locals[2] = stack.Pop(); pc++; break;
                    case Code.Stloc_3: locals[3] = stack.Pop(); pc++; break;
                    case Code.Stloc:
                    case Code.Stloc_S:
                        locals[((VariableDefinition)instr.Operand).Index] = stack.Pop();
                        pc++;
                        break;

                    // Constants
                    case Code.Ldc_I4_0: stack.Push((int)0); pc++; break;
                    case Code.Ldc_I4_1: stack.Push((int)1); pc++; break;
                    case Code.Ldc_I4_2: stack.Push((int)2); pc++; break;
                    case Code.Ldc_I4_3: stack.Push((int)3); pc++; break;
                    case Code.Ldc_I4_4: stack.Push((int)4); pc++; break;
                    case Code.Ldc_I4_5: stack.Push((int)5); pc++; break;
                    case Code.Ldc_I4_6: stack.Push((int)6); pc++; break;
                    case Code.Ldc_I4_7: stack.Push((int)7); pc++; break;
                    case Code.Ldc_I4_8: stack.Push((int)8); pc++; break;
                    case Code.Ldc_I4_M1: stack.Push((int)-1); pc++; break;
                    case Code.Ldc_I4:
                        stack.Push((int)instr.Operand);
                        pc++;
                        break;
                    case Code.Ldc_I4_S:
                        stack.Push((int)(sbyte)instr.Operand);
                        pc++;
                        break;
                    case Code.Ldc_I8:
                        stack.Push((long)instr.Operand);
                        pc++;
                        break;

                    // Arithmetic (int32)
                    case Code.Add:
                    {
                        var b = stack.Pop();
                        var a = stack.Pop();
                        if (a is long la && b is long lb)
                            stack.Push(la + lb);
                        else
                            stack.Push(ToInt(a) + ToInt(b));
                        pc++;
                        break;
                    }
                    case Code.Sub:
                    {
                        var b = stack.Pop();
                        var a = stack.Pop();
                        if (a is long la && b is long lb)
                            stack.Push(la - lb);
                        else
                            stack.Push(ToInt(a) - ToInt(b));
                        pc++;
                        break;
                    }
                    case Code.Mul:
                    {
                        var b = stack.Pop();
                        var a = stack.Pop();
                        if (a is long la && b is long lb)
                            stack.Push(la * lb);
                        else
                            stack.Push(ToInt(a) * ToInt(b));
                        pc++;
                        break;
                    }
                    case Code.Div:
                    {
                        var b = stack.Pop();
                        var a = stack.Pop();
                        if (a is long la && b is long lb)
                            stack.Push(la / lb);
                        else
                            stack.Push(ToInt(a) / ToInt(b));
                        pc++;
                        break;
                    }
                    case Code.Div_Un:
                    {
                        var b = stack.Pop();
                        var a = stack.Pop();
                        if (a is long la && b is long lb)
                            stack.Push((long)((ulong)la / (ulong)lb));
                        else
                            stack.Push((int)((uint)ToInt(a) / (uint)ToInt(b)));
                        pc++;
                        break;
                    }
                    case Code.Rem:
                    {
                        var b = stack.Pop();
                        var a = stack.Pop();
                        if (a is long la && b is long lb)
                            stack.Push(la % lb);
                        else
                            stack.Push(ToInt(a) % ToInt(b));
                        pc++;
                        break;
                    }
                    case Code.Rem_Un:
                    {
                        var b = stack.Pop();
                        var a = stack.Pop();
                        if (a is long la && b is long lb)
                            stack.Push((long)((ulong)la % (ulong)lb));
                        else
                            stack.Push((int)((uint)ToInt(a) % (uint)ToInt(b)));
                        pc++;
                        break;
                    }
                    case Code.Neg:
                    {
                        var a = stack.Pop();
                        if (a is long la)
                            stack.Push(-la);
                        else
                            stack.Push(-ToInt(a));
                        pc++;
                        break;
                    }

                    // Bitwise
                    case Code.And:
                    {
                        var b = stack.Pop();
                        var a = stack.Pop();
                        if (a is long la && b is long lb)
                            stack.Push(la & lb);
                        else
                            stack.Push(ToInt(a) & ToInt(b));
                        pc++;
                        break;
                    }
                    case Code.Or:
                    {
                        var b = stack.Pop();
                        var a = stack.Pop();
                        if (a is long la && b is long lb)
                            stack.Push(la | lb);
                        else if (a is long la2)
                            stack.Push(la2 | (long)ToInt(b));
                        else if (b is long lb2)
                            stack.Push((long)ToInt(a) | lb2);
                        else
                            stack.Push(ToInt(a) | ToInt(b));
                        pc++;
                        break;
                    }
                    case Code.Xor:
                    {
                        var b = stack.Pop();
                        var a = stack.Pop();
                        if (a is long la && b is long lb)
                            stack.Push(la ^ lb);
                        else
                            stack.Push(ToInt(a) ^ ToInt(b));
                        pc++;
                        break;
                    }
                    case Code.Shl:
                    {
                        var b = stack.Pop();
                        var a = stack.Pop();
                        if (a is long la)
                            stack.Push(la << ToInt(b));
                        else
                            stack.Push(ToInt(a) << ToInt(b));
                        pc++;
                        break;
                    }
                    case Code.Shr:
                    {
                        var b = stack.Pop();
                        var a = stack.Pop();
                        if (a is long la)
                            stack.Push(la >> ToInt(b));
                        else
                            stack.Push(ToInt(a) >> ToInt(b));
                        pc++;
                        break;
                    }
                    case Code.Shr_Un:
                    {
                        var b = stack.Pop();
                        var a = stack.Pop();
                        if (a is long la)
                            stack.Push((long)((ulong)la >> ToInt(b)));
                        else
                            stack.Push((int)((uint)ToInt(a) >> ToInt(b)));
                        pc++;
                        break;
                    }
                    case Code.Not:
                    {
                        var a = stack.Pop();
                        if (a is long la)
                            stack.Push(~la);
                        else
                            stack.Push(~ToInt(a));
                        pc++;
                        break;
                    }

                    // Conversions
                    case Code.Conv_I1:
                        stack.Push((int)(sbyte)ToInt(stack.Pop()));
                        pc++;
                        break;
                    case Code.Conv_U1:
                        stack.Push((int)(byte)ToInt(stack.Pop()));
                        pc++;
                        break;
                    case Code.Conv_I2:
                        stack.Push((int)(short)ToInt(stack.Pop()));
                        pc++;
                        break;
                    case Code.Conv_U2:
                        stack.Push((int)(ushort)ToInt(stack.Pop()));
                        pc++;
                        break;
                    case Code.Conv_I4:
                    {
                        var v = stack.Pop();
                        stack.Push(ToInt(v));
                        pc++;
                        break;
                    }
                    case Code.Conv_U4:
                    {
                        var v = stack.Pop();
                        if (v is long lv)
                            stack.Push((int)(uint)lv);
                        else
                            stack.Push(ToInt(v));
                        pc++;
                        break;
                    }
                    case Code.Conv_I8:
                    {
                        var v = stack.Pop();
                        stack.Push((long)ToInt(v));
                        pc++;
                        break;
                    }
                    case Code.Conv_U8:
                    {
                        var v = stack.Pop();
                        stack.Push((long)(uint)ToInt(v));
                        pc++;
                        break;
                    }

                    // Comparison
                    case Code.Ceq:
                    {
                        var b = stack.Pop();
                        var a = stack.Pop();
                        if (a == null && b == null)
                            stack.Push((int)1);
                        else if (a == null || b == null)
                            stack.Push((int)0);
                        else if (a is long la && b is long lb)
                            stack.Push(la == lb ? (int)1 : (int)0);
                        else
                            stack.Push(ToInt(a) == ToInt(b) ? (int)1 : (int)0);
                        pc++;
                        break;
                    }
                    case Code.Cgt:
                    {
                        var b = stack.Pop();
                        var a = stack.Pop();
                        stack.Push(ToInt(a) > ToInt(b) ? (int)1 : (int)0);
                        pc++;
                        break;
                    }
                    case Code.Clt:
                    {
                        var b = stack.Pop();
                        var a = stack.Pop();
                        stack.Push(ToInt(a) < ToInt(b) ? (int)1 : (int)0);
                        pc++;
                        break;
                    }

                    // Branches
                    case Code.Br:
                    case Code.Br_S:
                    {
                        var target = (Instruction)instr.Operand;
                        pc = offsetMap[target.Offset];
                        break;
                    }
                    case Code.Brfalse:
                    case Code.Brfalse_S:
                    {
                        var v = stack.Pop();
                        if (IsZeroOrNull(v))
                            pc = offsetMap[((Instruction)instr.Operand).Offset];
                        else
                            pc++;
                        break;
                    }
                    case Code.Brtrue:
                    case Code.Brtrue_S:
                    {
                        var v = stack.Pop();
                        if (!IsZeroOrNull(v))
                            pc = offsetMap[((Instruction)instr.Operand).Offset];
                        else
                            pc++;
                        break;
                    }
                    case Code.Beq:
                    case Code.Beq_S:
                    {
                        var b = stack.Pop();
                        var a = stack.Pop();
                        if (ToInt(a) == ToInt(b))
                            pc = offsetMap[((Instruction)instr.Operand).Offset];
                        else
                            pc++;
                        break;
                    }
                    case Code.Bne_Un:
                    case Code.Bne_Un_S:
                    {
                        var b = stack.Pop();
                        var a = stack.Pop();
                        if ((uint)ToInt(a) != (uint)ToInt(b))
                            pc = offsetMap[((Instruction)instr.Operand).Offset];
                        else
                            pc++;
                        break;
                    }
                    case Code.Bge:
                    case Code.Bge_S:
                    {
                        var b = stack.Pop();
                        var a = stack.Pop();
                        if (ToInt(a) >= ToInt(b))
                            pc = offsetMap[((Instruction)instr.Operand).Offset];
                        else
                            pc++;
                        break;
                    }
                    case Code.Bge_Un:
                    case Code.Bge_Un_S:
                    {
                        var b = stack.Pop();
                        var a = stack.Pop();
                        if ((uint)ToInt(a) >= (uint)ToInt(b))
                            pc = offsetMap[((Instruction)instr.Operand).Offset];
                        else
                            pc++;
                        break;
                    }
                    case Code.Ble:
                    case Code.Ble_S:
                    {
                        var b = stack.Pop();
                        var a = stack.Pop();
                        if (ToInt(a) <= ToInt(b))
                            pc = offsetMap[((Instruction)instr.Operand).Offset];
                        else
                            pc++;
                        break;
                    }
                    case Code.Bgt:
                    case Code.Bgt_S:
                    {
                        var b = stack.Pop();
                        var a = stack.Pop();
                        if (ToInt(a) > ToInt(b))
                            pc = offsetMap[((Instruction)instr.Operand).Offset];
                        else
                            pc++;
                        break;
                    }
                    case Code.Blt:
                    case Code.Blt_S:
                    {
                        var b = stack.Pop();
                        var a = stack.Pop();
                        if (ToInt(a) < ToInt(b))
                            pc = offsetMap[((Instruction)instr.Operand).Offset];
                        else
                            pc++;
                        break;
                    }

                    // Switch
                    case Code.Switch:
                    {
                        var targets = (Instruction[])instr.Operand;
                        int val = ToInt(stack.Pop());
                        if (val >= 0 && val < targets.Length)
                        {
                            pc = offsetMap[targets[val].Offset];
                        }
                        else
                        {
                            pc++;  // Fall through
                        }
                        break;
                    }

                    // Array operations
                    case Code.Newarr:
                    {
                        int size = ToInt(stack.Pop());
                        var elemType = (TypeReference)instr.Operand;
                        if (elemType.FullName == "System.Byte")
                        {
                            stack.Push(new byte[size]);
                            Console.WriteLine($"  [{stepCount}] new byte[{size}]");
                        }
                        else
                        {
                            stack.Push(new object[size]);
                        }
                        pc++;
                        break;
                    }
                    case Code.Stelem_I1:
                    {
                        int val = ToInt(stack.Pop());
                        int idx = ToInt(stack.Pop());
                        var arr = stack.Pop();
                        if (arr is byte[] ba)
                        {
                            ba[idx] = (byte)val;
                        }
                        pc++;
                        break;
                    }
                    case Code.Ldelem_U1:
                    {
                        int idx = ToInt(stack.Pop());
                        var arr = stack.Pop();
                        if (arr is byte[] ba)
                            stack.Push((int)ba[idx]);
                        else
                            stack.Push((int)0);
                        pc++;
                        break;
                    }
                    case Code.Ldelem_I1:
                    {
                        int idx = ToInt(stack.Pop());
                        var arr = stack.Pop();
                        if (arr is byte[] ba)
                            stack.Push((int)(sbyte)ba[idx]);
                        else
                            stack.Push((int)0);
                        pc++;
                        break;
                    }
                    case Code.Ldlen:
                    {
                        var arr = stack.Pop();
                        if (arr is byte[] ba)
                            stack.Push((int)ba.Length);
                        else if (arr is object[] oa)
                            stack.Push((int)oa.Length);
                        else
                            stack.Push((int)0);
                        pc++;
                        break;
                    }

                    // Dup/Pop
                    case Code.Dup:
                        stack.Push(stack.Peek());
                        pc++;
                        break;
                    case Code.Pop:
                        stack.Pop();
                        pc++;
                        break;

                    // Method calls
                    case Code.Call:
                    case Code.Callvirt:
                    {
                        var calledMethod = (MethodReference)instr.Operand;
                        string methodName = calledMethod.Name;
                        int paramCount = calledMethod.Parameters.Count;
                        bool hasThis = calledMethod.HasThis;

                        if (methodName == "caC120Il6QhJUxYlgMd")
                        {
                            // Always returns true (null == null)
                            stack.Push((int)1);
                        }
                        else if (methodName == "rqDaSCIfBibcCJvS3cF")
                        {
                            // Always returns null
                            stack.Push(null);
                        }
                        else if (methodName == "Gdm4SanfKy")
                        {
                            // This is the method that stores the key/IV
                            // It takes (byte[] key, byte[] iv, BinaryReader reader)
                            // Pop 3 args from stack
                            // Params: key, iv, reader, plus 'this'
                            var poppedArgs = new object[paramCount];
                            for (int pi = paramCount - 1; pi >= 0; pi--)
                                poppedArgs[pi] = stack.Pop();
                            if (hasThis) stack.Pop(); // this

                            Console.WriteLine($"\n=== Gdm4SanfKy called at step {stepCount} ===");
                            // The first arg should be the key, second the IV
                            for (int pi = 0; pi < poppedArgs.Length; pi++)
                            {
                                if (poppedArgs[pi] is byte[] ba)
                                {
                                    Console.Write($"  Arg {pi} (byte[{ba.Length}]): ");
                                    for (int bi = 0; bi < ba.Length; bi++)
                                        Console.Write(ba[bi].ToString("x2"));
                                    Console.WriteLine();
                                    Console.Write($"  Arg {pi} decimal: [{string.Join(", ", Array.ConvertAll(ba, b => b.ToString()))}]");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine($"  Arg {pi}: {poppedArgs[pi]}");
                                }
                            }
                            // After this call, the method continues to state 130 (return)
                        }
                        else
                        {
                            // Generic call handling - pop args and possibly this
                            for (int pi = 0; pi < paramCount; pi++)
                                stack.Pop();
                            if (hasThis)
                                stack.Pop();

                            // If return type is not void, push null/0
                            if (calledMethod.ReturnType.FullName != "System.Void")
                            {
                                if (calledMethod.ReturnType.FullName == "System.Int32" ||
                                    calledMethod.ReturnType.FullName == "System.Boolean")
                                    stack.Push((int)0);
                                else if (calledMethod.ReturnType.FullName == "System.Int64")
                                    stack.Push((long)0);
                                else
                                    stack.Push(null);
                            }
                        }
                        pc++;
                        break;
                    }

                    // Newobj
                    case Code.Newobj:
                    {
                        var ctor = (MethodReference)instr.Operand;
                        int paramCount = ctor.Parameters.Count;
                        var ctorArgs = new object[paramCount];
                        for (int pi = paramCount - 1; pi >= 0; pi--)
                            ctorArgs[pi] = stack.Pop();

                        // Return a placeholder object
                        stack.Push(new object());
                        pc++;
                        break;
                    }

                    // Leave (exit try/catch, execute finally)
                    case Code.Leave:
                    case Code.Leave_S:
                    {
                        var target = (Instruction)instr.Operand;
                        int targetOffset = target.Offset;

                        // Clear the stack (leave clears the evaluation stack)
                        stack.Clear();

                        // Check if we need to execute a finally handler
                        int currentOffset = instr.Offset;
                        bool foundFinally = false;

                        foreach (var eh in handlers)
                        {
                            if (eh.HandlerType == ExceptionHandlerType.Finally)
                            {
                                // If current instruction is inside the try block
                                if (currentOffset >= eh.TryStart.Offset && currentOffset < eh.TryEnd.Offset)
                                {
                                    // Execute finally block, then go to target
                                    leaveTargets.Push(offsetMap[targetOffset]);
                                    pc = offsetMap[eh.HandlerStart.Offset];
                                    foundFinally = true;
                                    break;
                                }
                            }
                        }

                        if (!foundFinally)
                        {
                            pc = offsetMap[targetOffset];
                        }
                        break;
                    }

                    // Endfinally
                    case Code.Endfinally:
                    {
                        if (leaveTargets.Count > 0)
                        {
                            pc = leaveTargets.Pop();
                        }
                        else
                        {
                            pc++;
                        }
                        break;
                    }

                    // Ldnull
                    case Code.Ldnull:
                        stack.Push(null);
                        pc++;
                        break;

                    // Isinst (type check)
                    case Code.Isinst:
                    {
                        var obj = stack.Pop();
                        // Just keep the object (simplified)
                        stack.Push(obj);
                        pc++;
                        break;
                    }

                    // Castclass
                    case Code.Castclass:
                    {
                        // Keep the object on stack
                        pc++;
                        break;
                    }

                    // Box/Unbox
                    case Code.Box:
                        pc++;
                        break;
                    case Code.Unbox_Any:
                    {
                        pc++;
                        break;
                    }

                    // Ldsfld / Stsfld
                    case Code.Ldsfld:
                    {
                        var field = (FieldReference)instr.Operand;
                        stack.Push(null);
                        pc++;
                        break;
                    }
                    case Code.Stsfld:
                    {
                        stack.Pop();
                        pc++;
                        break;
                    }

                    // Ldfld
                    case Code.Ldfld:
                    {
                        stack.Pop(); // this
                        stack.Push(null);
                        pc++;
                        break;
                    }

                    // Initobj
                    case Code.Initobj:
                    {
                        stack.Pop(); // address
                        pc++;
                        break;
                    }

                    // Ldloca
                    case Code.Ldloca:
                    case Code.Ldloca_S:
                    {
                        // Push a reference to the local (simplified: push index)
                        int idx = ((VariableDefinition)instr.Operand).Index;
                        stack.Push(new LocalRef(idx));
                        pc++;
                        break;
                    }

                    // Stobj
                    case Code.Stobj:
                    {
                        var val = stack.Pop();
                        var addr = stack.Pop();
                        if (addr is LocalRef lr)
                        {
                            locals[lr.Index] = val;
                        }
                        pc++;
                        break;
                    }

                    // Ldobj
                    case Code.Ldobj:
                    {
                        var addr = stack.Pop();
                        if (addr is LocalRef lr)
                            stack.Push(locals[lr.Index]);
                        else
                            stack.Push(null);
                        pc++;
                        break;
                    }

                    // Constrained prefix
                    case Code.Constrained:
                        pc++;
                        break;

                    // Conv_R4, Conv_R8
                    case Code.Conv_R4:
                    case Code.Conv_R8:
                        pc++;
                        break;

                    // Mul_Ovf_Un
                    case Code.Mul_Ovf_Un:
                    {
                        var b = stack.Pop();
                        var a = stack.Pop();
                        if (a is long la && b is long lb)
                            stack.Push(la * lb);
                        else
                            stack.Push(ToInt(a) * ToInt(b));
                        pc++;
                        break;
                    }

                    // Throw
                    case Code.Throw:
                    {
                        stack.Pop();
                        Console.WriteLine($"  THROW at step {stepCount}");
                        running = false;
                        break;
                    }

                    default:
                        Console.WriteLine($"  UNHANDLED: {opcode} at @{instr.Offset:X4} step {stepCount}");
                        running = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  EXCEPTION at step {stepCount}, @{instr.Offset:X4} {opcode}: {ex.Message}");
                // Try to continue
                pc++;
            }
        }

        Console.WriteLine($"\nExecution completed. Steps: {stepCount}");

        // Dump locals that are byte arrays
        Console.WriteLine("\n=== Final local variable values ===");
        for (int i = 0; i < locals.Length; i++)
        {
            if (locals[i] is byte[] ba)
            {
                Console.Write($"  Local {i} (byte[{ba.Length}]): ");
                for (int j = 0; j < ba.Length; j++)
                    Console.Write(ba[j].ToString("x2"));
                Console.WriteLine();
                Console.Write($"  Local {i} decimal: [{string.Join(", ", Array.ConvertAll(ba, b => b.ToString()))}]");
                Console.WriteLine();
            }
            else if (locals[i] is int iv)
            {
                Console.WriteLine($"  Local {i} (int): {iv} (0x{iv:X8})");
            }
            else if (locals[i] is long lv)
            {
                Console.WriteLine($"  Local {i} (long): {lv} (0x{lv:X16})");
            }
            else
            {
                Console.WriteLine($"  Local {i}: {locals[i]?.GetType()?.Name ?? "null"}");
            }
        }

        assembly.Dispose();
    }

    static int ToInt(object v)
    {
        if (v is int i) return i;
        if (v is long l) return (int)l;
        if (v is uint u) return (int)u;
        if (v is byte b) return (int)b;
        if (v is sbyte sb) return (int)sb;
        if (v is short s) return (int)s;
        if (v is ushort us) return (int)us;
        if (v is bool bo) return bo ? 1 : 0;
        return 0;
    }

    static bool IsZeroOrNull(object v)
    {
        if (v == null) return true;
        if (v is int i) return i == 0;
        if (v is long l) return l == 0;
        if (v is bool b) return !b;
        return false;
    }
}

class LocalRef
{
    public int Index;
    public LocalRef(int index) { Index = index; }
}
