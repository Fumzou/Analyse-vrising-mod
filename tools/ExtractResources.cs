using System;
using System.IO;
using System.Collections.Generic;
using Mono.Cecil;

class ExtractResources
{
    static void Main(string[] args)
    {
        string dllPath = args.Length > 0 ? args[0] : "VRisingBephinex.dll";
        string outputDir = args.Length > 1 ? args[1] : "extracted_resources";

        if (!Directory.Exists(outputDir))
            Directory.CreateDirectory(outputDir);

        Console.WriteLine($"Loading assembly: {dllPath}");

        var readerParams = new ReaderParameters { ReadSymbols = false };
        var assembly = AssemblyDefinition.ReadAssembly(dllPath, readerParams);

        Console.WriteLine($"Assembly: {assembly.FullName}");
        Console.WriteLine($"Modules: {assembly.Modules.Count}");

        foreach (var module in assembly.Modules)
        {
            Console.WriteLine($"\nModule: {module.Name}");
            Console.WriteLine($"  Types: {module.Types.Count}");
            Console.WriteLine($"  Resources: {module.Resources.Count}");

            foreach (var resource in module.Resources)
            {
                Console.WriteLine($"\n  Resource: {resource.Name}");
                Console.WriteLine($"    Type: {resource.ResourceType}");

                if (resource is EmbeddedResource embeddedRes)
                {
                    byte[] data = embeddedRes.GetResourceData();
                    Console.WriteLine($"    Size: {data.Length} bytes");

                    string safeName = resource.Name.Replace(".", "_").Replace("/", "_");
                    string outPath = Path.Combine(outputDir, safeName + ".bin");
                    File.WriteAllBytes(outPath, data);
                    Console.WriteLine($"    Saved to: {outPath}");

                    // Show first 64 bytes hex
                    Console.Write("    First 64 bytes: ");
                    for (int i = 0; i < Math.Min(64, data.Length); i++)
                        Console.Write(data[i].ToString("x2"));
                    Console.WriteLine();
                }
            }

            // List all types
            Console.WriteLine("\n  === Types ===");
            foreach (var type in module.Types)
            {
                if (type.Name.StartsWith("<") || type.Namespace == "Microsoft.CodeAnalysis"
                    || type.Namespace == "System.Runtime.CompilerServices")
                    continue;

                Console.WriteLine($"    {type.FullName}");

                // Show methods with their RVA
                foreach (var method in type.Methods)
                {
                    if (method.HasBody)
                    {
                        var body = method.Body;
                        Console.WriteLine($"      Method: {method.Name} (IL size: {body.CodeSize}, MaxStack: {body.MaxStackSize})");
                    }
                    else
                    {
                        Console.WriteLine($"      Method: {method.Name} (no body)");
                    }
                }
            }
        }

        assembly.Dispose();
        Console.WriteLine("\nDone.");
    }
}
