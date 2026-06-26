# Build Directory

This directory is reserved for future build, release, and packaging scripts.

At the current stage, plugin deployment is handled by `Directory.Build.targets`, which copies the compiled plugin DLL to the local BepInEx `plugins` directory after a successful build.
