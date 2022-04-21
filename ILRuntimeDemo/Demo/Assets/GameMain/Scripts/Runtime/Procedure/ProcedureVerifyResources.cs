using GameFramework.Event;
using GameFramework.Fsm;
using GameFramework.Procedure;
using System;
using UnityGameFramework.Runtime;

public class ProcedureVerifyResources : ProcedureBase2
{
    private bool m_VerifyResourcesComplete = false;

    private float m_TotalVerifyCount;
    private float m_CurrentVerifyCount;

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
        Game.Event.Subscribe(ResourceVerifyStartEventArgs.EventId, OnResourceVerifyStart);
        Game.Event.Subscribe(ResourceVerifySuccessEventArgs.EventId, OnResourceVerifySuccess);
        Game.Event.Subscribe(ResourceVerifyFailureEventArgs.EventId, OnResourceVerifyFailure);

        m_VerifyResourcesComplete = false;
        Game.Resource.VerifyResources(OnVerifyResourcesComplete);
    }

    protected override void OnLeave(IFsm<IProcedureManager> procedureOwner, bool isShutdown)
    {
        base.OnLeave(procedureOwner, isShutdown);
        Game.Event.Unsubscribe(ResourceVerifyStartEventArgs.EventId, OnResourceVerifyStart);
        Game.Event.Unsubscribe(ResourceVerifySuccessEventArgs.EventId, OnResourceVerifySuccess);
        Game.Event.Unsubscribe(ResourceVerifyFailureEventArgs.EventId, OnResourceVerifyFailure);
    }

    protected override void OnUpdate(IFsm<IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
        if (!m_VerifyResourcesComplete)
        {
            return;
        }
        ChangeState<ProcedureCheckResource>(procedureOwner);
    }

    private void OnVerifyResourcesComplete(bool result)
    {
        m_VerifyResourcesComplete = true;
        Log.Info("Verify resource complete,result is '{0}'.", result);
    }


    private void OnResourceVerifyFailure(object sender, GameEventArgs e)
    {
        ResourceVerifyFailureEventArgs ne = (ResourceVerifyFailureEventArgs)e;
        Log.Warning("Verify resource '{0}' failure.", ne.Name);
    }

    private void OnResourceVerifySuccess(object sender, GameEventArgs e)
    {
        ResourceVerifySuccessEventArgs ne = (ResourceVerifySuccessEventArgs)e; ;
       // Log.Info("Verify resource '{0}' success.", ne.Name);
        m_CurrentVerifyCount += 1;
        Game.m_UpdateResourceForm.SetProgress(m_CurrentVerifyCount / m_TotalVerifyCount,"正在检测资源……");
    }

    private void OnResourceVerifyStart(object sender, GameEventArgs e)
    {
        ResourceVerifyStartEventArgs ne = (ResourceVerifyStartEventArgs)e;
        m_TotalVerifyCount = ne.Count;
        m_CurrentVerifyCount = 0;
        Game.m_UpdateResourceForm.SetProgress(0, "");
        Game.m_UpdateResourceForm.SetDesc("开始检测检测资源……");
        Log.Info("Start verify resources, verify resource count '{0}', verify resource total length '{1}'.", ne.Count, ne.TotalLength);
    }
}