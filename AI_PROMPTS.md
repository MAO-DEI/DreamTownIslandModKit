# AI_PROMPTS.md

## General coding prompt

Read `AI_CONTEXT.md`, `AI_TASKS.md`, `AI_PROMPTS.md`, and `AGENTS.md` first. Then implement the requested change. Keep documentation updates concise and update the relevant AI markdown files if project context, tasks, or prompt templates change.

## Hello plugin prompt

Create a minimal BepInEx 6 Unity IL2CPP plugin for Dream Town Island. Use `BasePlugin`, add a unique `BepInPlugin` ID, and log a startup message in `Load()`.

## SDK maintenance prompt

When adding a new plugin project, place it under `src/`, add it to `DreamTownIslandModKit.sln`, set `<IsBepInExPlugin>true</IsBepInExPlugin>`, reference BepInEx and Unity interop assemblies by `HintPath` from `Directory.Build.props`, and keep `<Private>false</Private>` so game and loader DLLs are not copied into repository output.

## Debugging prompt

Analyze the latest `BepInEx/LogOutput.log`. Identify whether the issue is caused by BepInEx loading, Il2Cpp interop generation, plugin discovery, plugin runtime error, or game-specific hook failure. Suggest the smallest next diagnostic step.

## Reverse engineering prompt

Inspect the generated interop assemblies and identify candidate classes related to residents, humans, citizens, town management, buildings, jobs, marriage, birth, appearance, sprites, or save data. Summarize likely entry points and unknowns.

## Documentation rule

After any code or architecture change, update `AI_CONTEXT.md`, `AI_TASKS.md`, or `AI_PROMPTS.md` only if the change affects them. In the final summary, list which files were updated and why.
