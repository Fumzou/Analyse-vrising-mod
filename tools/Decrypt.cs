using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

/// <summary>
/// Decrypts strings from VRisingBephinex.dll.
/// Uses the key extracted by the Python state machine simulator.
/// </summary>
class Decrypt
{
    static void Main(string[] args)
    {
        string resourcePath = args.Length > 0 ? args[0] : "tools/extracted/e76hfvnUuLT8Tw03QQ_w56xu2OeVGRUMquo4r.bin";
        string outputDir = "tools/extracted";

        // Key from Python simulator (verified by tracing 233 states)
        byte[] key = new byte[32] {
            184, 72, 167, 115, 44, 50, 193, 51,
            210, 224, 200, 114, 99, 254, 35, 173,
            181, 247, 112, 62, 206, 105, 3, 61,
            63, 85, 218, 26, 53, 241, 36, 51
        };

        // IV from case 180
        byte[] iv = new byte[16] {
            167, 23, 121, 20, 238, 154, 131, 247,
            82, 162, 14, 87, 119, 73, 26, 249
        };

        Console.WriteLine("Key: " + BitConverter.ToString(key).Replace("-", "").ToLower());
        Console.WriteLine("IV: " + BitConverter.ToString(iv).Replace("-", "").ToLower());

        // Verify KeySchedule with test values
        Console.WriteLine("\n=== KeySchedule verification ===");
        Console.WriteLine($"  KeySchedule(0) = {iww4yX1iDE(0)} (0x{iww4yX1iDE(0):X8})");
        Console.WriteLine($"  KeySchedule(1) = {iww4yX1iDE(1)} (0x{iww4yX1iDE(1):X8})");
        Console.WriteLine($"  KeySchedule(0x73A748B8) = {iww4yX1iDE(0x73A748B8)} (0x{iww4yX1iDE(0x73A748B8):X8})");

        // Read encrypted resource
        byte[] encrypted = File.ReadAllBytes(resourcePath);
        Console.WriteLine($"\nResource size: {encrypted.Length} bytes");
        Console.Write("First 32 bytes encrypted: ");
        for (int i = 0; i < 32; i++) Console.Write(encrypted[i].ToString("x2"));
        Console.WriteLine();

        // Decrypt
        byte[] decrypted = l084oTo8hr(key, encrypted);

        // Save raw decrypted
        File.WriteAllBytes(Path.Combine(outputDir, "strings_decrypted.bin"), decrypted);

        Console.Write("First 64 bytes decrypted: ");
        for (int i = 0; i < Math.Min(64, decrypted.Length); i++)
            Console.Write(decrypted[i].ToString("x2"));
        Console.WriteLine();

        // Decode strings
        var strings = DecodeStrings(decrypted);
        Console.WriteLine($"\nDecoded {strings.Count} strings");

        // Save to file
        string txtPath = Path.Combine(outputDir, "decrypted_strings.txt");
        using (var w = new StreamWriter(txtPath, false, Encoding.UTF8))
        {
            w.WriteLine("# Decrypted strings from VRisingBephinex.dll");
            w.WriteLine($"# Key: {BitConverter.ToString(key).Replace("-", "").ToLower()}");
            w.WriteLine($"# IV: {BitConverter.ToString(iv).Replace("-", "").ToLower()}");
            w.WriteLine($"# Total: {strings.Count} strings\n");
            foreach (var kv in strings)
                w.WriteLine($"[0x{kv.Key:X4}] {kv.Value}");
        }
        Console.WriteLine($"Saved: {txtPath}");

        // Print strings
        Console.WriteLine("\n=== Decoded strings ===");
        int count = 0;
        foreach (var kv in strings)
        {
            if (count++ >= 80) { Console.WriteLine("..."); break; }
            Console.WriteLine($"  [0x{kv.Key:X4}] {kv.Value}");
        }

        // If no strings found, try alternative approaches
        if (strings.Count == 0)
        {
            Console.WriteLine("\nNo strings found. Checking first 256 bytes for patterns...");
            for (int off = 0; off < Math.Min(256, decrypted.Length - 4); off += 2)
            {
                int len = BitConverter.ToInt32(decrypted, off);
                if (len >= 2 && len <= 500 && len % 2 == 0 && off + 4 + len <= decrypted.Length)
                {
                    try
                    {
                        string s = Encoding.Unicode.GetString(decrypted, off + 4, len);
                        bool valid = true;
                        foreach (char c in s)
                        {
                            if (c < 0x20 && c != '\t' && c != '\n' && c != '\r')
                            {
                                valid = false;
                                break;
                            }
                        }
                        if (valid)
                            Console.WriteLine($"  [0x{off:X4}] len={len}: \"{s}\"");
                    }
                    catch { }
                }
            }
        }
    }

