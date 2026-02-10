#!/usr/bin/env python3
"""
Decrypt strings from VRisingBephinex.dll protected by .NET Reactor.

This script:
1. Parses the obfuscated control flow of Oam4On22qR to extract the 32-byte XOR key
2. Extracts the 16-byte IV from case 180
3. Implements the XOR decryption (l084oTo8hr) and key schedule (iww4yX1iDE)
4. Decrypts all embedded strings from the resource
"""

import struct
import re
import sys
import os


def parse_inner_switch(source_lines):
    """
    Extract case blocks from the inner switch of Oam4On22qR only.
    Returns a dict mapping case number -> list of instruction lines.
    Also returns the default case body.
    """
    # Find the method
    method_start = None
    for i, line in enumerate(source_lines):
        if 'private static void Oam4On22qR' in line:
            method_start = i
            break

    if method_start is None:
        raise ValueError("Cannot find Oam4On22qR method")

    # Find the inner while(true) switch
    inner_switch_start = None
    for i in range(method_start + 20, method_start + 40):
        if 'while (true)' in source_lines[i]:
            inner_switch_start = i
            break

    # Find the end (finally block)
    finally_line = None
    for i in range(inner_switch_start, method_start + 2500):
        if source_lines[i].strip() == 'finally':
            finally_line = i
            break

    # Parse cases between inner_switch_start and finally_line
    cases = {}
    default_body = []
    current_case = None
    current_body = []
    in_default = False

    for i in range(inner_switch_start, finally_line):
        stripped = source_lines[i].strip()

        m = re.match(r'case (\d+):', stripped)
        if m:
            # Save previous
            if current_case is not None:
                cases[current_case] = current_body
            elif in_default:
                default_body = current_body

            current_case = int(m.group(1))
            current_body = []
            in_default = False
            continue

        if stripped == 'default:':
            if current_case is not None:
                cases[current_case] = current_body
            current_case = None
            current_body = []
            in_default = True
            continue

        if current_case is not None or in_default:
            current_body.append(stripped)

    # Save last case
    if current_case is not None:
        cases[current_case] = current_body
    elif in_default:
        default_body = current_body

    return cases, default_body


