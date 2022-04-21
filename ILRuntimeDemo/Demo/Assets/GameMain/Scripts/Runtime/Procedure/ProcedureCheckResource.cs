﻿using System.Diagnostics;
using GameFramework.Fsm;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;

public class ProcedureCheckResource : ProcedureBase2
{
    private bool m_CheckResourcesComplete = false;
    private bool m_NeedUpdateResources = false;
    private int m_UpdateResourceCount = 0;
    private long m_UpdateResourceTotalCompressedLength = 0L;

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
        m_CheckResourcesComplete = false;
        m_NeedUpdateResources = false;
        m_UpdateResourceCount = 0;
        m_UpdateResourceTotalCompressedLength = 0L;
        Game.Resource.CheckResources(OnCheckResourcesComplete);
    }

    protected override void OnUpdate(IFsm<IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
        if (!m_CheckResourcesComplete)
        {
            return;
        }
        if (m_NeedUpdateResources)
        {
            procedureOwner.SetData<VarInt32>("UpdateResourceCount", m_UpdateResourceCount);
            procedureOwner.SetData<VarInt64>("UpdateResourceTotalCompressedLength", m_UpdateResourceTotalCompressedLength);
            ChangeState<ProcedureUpdateResources>(procedureOwner);
        }
        else
        {
            ChangeState<ProcedurePreload>(procedureOwner);
        }
    }

    private void OnCheckResourcesComplete(int moveCount, int removeCount, int updateCount, long updateTotalLength, long updateTotalCompressedLength)
    {
        m_CheckResourcesComplete = true;
        m_NeedUpdateResources = updateCount > 0;
        m_UpdateResourceCount = updateCount;
        m_UpdateResourceTotalCompressedLength = updateTotalCompressedLength;
        Log.Info("Check resources complete,'{0}' resources need to update,compressed length is '{1}', uncompressed length is '{2}'.", updateCount.ToString(), updateTotalCompressedLength.ToString(), updateTotalLength.ToString());
    }
}