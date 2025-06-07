# Analyse-vrising-mod

This repository holds a single decompiled C# source file from a VRising BepInEx mod. A base64 dump of the original `VRisingBephinex.dll` is provided as `VRisingBephinex.dll.txt`. All other artifacts from the original dump were removed for clarity.

## Aim target color configuration

The decompiled mod did not originally allow the highlight color of an aimed player to be changed. The following changes add a new configuration entry so the color can be specified in the configuration file:

- **Lines 9214–9231** define a `ConfigEntry<string>` called `ESPAimTargetColor` and a `ParsedAimTargetColor` property which interprets the text value as a named color or HTML code. Spaces around the value are trimmed before parsing.
- **Line 9448** binds the new `ESPAimTargetColor` entry in the mod configuration constructor.
- **Line 23688** uses `ParsedAimTargetColor` when an aimed player is drawn instead of the previous hard‑coded red.

With these modifications the highlight color can be set to any name supported by `ColorEx` or to an HTML hex code (e.g. `#ff00ff`).