def simulate(cases, default_body):
    """
    Simulate the state machine starting from state 56.
    caC120Il6QhJUxYlgMd() -> always True
    rqDaSCIfBibcCJvS3cF() -> always null
    """
    array2 = [0] * 32
    num3 = 56
    num5 = 0
    num6 = 0
    num7 = 0

    max_steps = 5000
    visited_states = []

    for step in range(max_steps):
        if num3 == 130:
            break

        visited_states.append(num3)

        body = cases.get(num3, default_body)
        if body is None:
            break

        next_state = None
        goto_target = None
        skip_cond = False

        i = 0
        while i < len(body):
            line = body[i].rstrip(';').strip()
            i += 1

            if not line or line in ('break', 'continue', '{', '}', 'try'):
                continue
            if line == 'return':
                num3 = 130
                break

            # Handle conditionals properly
            if 'if (caC120Il6QhJUxYlgMd())' in line:
                # Always TRUE - find the body of the if
                # Next meaningful line should be inside { }
                depth = 0
                found_assignment = False
                while i < len(body):
                    inner = body[i].strip().rstrip(';')
                    i += 1
                    if inner == '{':
                        depth += 1
                        continue
                    if inner == '}':
                        depth -= 1
                        if depth <= 0:
                            break
                        continue
                    m = re.match(r'num3 = (\d+)', inner)
                    if m and not found_assignment:
                        next_state = int(m.group(1))
                        found_assignment = True
                continue

            if 'if (!caC120Il6QhJUxYlgMd())' in line:
                # Always FALSE - skip if block
                depth = 0
                while i < len(body):
                    inner = body[i].strip()
                    i += 1
                    if inner == '{':
                        depth += 1
                        continue
                    if inner == '}':
                        depth -= 1
                        if depth <= 0:
                            break
                        continue
                continue

            if 'if (rqDaSCIfBibcCJvS3cF() == null)' in line:
                # Always TRUE (null == null)
                depth = 0
                found_assignment = False
                while i < len(body):
                    inner = body[i].strip().rstrip(';')
                    i += 1
                    if inner == '{':
                        depth += 1
                        continue
                    if inner == '}':
                        depth -= 1
                        if depth <= 0:
                            break
                        continue
                    m = re.match(r'num3 = (\d+)', inner)
                    if m and not found_assignment:
                        next_state = int(m.group(1))
                        found_assignment = True
                continue

            if 'if (rqDaSCIfBibcCJvS3cF() != null)' in line:
                # Always FALSE
                depth = 0
                while i < len(body):
                    inner = body[i].strip()
                    i += 1
                    if inner == '{':
                        depth += 1
                        continue
                    if inner == '}':
                        depth -= 1
                        if depth <= 0:
                            break
                        continue
                continue

            # Assignments
            m = re.match(r'array2\[(\d+)\] = \(byte\)num7', line)
            if m:
                array2[int(m.group(1))] = num7 & 0xFF
                continue

            m = re.match(r'array2\[(\d+)\] = \(byte\)num6', line)
            if m:
                array2[int(m.group(1))] = num6 & 0xFF
                continue

            m = re.match(r'array2\[(\d+)\] = (\d+)', line)
            if m:
                array2[int(m.group(1))] = int(m.group(2)) & 0xFF
                continue

            m = re.match(r'num7 = (\d+) \+ (\d+)', line)
            if m:
                num7 = int(m.group(1)) + int(m.group(2))
                continue

            m = re.match(r'num7 = (\d+) - (\d+)', line)
            if m:
                num7 = int(m.group(1)) - int(m.group(2))
                continue

            m = re.match(r'num6 = (\d+) \+ (\d+)', line)
            if m:
                num6 = int(m.group(1)) + int(m.group(2))
                continue

            m = re.match(r'num6 = (\d+) - (\d+)', line)
            if m:
                num6 = int(m.group(1)) - int(m.group(2))
                continue

            m = re.match(r'num3 = (\d+)', line)
            if m:
                next_state = int(m.group(1))
                continue

            m = re.match(r'num5 = (\d+)', line)
            if m:
                num5 = int(m.group(1))
                continue

            if 'goto IL_0074' in line:
                goto_target = num5
                continue

            # Skip complex lines (binaryReader, array5, array2 = new byte[32], etc)
            if 'binaryReader' in line:
                continue
            if 'array5' in line:
                continue
            if 'array2 = new byte' in line:
                array2 = [0] * 32
                continue

        if num3 == 130:
            break

        if goto_target is not None:
            num3 = goto_target
        elif next_state is not None:
            num3 = next_state
        else:
            print(f"  [STUCK] No transition at state {num3}, step {step}")
            print(f"  Body: {body[:10]}")
            break

    return bytes(array2), step, visited_states


def extract_iv_from_case180(source_code):
    """
    Extract the 16-byte IV from case 180 in Oam4On22qR.
    The last assignment to each array3[N] wins.
    """
    idx = source_code.find("case 180:")
    if idx == -1:
        raise ValueError("Cannot find case 180")

    section = source_code[idx:idx + 10000]
    iv = [0] * 16
    num4 = 0

    for line in section.split('\n'):
        line = line.strip().rstrip(';')

        m = re.match(r'num4 = (\d+) \+ (\d+)', line)
        if m:
            num4 = int(m.group(1)) + int(m.group(2))
            continue

        m = re.match(r'num4 = (\d+) - (\d+)', line)
        if m:
            num4 = int(m.group(1)) - int(m.group(2))
            continue

        m = re.match(r'array3\[(\d+)\] = \(byte\)num4', line)
        if m:
            iv[int(m.group(1))] = num4 & 0xFF
            continue

        m = re.match(r'array3\[(\d+)\] = (\d+)', line)
        if m:
            iv[int(m.group(1))] = int(m.group(2)) & 0xFF
            continue

        if 'Gdm4SanfKy' in line:
            break

    return bytes(iv)


