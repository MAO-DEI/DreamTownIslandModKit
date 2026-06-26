# AI_TASKS.md

## Current stage

- Foundation .NET / BepInEx Mod SDK structure is established.
- The first sample plugin is `src/DreamTownIslandTest`.

## Completed

- Created root solution structure for SDK projects.
- Added shared MSBuild props for `net8.0`, nullable, language version, local game path, BepInEx core path, interop path, and plugins output path.
- Added shared MSBuild target to copy plugin DLLs after successful builds.
- Added minimal BepInEx 6 IL2CPP test plugin.
- Added repository ignore rules for build output, local BepInEx/game files, and Unity asset files.
- Documented the current development environment and setup pitfalls.

## Next priorities

- Build and launch the game with the deployed `DreamTownIslandTest.dll`.
- Confirm the BepInEx log contains: `Hello Dream Town Island! DreamTownIslandTest plugin loaded.`
- Decide later whether to keep `net8.0` or install .NET 6 SDK and switch the shared target framework to `net6.0`.
- Start reverse engineering only after the minimal plugin load path is verified.

## Blocked items

- No current code blocker. Runtime verification still requires launching the local game.
