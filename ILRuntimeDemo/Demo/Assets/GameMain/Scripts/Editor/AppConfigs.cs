using GameFramework;
using System.IO;
using UnityEngine;
using UnityGameFramework.Editor;
using UnityGameFramework.Editor.ResourceTools;

/// <summary>
/// 这个类必须是静态类
/// 这个文件一定要放Editor目录下
/// </summary>
public static class AppConfigs
{
    [BuildSettingsConfigPath]
    public static string BuildSettingsConfig = Utility.Path.GetRegularPath(Path.Combine(Application.dataPath, "GameMain/AppConfigs/BuildSettings.xml"));

    [ResourceCollectionConfigPath]
    public static string ResourceCollectionConfig = Utility.Path.GetRegularPath(Path.Combine(Application.dataPath, "GameMain/AppConfigs/ResourceCollection.xml"));

    [ResourceEditorConfigPath]
    public static string ResourceEditorConfig = Utility.Path.GetRegularPath(Path.Combine(Application.dataPath, "GameMain/AppConfigs/ResourceEditor.xml"));

    [ResourceBuilderConfigPath]
    public static string ResourceBuilderConfig = Utility.Path.GetRegularPath(Path.Combine(Application.dataPath, "GameMain/AppConfigs/ResourceBuilder.xml"));

}