    // Corrected reimplementation of iww4yX1iDE
    // CRITICAL FIX: IL uses 32-bit mul then conv.u8, NOT 64-bit mul.
    // The decompiler incorrectly showed 64-bit multiplications.
    static uint iww4yX1iDE(uint P_0)
    {
        uint num = P_0;
        uint num2 = 973202305u;
        uint num3 = 1582787682u;
        uint num4 = 1577548636u;
        uint num5 = 332884210u;
        // IL: mul(32-bit) then conv.u8
        ulong num6 = (ulong)(uint)(num4 * (uint)1313243236);
        num6 |= 1;
        num3 = (uint)((ulong)(uint)(num3 * num3) % num6);
        // IL: mul(32-bit) then conv.u8
        ulong num7 = (ulong)(uint)((uint)1907532890 * num4);
        if (num7 == 0L)
        {
            num7--;
        }
        // Dead computation (result popped in IL)
        num2 = (uint)(-502326134 - (int)num3);
        // IL: mul(32-bit) then conv.u8
        ulong num8 = (ulong)(uint)(num3 * (uint)183835789);
        num8 |= 1;
        num4 = (uint)((ulong)(uint)(num4 * num4) % num8);
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

    // Exact reimplementation of l084oTo8hr
    static byte[] l084oTo8hr(byte[] key, byte[] data)
    {
        if (data.Length == 0)
            return new byte[0];

        int remainder = data.Length % 4;
        int numBlocks = data.Length / 4;
        byte[] result = new byte[data.Length];
        int keyBlocks = key.Length / 4;
        uint accumulator = 0;

        if (remainder > 0)
            numBlocks++;

        for (int i = 0; i < numBlocks; i++)
        {
            int keyIdx = i % keyBlocks;
            int blockOffset = i * 4;
            uint ki = (uint)(keyIdx * 4);
            uint keyVal = (uint)((key[ki + 3] << 24) | (key[ki + 2] << 16) | (key[ki + 1] << 8) | key[ki]);

            if (i == numBlocks - 1 && remainder > 0)
            {
                uint dataVal = 0;
                for (int j = 0; j < remainder; j++)
                {
                    if (j > 0)
                        dataVal <<= 8;
                    dataVal |= data[data.Length - 1 - j];
                }
                accumulator += keyVal;
                accumulator += iww4yX1iDE(accumulator);
                uint xored = accumulator ^ dataVal;
                uint mask = 0xFF;
                int shift = 0;
                for (int k = 0; k < remainder; k++)
                {
                    if (k > 0)
                    {
                        mask <<= 8;
                        shift += 8;
                    }
                    result[blockOffset + k] = (byte)((xored & mask) >> shift);
                }
            }
            else
            {
                uint di = (uint)blockOffset;
                uint dataVal = (uint)((data[di + 3] << 24) | (data[di + 2] << 16) | (data[di + 1] << 8) | data[di]);
                accumulator += keyVal;
                accumulator += iww4yX1iDE(accumulator);
                uint xored = accumulator ^ dataVal;
                result[blockOffset] = (byte)(xored & 0xFF);
                result[blockOffset + 1] = (byte)((xored >> 8) & 0xFF);
                result[blockOffset + 2] = (byte)((xored >> 16) & 0xFF);
                result[blockOffset + 3] = (byte)((xored >> 24) & 0xFF);
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
                    if (c < 0x20 && c != '\t' && c != '\n' && c != '\r')
                    {
                        valid = false;
                        break;
                    }
                }
                if (valid)
                {
                    strings[offset] = s;
                    offset += 4 + strLen;
                }
                else
                {
                    offset++;
                }
            }
            catch
            {
                offset++;
            }
        }
        return strings;
    }
}
