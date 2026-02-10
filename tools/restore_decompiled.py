#!/usr/bin/env python3
from __future__ import annotations
import re
from pathlib import Path

ROOT = Path(__file__).resolve().parents[1]
SRC = ROOT / "VRisingBephinex/VRisingBephinex.decompiled.cs"
STRINGS = ROOT / "tools/extracted/decrypted_strings.txt"
OUT = ROOT / "VRisingBephinex/VRisingBephinex.restored.cs"

FIELD_RE = re.compile(r"(?:<Module>\{[^}]+\}\.)?m_32fa63a2f47c40cabe232e2a88d38b1e\.(m_[a-f0-9]{32})")
ASSIGN_RE = re.compile(r"(?:<Module>\{[^}]+\}\.)?m_32fa63a2f47c40cabe232e2a88d38b1e\.(m_[a-f0-9]{32})\s*=\s*(.+?);")


def csharp_int(v: int) -> int:
    v &= 0xFFFFFFFF
    return v - 0x100000000 if v & 0x80000000 else v


def replace_fields(expr: str, constants: dict[str, int]) -> str:
    def repl(m: re.Match[str]) -> str:
        name = m.group(1)
        if name not in constants:
            raise KeyError(name)
        return str(constants[name])

    return FIELD_RE.sub(repl, expr)


def parse_expr(expr: str, constants: dict[str, int]) -> int:
    e = replace_fields(expr, constants)
    e = re.sub(r"\((?:uint|int|byte|short)\)", "", e)
    e = e.replace("unchecked", "")

    # only arithmetic operators now
    if re.search(r"[^0-9xXa-fA-F_\-+*/()<>|&^~\s]", e):
        raise ValueError(f"Unsupported expression: {expr}\n=> {e}")

    val = eval(e, {"__builtins__": None}, {})  # noqa: S307
    return csharp_int(int(val))


def parse_constants(source: str) -> dict[str, int]:
    constants: dict[str, int] = {}
    pending = [(m.group(1), m.group(2)) for m in ASSIGN_RE.finditer(source)]

    for _ in range(30):
        next_pending = []
        changed = False
        for name, expr in pending:
            if name in constants:
                continue
            try:
                constants[name] = parse_expr(expr, constants)
                changed = True
            except Exception:
                next_pending.append((name, expr))
        pending = next_pending
        if not changed:
            break
    return constants


def parse_strings(path: Path) -> dict[int, str]:
    mapping: dict[int, str] = {}
    r = re.compile(r"^\[(0x[0-9A-Fa-f]+)\]\s(.*)$")
    for line in path.read_text(encoding="utf-8-sig").splitlines():
        m = r.match(line)
        if m:
            mapping[int(m.group(1), 16)] = m.group(2)
    return mapping


def csharp_string_literal(s: str) -> str:
    return '"' + s.replace('\\', '\\\\').replace('"', '\\"') + '"'


def replace_calls(source: str, constants: dict[str, int], strings: dict[int, str]) -> tuple[str, int, int]:
    needle = "jiUnG6yLcp99YsGsEb2.xDx43IEi2K("
    i = 0
    out = []
    replaced = unresolved = 0

    while True:
        j = source.find(needle, i)
        if j == -1:
            out.append(source[i:])
            break
        out.append(source[i:j])
        k = j + len(needle)
        depth = 1
        while k < len(source) and depth > 0:
            ch = source[k]
            if ch == '(':
                depth += 1
            elif ch == ')':
                depth -= 1
            k += 1
        expr = source[j + len(needle):k - 1]
        replacement = None
        try:
            idx = parse_expr(expr, constants)
            if idx < 0:
                idx &= 0xFFFFFFFF
            if idx in strings:
                replacement = csharp_string_literal(strings[idx])
        except Exception:
            pass

        if replacement is None:
            unresolved += 1
            out.append(source[j:k])
        else:
            replaced += 1
            out.append(replacement)
        i = k

    return "".join(out), replaced, unresolved


def main() -> None:
    source = SRC.read_text(encoding="utf-8")
    constants = parse_constants(source)
    strings = parse_strings(STRINGS)
    restored, replaced, unresolved = replace_calls(source, constants, strings)
    OUT.write_text(restored, encoding="utf-8")
    print(f"constants={len(constants)} strings={len(strings)} replaced={replaced} unresolved={unresolved}")


if __name__ == "__main__":
    main()
