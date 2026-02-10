# Analyse-vrising-mod

This repository contains decompiled files of a VRising BepInEx mod for analysis.

## ESP configuration

A new config entry `AimTargetColor` in the `ESP` section controls the highlight
color for aimed players. Use any color name from `ColorEx` or an HTML color
code (e.g., `#ff00ff`).

## Restoring readable decompiled source

A helper script is available to rebuild a fuller decompiled file with decrypted string literals inlined:

```bash
python3 tools/restore_decompiled.py
```

It generates:

- `VRisingBephinex/VRisingBephinex.restored.cs`

This keeps all types/methods from the existing decompile and replaces almost all
`xDx43IEi2K(...)` string lookups with the decrypted plaintext values.
