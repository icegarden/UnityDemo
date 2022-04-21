
using UnityEditor;
using UnityEngine;
using System.Runtime.CompilerServices;

public static class GenerateCLRBindingByAnalysis
{

    [MenuItem("ILRuntime/Generate CLR Binding Code by Analysis")]
    public static void GenerateCLRBinding()
    {
        //用新的分析热更dll调用引用来生成绑定代码
        ILRuntime.Runtime.Enviorment.AppDomain domain = new ILRuntime.Runtime.Enviorment.AppDomain();
        using (System.IO.FileStream fs = new System.IO.FileStream("Assets/StreamingAssets/DemoILRuntime.dll", System.IO.FileMode.Open, System.IO.FileAccess.Read))
        {
            domain.LoadAssembly(fs);

            //Crossbind Adapter is needed to generate the correct binding code
            InitILRuntime(domain);
            ILRuntime.Runtime.CLRBinding.BindingCodeGenerator.GenerateBindingCode(domain, "Assets/ILRuntime/Generated");
        }

        AssetDatabase.Refresh();
    }


    static void InitILRuntime(ILRuntime.Runtime.Enviorment.AppDomain appdomain)
    {
        //这里需要注册所有热更DLL中用到的跨域继承Adapter，否则无法正确抓取引用
        //注册自己写的适配器
        appdomain.RegisterCrossBindingAdaptor(new IAsyncStateMachineClassInheritanceAdaptor());
        appdomain.RegisterCrossBindingAdaptor(new GComponentAdaptor());
        appdomain.RegisterCrossBindingAdaptor(new GButtonAdaptor());
        appdomain.RegisterCrossBindingAdaptor(new GProgressBarAdaptor());
        appdomain.RegisterCrossBindingAdaptor(new GLabelAdaptor());
        appdomain.RegisterCrossBindingAdaptor(new GComboBoxAdaptor());
        appdomain.RegisterCrossBindingAdaptor(new GSliderAdaptor());
        appdomain.RegisterCrossBindingAdaptor(new EventDispatcherAdaptor());
        appdomain.RegisterValueTypeBinder(typeof(Vector2), new Vector2Binder());
        appdomain.RegisterValueTypeBinder(typeof(Vector3), new Vector3Binder());
        appdomain.RegisterValueTypeBinder(typeof(Quaternion), new QuaternionBinder());
    }
}