﻿using BepInEx;
using BepisPlugins;

namespace BGMLoader
{
    [BepInProcess(Constants.GameProcessName)]
    [BepInProcess(Constants.GameProcessNameSteam)]
    [BepInProcess(Constants.VRProcessName)]
    [BepInProcess(Constants.VRProcessNameSteam)]
    [BepInPlugin(GUID, PluginName, Version)]
    [BepInDependency(XUnity.ResourceRedirector.Constants.PluginData.Identifier)]
    public partial class BGMLoader : BaseUnityPlugin { }
}
