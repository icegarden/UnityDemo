using GameFramework.Fsm;
using GameFramework.Procedure;
using GameFramework.Resource;
using System;
using UnityGameFramework.Runtime;

public class ProcedureUpdateVersion : ProcedureBase2
{
    private bool m_UpdateVersionComplete = false;

    private UpdateVersionListCallbacks m_UpdateVersionListCallbacks = null;


    public override bool UseNativeDialog
    {
        get
        {
            return true;
        }
    }

    protected override void OnInit(IFsm<IProcedureManager> procedureOwner)
    {
        base.OnInit(procedureOwner);
        m_UpdateVersionListCallbacks = new UpdateVersionListCallbacks(onUpdateVersionListSuccess, onUpdateVersionListFailure);
    }

    protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
    {
        base.OnEnter(procedureOwner);
        m_UpdateVersionComplete = false;
        Game.Resource.UpdateVersionList(procedureOwner.GetData<VarInt32>("VersionListLength"), procedureOwner.GetData<VarInt32>("VersionListHashCode"), procedureOwner.GetData<VarInt32>("VersionListCompressedLength"), procedureOwner.GetData<VarInt32>("VersionListCompressedHashCode"), m_UpdateVersionListCallbacks);
        procedureOwner.RemoveData("VersionListLength");
        procedureOwner.RemoveData("VersionListHashCode");
        procedureOwner.RemoveData("VersionListCompressedLength");
        procedureOwner.RemoveData("VersionListCompressedHashCode");
    }

    protected override void OnUpdate(IFsm<IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
        if (!m_UpdateVersionComplete)
        {
            return;
        }
        ChangeState<ProcedureVerifyResources>(procedureOwner);
    }

    private void onUpdateVersionListFailure(string downloadUri, string errorMessage)
    {
        Log.Warning("Update version list from '{0}' failure,error message is '{1}'.", downloadUri, errorMessage);
    }

    private void onUpdateVersionListSuccess(string downloadPath, string downloadUri)
    {
        m_UpdateVersionComplete = true;
        Log.Info("Update version list from '{0}' success.", downloadUri);
    }
}