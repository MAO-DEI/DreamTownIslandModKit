# AI_CONTEXT.md

## Project

DreamTownIslandModKit is a modding project for Steam version of Dream Town Island / 创造都市岛物语.

## Game environment

- Game executable: KairoGames.exe
- Unity version: 2021.3.11f1
- Runtime: IL2CPP
- Architecture: x86 / 32-bit
- Loader: BepInEx 6 Unity IL2CPP win-x86
- Working BepInEx build: 6.0.0-be.760

## Current findings

- x64 BepInEx does not work because the game process is x86.
- BepInEx be.784 caused an Il2Cpp interop generation error.
- BepInEx be.760 successfully generated interop assemblies.
- `UnityEngine.UIElementsModule.dll` preload warning appears but does not block startup.
- `Chainloader startup complete` indicates BepInEx is working.

## Repository structure

- `src/`: C# plugin source code.
- `docs/`: setup notes, reverse engineering notes, development logs.
- `libs/`: local reference instructions only. Do not commit game DLLs.
- `dist/`: optional build artifacts. Do not commit game files.
- `tools/`: tool notes and scripts.

## Legal / distribution rules

- Do not commit or distribute original game files.
- Do not commit `GameAssembly.dll`, `UnityPlayer.dll`, `KairoGames_Data`, `.assets`, `.bundle`, `.resS`, or full modified game resources.
- Prefer distributing source code, plugin DLLs, patchers, and original assets only.