def iww4yX1iDE(P_0):
    """Key schedule function.
    CRITICAL: IL uses 32-bit mul then conv.u8, NOT 64-bit mul.
    The decompiler incorrectly showed 64-bit multiplications.
    """
    P_0 = P_0 & 0xFFFFFFFF
    num = P_0
    num2 = 973202305
    num3 = 1582787682
    num4 = 1577548636
    num5 = 332884210

    # IL: ldloc.3 * ldc.i4 → mul(32-bit) → conv.u8
    num6 = (num4 * 1313243236) & 0xFFFFFFFF  # 32-bit mul!
    num6 |= 1
    # IL: ldloc.2 * ldloc.2 → mul(32-bit) → conv.u8 → rem.un → conv.u4
    num3 = ((num3 * num3) & 0xFFFFFFFF) % num6
    num3 &= 0xFFFFFFFF

    # IL: ldc.i4 * ldloc.3 → mul(32-bit) → conv.u8
    num7 = (1907532890 * num4) & 0xFFFFFFFF  # 32-bit mul!
    if num7 == 0:
        num7 -= 1
    # Dead computation (result discarded via pop)

    num2 = (-502326134 - num3) & 0xFFFFFFFF

    # IL: ldloc.2 * ldc.i4 → mul(32-bit) → conv.u8
    num8 = (num3 * 183835789) & 0xFFFFFFFF  # 32-bit mul!
    num8 |= 1
    # IL: ldloc.3 * ldloc.3 → mul(32-bit) → conv.u8 → rem.un → conv.u4
    num4 = ((num4 * num4) & 0xFFFFFFFF) % num8
    num4 &= 0xFFFFFFFF

    num9 = (((num5 >> 6) | ((num5 << 26) & 0xFFFFFFFF)) ^ num3) & 0xFFFFFFFF
    num10 = num9 & 0x0F0F0F0F
    num5 = (((num9 & 0xF0F0F0F0) >> 4) | ((num10 << 4) & 0xFFFFFFFF)) & 0xFFFFFFFF

    num ^= (num << 3) & 0xFFFFFFFF
    num &= 0xFFFFFFFF
    num = (num + num2) & 0xFFFFFFFF
    num ^= (num << 11) & 0xFFFFFFFF
    num &= 0xFFFFFFFF
    num = (num + num4) & 0xFFFFFFFF
    num ^= (num >> 27)
    num &= 0xFFFFFFFF
    num = (num + num5) & 0xFFFFFFFF

    result = (((((num2 << 11) & 0xFFFFFFFF) - num3) & 0xFFFFFFFF) ^ num4) & 0xFFFFFFFF
    result = (result - num) & 0xFFFFFFFF
    return result


def l084oTo8hr(key, data):
    """XOR decryption with key schedule."""
    if len(data) == 0:
        return b''

    remainder = len(data) % 4
    num_blocks = len(data) // 4
    result = bytearray(len(data))
    key_blocks = len(key) // 4
    accumulator = 0

    if remainder > 0:
        num_blocks += 1

    for i in range(num_blocks):
        key_idx = i % key_blocks
        block_offset = i * 4

        ki = key_idx * 4
        key_val = (key[ki] | (key[ki+1] << 8) | (key[ki+2] << 16) | (key[ki+3] << 24)) & 0xFFFFFFFF

        if i == num_blocks - 1 and remainder > 0:
            data_val = 0
            for j in range(remainder):
                if j > 0:
                    data_val = (data_val << 8) & 0xFFFFFFFF
                data_val |= data[-(1 + j)]

            accumulator = (accumulator + key_val) & 0xFFFFFFFF
            accumulator = (accumulator + iww4yX1iDE(accumulator)) & 0xFFFFFFFF

            xored = (accumulator ^ data_val) & 0xFFFFFFFF
            mask = 0xFF
            shift = 0
            for k in range(remainder):
                if k > 0:
                    mask = (mask << 8) & 0xFFFFFFFF
                    shift += 8
                result[block_offset + k] = (xored & mask) >> shift
        else:
            di = block_offset
            data_val = (data[di] | (data[di+1] << 8) | (data[di+2] << 16) | (data[di+3] << 24)) & 0xFFFFFFFF

            accumulator = (accumulator + key_val) & 0xFFFFFFFF
            accumulator = (accumulator + iww4yX1iDE(accumulator)) & 0xFFFFFFFF

            xored = (accumulator ^ data_val) & 0xFFFFFFFF
            result[block_offset] = xored & 0xFF
            result[block_offset + 1] = (xored >> 8) & 0xFF
            result[block_offset + 2] = (xored >> 16) & 0xFF
            result[block_offset + 3] = (xored >> 24) & 0xFF

    return bytes(result)


def decode_strings(decrypted_data):
    """Parse decrypted string table. Format: 4-byte length + UTF-16LE string bytes."""
    strings = {}
    offset = 0

    while offset + 4 <= len(decrypted_data):
        str_len = struct.unpack_from('<I', decrypted_data, offset)[0]

        if str_len == 0 or str_len > 10000 or offset + 4 + str_len > len(decrypted_data):
            # Try next offset
            offset += 1
            continue

        str_bytes = decrypted_data[offset + 4:offset + 4 + str_len]
        try:
            decoded = str_bytes.decode('utf-16-le')
            if all(c.isprintable() or c in '\t\n\r' for c in decoded):
                strings[offset] = decoded
                offset += 4 + str_len
            else:
                offset += 1
        except:
            offset += 1

    return strings


