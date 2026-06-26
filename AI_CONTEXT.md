# AI_CONTEXT.md

## Project

DreamTownIslandModKit is a modding project for Steam version of Dream Town Island / 鍒涢€犻兘甯傚矝鐗╄.

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

- `DreamTownIslandModKit.sln`: root solution for mod SDK projects.
- `Directory.Build.props`: shared .NET, C#, game directory, BepInEx, and interop reference settings.
- `Directory.Build.targets`: shared post-build plugin deployment.
- `build/`: future build, release, and packaging scripts.
- `src/`: C# plugin source code.
- `src/DreamTownIslandTest/`: minimal BepInEx 6 IL2CPP sample plugin.
- `docs/`: setup notes, reverse engineering notes, development logs.
- `libs/`: local reference instructions only. Do not commit game DLLs.
- `dist/`: optional build artifacts. Do not commit game files.
- `tools/`: tool notes and scripts.

## Build setup

- Current target framework: `net8.0`.
- Current SDK pin: .NET SDK `8.0.422` via `global.json`.
- If the project later installs and standardizes on .NET 6 SDK, switch the shared `TargetFramework` to `net6.0`.
- `GameDir` defaults to `C:\Program Files (x86)\Steam\steamapps\common\Dream Town Island`.
- Plugin projects reference BepInEx and Unity interop DLLs from the local game directory by `HintPath` with `Private=false`.
- Successful plugin builds copy only the plugin DLL to `$(GameDir)\BepInEx\plugins`.

## Legal / distribution rules

- Do not commit or distribute original game files.
- Do not commit `GameAssembly.dll`, `UnityPlayer.dll`, `KairoGames_Data`, `.assets`, `.bundle`, `.resS`, or full modified game resources.
- Prefer distributing source code, plugin DLLs, patchers, and original assets only.

