using UnityEngine;
using FairyGUI;
using System.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using ILRuntime.Runtime.Intepreter;
using ProtoBuf;

public partial class Game : MonoBehaviour
{
    public static BuiltinDataComponent BuiltinData
    {
        get;
        private set;
    }
    public static FairyGUIComponent FairyGUIComponent
    {
        get;
        private set;
    }

    public static System.Type[] allTypes;

    public static ILRuntime.Runtime.Enviorment.AppDomain AppDomain
    {
        get;
        private set;
    }
    private static void InitCustomComponents()
    {
        BuiltinData = UnityGameFramework.Runtime.GameEntry.GetComponent<BuiltinDataComponent>();
        FairyGUIComponent = UnityGameFramework.Runtime.GameEntry.GetComponent<FairyGUIComponent>();
        ET.Log.ILog = new ET.UnityLogger();
    }

    public static void BindFairyGui(string url, string name)
    {
        UIObjectFactory.SetPackageItemExtension(url, () =>
        {
            return Game.AppDomain.Instantiate<GComponent>(name);
        });
    }

    public static void RegistAdapter(ILRuntime.Runtime.Enviorment.AppDomain appDomain)
    {
        LitJson.JsonMapper.RegisterILRuntimeCLRRedirection(appDomain);
        appDomain.RegisterCrossBindingAdaptor(new IAsyncStateMachineClassInheritanceAdaptor());
        appDomain.RegisterCrossBindingAdaptor(new GComponentAdaptor());
        appDomain.RegisterCrossBindingAdaptor(new GButtonAdaptor());
        appDomain.RegisterCrossBindingAdaptor(new GProgressBarAdaptor());
        appDomain.RegisterCrossBindingAdaptor(new GLabelAdaptor());
        appDomain.RegisterCrossBindingAdaptor(new GComboBoxAdaptor());
        appDomain.RegisterCrossBindingAdaptor(new GSliderAdaptor());
        appDomain.RegisterCrossBindingAdaptor(new EventDispatcherAdaptor());


        appDomain.DelegateManager.RegisterMethodDelegate<EventContext>();
        appDomain.DelegateManager.RegisterMethodDelegate<Spine.TrackEntry>();

        appDomain.DelegateManager.RegisterMethodDelegate<List<object>>();
        appDomain.DelegateManager.RegisterMethodDelegate<object>();
        appDomain.DelegateManager.RegisterMethodDelegate<bool>();
        appDomain.DelegateManager.RegisterMethodDelegate<string>();
        appDomain.DelegateManager.RegisterMethodDelegate<float>();
        appDomain.DelegateManager.RegisterMethodDelegate<long, int>();
        appDomain.DelegateManager.RegisterMethodDelegate<long>();
        appDomain.DelegateManager.RegisterMethodDelegate<long, MemoryStream>();
        appDomain.DelegateManager.RegisterMethodDelegate<long, IPEndPoint>();
        appDomain.DelegateManager.RegisterMethodDelegate<ILTypeInstance>();
        appDomain.DelegateManager.RegisterMethodDelegate<AsyncOperation>();

        appDomain.DelegateManager.RegisterFunctionDelegate<System.Type, System.Type>();



        appDomain.DelegateManager.RegisterFunctionDelegate<UnityEngine.Events.UnityAction>();
        appDomain.DelegateManager.RegisterFunctionDelegate<System.Object, ET.ETTask>();
        appDomain.DelegateManager.RegisterFunctionDelegate<ILTypeInstance, bool>();
        appDomain.DelegateManager.RegisterFunctionDelegate<System.Collections.Generic.KeyValuePair<System.String, System.Int32>, System.String>();
        appDomain.DelegateManager.RegisterFunctionDelegate<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>, System.Boolean>();
        appDomain.DelegateManager.RegisterFunctionDelegate<System.Collections.Generic.KeyValuePair<System.String, System.Int32>, System.Int32>();
        appDomain.DelegateManager.RegisterFunctionDelegate<List<int>, int>();
        appDomain.DelegateManager.RegisterFunctionDelegate<List<int>, bool>();
        appDomain.DelegateManager.RegisterFunctionDelegate<int, bool>();//Linq
        appDomain.DelegateManager.RegisterFunctionDelegate<int, int, int>();//Linq
        appDomain.DelegateManager.RegisterFunctionDelegate<KeyValuePair<int, List<int>>, bool>();
        appDomain.DelegateManager.RegisterFunctionDelegate<KeyValuePair<int, int>, KeyValuePair<int, int>, int>();
        appDomain.DelegateManager.RegisterMethodDelegate<System.Int64, System.Collections.Generic.List<System.Int64>>();
        appDomain.DelegateManager.RegisterMethodDelegate<System.Int64, System.Collections.Generic.List<ILRuntime.Runtime.Intepreter.ILTypeInstance>>();
        appDomain.DelegateManager.RegisterFunctionDelegate<System.Int64, System.Collections.Generic.List<System.Int64>, System.Boolean>();
        appDomain.DelegateManager.RegisterFunctionDelegate<System.Int64, System.Collections.Generic.List<ILRuntime.Runtime.Intepreter.ILTypeInstance>, System.Boolean>();

        appDomain.DelegateManager.RegisterMethodDelegate<ET.AService>();

        appDomain.DelegateManager.RegisterDelegateConvertor<EventCallback0>((action) =>
        {
            return new EventCallback0(() =>
            {
                ((System.Action)action)();
            });
        });
        appDomain.DelegateManager.RegisterDelegateConvertor<EventCallback1>((action) =>
        {
            return new EventCallback1((a) =>
            {
                ((System.Action<EventContext>)action)(a);
            });
        });
        appDomain.DelegateManager.RegisterDelegateConvertor<Spine.AnimationState.TrackEntryDelegate>((act) =>
        {
            return new Spine.AnimationState.TrackEntryDelegate((trackEntry) =>
            {
                ((System.Action<Spine.TrackEntry>)act)(trackEntry);
            });
        });

        appDomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction>((act) =>
        {
            return new UnityEngine.Events.UnityAction(() =>
            {
                ((Action)act)();
            });
        });

        appDomain.DelegateManager.RegisterDelegateConvertor<Comparison<KeyValuePair<int, int>>>((act) =>
        {
            return new Comparison<KeyValuePair<int, int>>((x, y) =>
            {
                return ((Func<KeyValuePair<int, int>, KeyValuePair<int, int>, int>)act)(x, y);
            });
        });

        //ע��ProtoBuf��CLR
        PType.RegisterILRuntimeCLRRedirection(appDomain);

        ////////////////////////////////////
        // CLR�󶨵�ע�ᣬһ��Ҫ�ǵý�CLR�󶨵�ע��д��CLR�ض����ע����棬��Ϊͬһ������ֻ�ܱ��ض���һ�Σ�ֻ����ע����Ǹ�������Ч
        ////////////////////////////////////
        Type t = Type.GetType("ILRuntime.Runtime.Generated.CLRBindings");
        if (t != null)
        {
            t.GetMethod("Initialize")?.Invoke(null, new object[] { appDomain });
        }
        //ILRuntime.Runtime.Generated.CLRBindings.Initialize(appdomain);

        allTypes = appDomain.LoadedTypes.Values.Select(x => x.ReflectionType).ToArray();
        appDomain.DebugService.StartDebugService(56000);
        Game.AppDomain = appDomain;
    }

    private void Update()
    {
        if(AppDomain == null)
        {
            return;
        }
        AppDomain.Invoke("DemoILRuntime.GameRoot", "Update", null, null);
    }

    private void LateUpdate()
    {
       if(AppDomain == null) { 
            return;
        }
        AppDomain.Invoke("DemoILRuntime.GameRoot", "LateUpdate", null, null);
    }

    private void FixedUpdate()
    {
        if (AppDomain == null)
        {
            return;
        }
        AppDomain.Invoke("DemoILRuntime.GameRoot", "FixedUpdate", null, null);
    }
}