def main():
    base_dir = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))

    source_path = os.path.join(base_dir, "VRisingBephinex", "VRisingBephinex.decompiled.cs")
    print(f"Reading decompiled source: {source_path}")
    with open(source_path, 'r') as f:
        source_code = f.read()
    source_lines = source_code.split('\n')

    # Step 1: Parse and simulate the state machine
    print("\n=== Step 1: Parsing inner switch of Oam4On22qR ===")
    cases, default_body = parse_inner_switch(source_lines)
    print(f"  Found {len(cases)} cases in the inner switch")
    print(f"  Default case body: {default_body[:5]}")

    # Check what case 0 would be (should not exist -> default)
    if 0 in cases:
        print(f"  WARNING: case 0 found in inner switch: {cases[0][:3]}")
    else:
        print(f"  case 0 not in switch -> uses default (num6={39+119}, num3=92)")

    print("\n=== Step 2: Simulating state machine ===")
    key, steps, path = simulate(cases, default_body)
    print(f"  Simulation completed in {steps} steps")
    print(f"  State path (first 30): {path[:30]}")
    print(f"  Key (32 bytes): {key.hex()}")
    print(f"  Key bytes: [{', '.join(str(b) for b in key)}]")

    # Step 2b: Extract IV
    print("\n=== Step 3: Extracting IV from case 180 ===")
    iv = extract_iv_from_case180(source_code)
    print(f"  IV (16 bytes): {iv.hex()}")
    print(f"  IV bytes: [{', '.join(str(b) for b in iv)}]")

    # Step 3: Read encrypted resource
    resource_path = os.path.join(base_dir, "tools", "extracted",
                                  "e76hfvnUuLT8Tw03QQ_w56xu2OeVGRUMquo4r.bin")
    print(f"\n=== Step 4: Reading encrypted resource ===")
    with open(resource_path, 'rb') as f:
        encrypted_data = f.read()
    print(f"  Resource size: {len(encrypted_data)} bytes")

    # Step 4: Decrypt
    print("\n=== Step 5: Decrypting resource ===")
    decrypted = l084oTo8hr(key, encrypted_data)

    decrypted_path = os.path.join(base_dir, "tools", "extracted", "strings_decrypted.bin")
    with open(decrypted_path, 'wb') as f:
        f.write(decrypted)
    print(f"  Saved to: {decrypted_path}")
    print(f"  First 64 bytes: {decrypted[:64].hex()}")

    # Check if decrypted data looks valid (contains readable strings)
    # Try to find length-prefixed Unicode strings
    print("\n=== Step 6: Decoding strings ===")
    strings = decode_strings(decrypted)
    print(f"  Decoded {len(strings)} strings")

    if len(strings) == 0:
        print("\n  No strings found. Trying brute force check on first few bytes...")
        # Show first 256 bytes as potential string data
        for off in range(0, min(256, len(decrypted)-4), 4):
            val = struct.unpack_from('<I', decrypted, off)[0]
            if 2 <= val <= 200 and off + 4 + val <= len(decrypted):
                try:
                    s = decrypted[off+4:off+4+val].decode('utf-16-le')
                    if all(c.isprintable() or c in '\t\n\r' for c in s):
                        print(f"    [0x{off:04X}] len={val}: {repr(s)}")
                except:
                    pass

    # Save strings
    strings_path = os.path.join(base_dir, "tools", "extracted", "decrypted_strings.txt")
    with open(strings_path, 'w', encoding='utf-8') as f:
        f.write("# Decrypted strings from VRisingBephinex.dll\n")
        f.write(f"# Key: {key.hex()}\n")
        f.write(f"# IV: {iv.hex()}\n")
        f.write(f"# Total: {len(strings)} strings\n\n")
        for offset, s in sorted(strings.items()):
            f.write(f"[0x{offset:04X}] {s}\n")

    print(f"  Strings saved to: {strings_path}")

    if strings:
        print(f"\n=== First 30 decoded strings ===")
        for i, (offset, s) in enumerate(sorted(strings.items())):
            if i >= 30:
                print("  ...")
                break
            print(f"  [0x{offset:04X}] {repr(s)}")


if __name__ == '__main__':
    main()
