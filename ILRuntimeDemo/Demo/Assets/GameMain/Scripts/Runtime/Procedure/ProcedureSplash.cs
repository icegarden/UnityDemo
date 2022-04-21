using System.Diagnostics;
using GameFramework;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;
using GameFramework.Resource;
using System;
using GameFramework.Localization;
using UnityEngine;

public class ProcedureSplash : ProcedureBase2
{
    private ProcedureOwner owner;
    public override bool UseNativeDialog
    {
        get
        {
            return true;
        }
    }
    protected override void OnEnter(ProcedureOwner procedureOwner)
    {
        base.OnEnter(procedureOwner);
        owner = procedureOwner;
        // 构建信息：发布版本时，把一些数据以 Json 的格式写入 Assets/GameMain/Configs/BuildInfo.txt，供游戏逻辑读取
        Game.BuiltinData.InitBuildInfo();

        // 语言配置：设置当前使用的语言，如果不设置，则默认使用操作系统语言
        InitLanguageSettings();

        // 变体配置：根据使用的语言，通知底层加载对应的资源变体
        InitCurrentVariant();

        // 声音配置：根据用户配置数据，设置即将使用的声音选项
        InitSoundSettings();

        // 默认字典：加载默认字典文件 Assets/GameMain/Configs/DefaultDictionary.xml
        // 此字典文件记录了资源更新前使用的各种语言的字符串，会随 App 一起发布，故不可更新
        Game.BuiltinData.InitDefaultDictionary();
        playSplash();
    }

    private void InitLanguageSettings()
    {
        if (Game.Base.EditorResourceMode && Game.Base.EditorLanguage != Language.Unspecified)
        {
            return;
        }
        Language language = Game.Localization.Language;
        if (Game.Setting.HasSetting(Constant.Setting.Language))
        {
            try
            {
                string languageString = Game.Setting.GetString(Constant.Setting.Language);
                language = (Language)Enum.Parse(typeof(Language), languageString);
            }
            catch
            {

            }
        }

        if (language != Language.English && language != Language.ChineseSimplified && language != Language.ChineseTraditional && language != Language.Korean)
        {
            language = Language.English;
            Game.Setting.SetString(Constant.Setting.Language, language.ToString());
            Game.Setting.Save();
        }
        Game.Localization.Language = language;
        Log.Info("Init language settings complete,current language is '{0}'.", language.ToString());
    }

    private void InitCurrentVariant()
    {
        if (Game.Base.EditorResourceMode)
        {
            return;
        }
        string currentVariant = null;
        switch (Game.Localization.Language)
        {
            case Language.English:
                currentVariant = "en-us";
                break;
            case Language.ChineseSimplified:
                currentVariant = "zh-cn";
                break;
            case Language.ChineseTraditional:
                currentVariant = "zh-tw";
                break;
            case Language.Korean:
                currentVariant = "ko-kr";
                break;
            default:
                currentVariant = "zh-cn";
                break;
        }
        Game.Resource.SetCurrentVariant(currentVariant);
        Log.Info("Init current variant complete");
    }

    private void InitSoundSettings()
    {

    }

    private void playSplash()
    {
        onSplashComplete();

    }

    private void onSplashComplete()
    {
        if (Game.Base.EditorResourceMode)
        {
            //编辑器模式
            ChangeState<ProcedurePreload>(owner);
        }
        else
        {
            if (Game.Resource.ResourceMode == ResourceMode.Package)
            {
                //单机模式

            }
            else
            {
                //线上联机游戏
                ChangeState<ProcedureCheckVersion>(owner);
            }
        }
    }
}

