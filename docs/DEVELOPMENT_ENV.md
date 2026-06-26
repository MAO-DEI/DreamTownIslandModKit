# Development Environment

Updated: 2026-06-26

## Game

- Title: Dream Town Island / 创造都市岛物语, Steam Windows version.
- Default install directory: `C:\Program Files (x86)\Steam\steamapps\common\Dream Town Island`.
- Executable: `KairoGames.exe`.
- Unity version: `2021.3.11f1`.
- Runtime: IL2CPP.
- Process architecture: x86 / 32-bit.

## .NET SDK

- Current repository SDK pin: `.NET SDK 8.0.422`, configured in `global.json`.
- Current project target framework: `net8.0`.
- `net8.0` is temporary because this machine has .NET 8 SDK available. If the project standardizes on .NET 6 later, install a .NET 6 SDK and switch the shared `TargetFramework` in `Directory.Build.props` to `net6.0`.

Verify installed SDKs:

```powershell
dotnet --list-sdks
```

Build the solution:

```powershell
dotnet build
```

## BepInEx

- Required loader: BepInEx 6 Unity IL2CPP win-x86.
- Verified working build: `6.0.0-be.760`.
- Do not use win-x64 BepInEx for this game.
- BepInEx `6.0.0-be.784` previously failed during Il2Cpp interop generation with `MissingMethodException`.
- `6.0.0-be.760` has successfully generated interop assemblies.

Expected local paths:

- Core assemblies: `$(GameDir)\BepInEx\core`.
- Interop assemblies: `$(GameDir)\BepInEx\interop`.
- Plugin output: `$(GameDir)\BepInEx\plugins`.

## Project Build Layout

- The root solution is `DreamTownIslandModKit.sln`.
- Shared MSBuild settings are in `Directory.Build.props`.
- Shared post-build deployment is in `Directory.Build.targets`.
- The sample plugin project is `src/DreamTownIslandTest/DreamTownIslandTest.csproj`.

`Directory.Build.props` defines the local `GameDir` and all BepInEx reference paths. Projects reference BepInEx and Unity interop assemblies by `HintPath`; do not copy those DLLs into this repository.

After a successful build, `Directory.Build.targets` copies only the current plugin project's main DLL to:

```text
C:\Program Files (x86)\Steam\steamapps\common\Dream Town Island\BepInEx\plugins\DreamTownIslandTest.dll
```

## Repository Rules

Do not commit original game or loader files, including:

- `BepInEx/`
- `KairoGames.exe`
- `GameAssembly.dll`
- `UnityPlayer.dll`
- `KairoGames_Data/`
- `*.assets`
- `*.resS`
- `*.bundle`
- `*.resource`

## Known Setup Issues

- Game bitness must be checked from the PE header; `GameAssembly.dll` existing does not imply x64.
- Installing BepInEx win-x64 produces no useful loader result for this x86 game.
- Installing only the .NET Runtime is insufficient; the SDK is required for builds.
- The developer machine can be x64 even though the game process is x86. Use the x64 .NET SDK for development.
- If `dotnet build` compiles but deployment fails with `Access to the path ... BepInEx\plugins\DreamTownIslandTest.dll is denied`, the Steam game directory is protected by Windows permissions. Re-run the build from an elevated shell or use a writable Steam library path; do not copy BepInEx or game DLLs into the repository as a workaround.

