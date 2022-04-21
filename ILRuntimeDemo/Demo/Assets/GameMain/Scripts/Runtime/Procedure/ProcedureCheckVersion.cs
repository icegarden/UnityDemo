using GameFramework;
using GameFramework.Event;
using GameFramework.Fsm;
using GameFramework.Procedure;
using GameFramework.Resource;
using UnityEngine;
using UnityGameFramework.Runtime;
using Version = GameFramework.Version;

public class ProcedureCheckVersion : ProcedureBase2
{
    private bool m_CheckVersionComplete = false;
    private bool m_NeedUpdateVersion = false;

    private VersionInfo m_VersionInfo = null;
    public override bool UseNativeDialog
    {
        get
        {
            return true;
        }
    }
    protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
    {
        base.OnEnter(procedureOwner);
        m_CheckVersionComplete = false;
        m_NeedUpdateVersion = false;
        m_VersionInfo = null;

        Game.Event.Subscribe(WebRequestSuccessEventArgs.EventId, onWebRequestSuccess);
        Game.Event.Subscribe(WebRequestFailureEventArgs.EventId, onWebRequestFaulure);
        Game.m_UpdateResourceForm.SetDesc("开始检测检测资源……");
        Game.WebRequest.AddWebRequest(Utility.Text.Format(Game.BuiltinData.BuildInfo.CheckVersionUrl, GetPlatformPath()), this);
    }

    protected override void OnLeave(IFsm<IProcedureManager> procedureOwner, bool isShutdown)
    {
        Game.Event.Unsubscribe(WebRequestSuccessEventArgs.EventId, onWebRequestSuccess);
        Game.Event.Unsubscribe(WebRequestFailureEventArgs.EventId, onWebRequestFaulure);
        base.OnLeave(procedureOwner, isShutdown);
    }

    protected override void OnUpdate(IFsm<IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
        if (!m_CheckVersionComplete)
        {
            return;
        }
        if (m_NeedUpdateVersion)
        {
            procedureOwner.SetData<VarInt32>("VersionListLength", m_VersionInfo.VersionListLength);
            procedureOwner.SetData<VarInt32>("VersionListHashCode", m_VersionInfo.VersionListHashCode);
            procedureOwner.SetData<VarInt32>("VersionListCompressedLength", m_VersionInfo.VersionListCompressedLength);
            procedureOwner.SetData<VarInt32>("VersionListCompressedHashCode", m_VersionInfo.VersionListCompressedHashCode);
            ChangeState<ProcedureUpdateVersion>(procedureOwner);
        }
        else
        {
            ChangeState<ProcedureVerifyResources>(procedureOwner);
        }
    }

    private void onWebRequestFaulure(object sender, GameEventArgs e)
    {
        WebRequestFailureEventArgs ne = (WebRequestFailureEventArgs)e;
        if (ne.UserData != this)
        {
            return;
        }
        Log.Warning("Check Version failure,error message is '{0}'.", ne.ErrorMessage);

    }

    private void onWebRequestSuccess(object sender, GameEventArgs e)
    {
        WebRequestSuccessEventArgs ne = (WebRequestSuccessEventArgs)e;
        if (ne.UserData != this)
        {
            return;
        }

        byte[] versionInfosBytes = ne.GetWebResponseBytes();
        string versionInfoString = Utility.Converter.GetString(versionInfosBytes);
        m_VersionInfo = Utility.Json.ToObject<VersionInfo>(versionInfoString);
        if (m_VersionInfo == null)
        {
            Log.Error("Parse VersionInfo failure");
        }
        Log.Info("Latest game version is '{0} ({1})',local game version is '{2} ({3})'", m_VersionInfo.LatestGameVersion, m_VersionInfo.InternalGameVersion.ToString(), Version.GameVersion, Version.InternalGameVersion.ToString());

        if (m_VersionInfo.ForceUpdateGame)
        {
            //强制更新APP
            //弹出强制更新界面
            return;
        }

        Game.Resource.UpdatePrefixUri = Utility.Path.GetRegularPath(m_VersionInfo.UpdatePrefixUri);

        m_CheckVersionComplete = true;
        m_NeedUpdateVersion = Game.Resource.CheckVersionList(m_VersionInfo.InternalResourceVersion) == CheckVersionListResult.NeedUpdate;

    }

    private string GetPlatformPath()
    {
        switch (Application.platform)
        {
            case RuntimePlatform.WindowsEditor:
            case RuntimePlatform.WindowsPlayer:
                return "windows";
            case RuntimePlatform.OSXEditor:
            case RuntimePlatform.OSXPlayer:
                return "MacOS";
            case RuntimePlatform.IPhonePlayer:
                return "IOS";
            case RuntimePlatform.Android:
                return "Android";
            default:
                throw new System.NotSupportedException(Utility.Text.Format("Platform '{0}' is not supported", Application.platform));
        }
    }
}

