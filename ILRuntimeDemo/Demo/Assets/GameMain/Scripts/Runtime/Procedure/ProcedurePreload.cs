using System.IO;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;
using GameFramework.Resource;
using UnityEngine;
using UnityEngine.Networking;
///
///<>
///
public class ProcedurePreload : ProcedureBase2
{
    private LoadAssetCallbacks callBack;
    private string preUri;
    private int uiPackageCount;

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
        if (Game.m_UpdateResourceForm != null)
        {
            GameObject.Destroy(Game.m_UpdateResourceForm.gameObject);
            Game.m_UpdateResourceForm = null;
        }
        //开始预加载，将必要资源加载进内存
        //readonlypath readwritepath是在resourcecomponent里start时设置的
        //LoadResourceAgent类中Start方法开始加载资源实现assets路径与完成磁盘路径的关联
        startILRuntime();
    }


    private void startILRuntime()
    {
        LoadILRuntime();
    }

    private void LoadILRuntime()
    {
        var dllrequest = UnityWebRequest.Get("file:///" + Application.streamingAssetsPath + "/DemoILRuntime.dll");
        dllrequest.downloadHandler = new DownloadHandlerBuffer();
        dllrequest.SendWebRequest();
        var pdbrequest = UnityWebRequest.Get("file:///" + Application.streamingAssetsPath + "/DemoILRuntime.pdb");
        pdbrequest.downloadHandler = new DownloadHandlerBuffer();
        pdbrequest.SendWebRequest();
        while (true)
        {
            if (dllrequest.isDone && pdbrequest.isDone)
            {
                break;
            }
        }

        MemoryStream fs = new MemoryStream(dllrequest.downloadHandler.data);
        MemoryStream p = new MemoryStream(pdbrequest.downloadHandler.data);
        var domain = new ILRuntime.Runtime.Enviorment.AppDomain();
        domain.LoadAssembly(fs, p, new ILRuntime.Mono.Cecil.Pdb.PdbReaderProvider());

        OnILRuntimeInitialized(domain);
    }

    private void OnILRuntimeInitialized(ILRuntime.Runtime.Enviorment.AppDomain appDomain)
    {
        Game.RegistAdapter(appDomain);
        appDomain.Invoke("DemoILRuntime.GameRoot", "Init", null, null);
    }
}