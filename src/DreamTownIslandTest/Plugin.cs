using BepInEx;
using BepInEx.Unity.IL2CPP;

namespace DreamTownIslandTest;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public sealed class Plugin : BasePlugin
{
    public const string PluginGuid = "com.maodei.dreamtownisland.test";
    public const string PluginName = "Dream Town Island Test";
    public const string PluginVersion = "0.1.0";

    public override void Load()
    {
        Log.LogInfo("Hello Dream Town Island! DreamTownIslandTest plugin loaded.");
    }
}
