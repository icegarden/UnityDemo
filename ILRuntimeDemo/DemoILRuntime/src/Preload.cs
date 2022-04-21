using System;
using System.IO;
using UnityEngine;
using FairyGUI;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DemoILRuntime
{
    public class Preload
    {
        private static Preload _ins;

        private string preUri;

        private double _cfgLoadCount;
        private double _cfgTotalCount;
        private double _uiLoadCount;
        private double _uiTotalCount;
        public static Preload GetInstance()
        {
            if (_ins == null)
            {
                _ins = new Preload();
            }
            return _ins;
        }

        public async void Start()
        {
            preUri = "Assets/GameMain/Assets/";
            await LoadPreoLoad();
            await LoadLoadingUI();
            await LoadCfgs();
            await LoadOtherUI();
            await LoadDianJiEffect();
            //初始化一些基础功能
            BaseDemand.Init();
            //注册Binder;
            RegistMediator.BindUI();
            //关闭Loading
            ModuleManager.Close(ModuleId.Loading);
            ModuleManager.Open(ModuleId.Login);

            NetService.Instance.Connect("120.26.61.250", 9994);
        }

        private Task<int> LoadPreoLoad()
        {
            var tcs = new TaskCompletionSource<int>();
            Task<int> task = tcs.Task;

            var loader = new ResourceItemLoader();
            loader.once(EventConst.BundleContentLoadComplete, (context) =>
            {
                var data = (object[])context.data;
                object asset = (object)data[0];
                string assetName = (string)data[1];
                var name = Path.GetFileNameWithoutExtension(assetName);
                BaseConfig.DecodeCfg(name, asset);
                tcs.SetResult(1);
            });
            loader.LoadBundleContent(Path.Combine(preUri, "Configs/Preload.json"));

            return task;
        }

        private Task<int> LoadDianJiEffect()
        {
            var tcs = new TaskCompletionSource<int>();
            Task<int> task = tcs.Task;
            var loader = new ResourceItemLoader();
            loader.once(EventConst.BundleContentLoadComplete, (context) => { 
                tcs.SetResult(1);
            });
            loader.LoadBundleContent("Assets/GameMain/Assets/Spine/effect/dianji_SkeletonData.asset");
            return task;
        }

        private Task<int> LoadLoadingUI()
        {
            var tcs = new TaskCompletionSource<int>();
            Task<int> task = tcs.Task;


            PreLoadConfig cfg = BaseConfig.GetConfig<PreLoadConfig>();
            var loadingUri = cfg.loading;
            if (loadingUri != null)
            {
                var loader = new ResourceItemLoader();
                loader.once(EventConst.BundleLoadComplete, (context) =>
                {
                    var data = (object[])context.data;
                    AssetBundle assetsBundle = (AssetBundle)data[0];
                    if (assetsBundle != null)
                    {
                        UIPackage.AddPackage(assetsBundle);
                        Loading.LoadingBinder.BindAll();
                    }
                    ModuleManager.Open(ModuleId.Loading);
                    tcs.SetResult(1);
                });
                loader.LoadBundleContent(Path.Combine(preUri, "UI/" + loadingUri + "_fui.bytes"));
            }

            return task;
        }

        private Task<int> LoadCfgs()
        {
            var tcs = new TaskCompletionSource<int>();
            Task<int> task = tcs.Task;
            //先加载配置
            PreLoadConfig cfg = BaseConfig.GetConfig<PreLoadConfig>();
            var total = cfg.configs.Count;
            _cfgTotalCount = total;
            _cfgLoadCount = 0;
            for (var i = 0; i < total; i++)
            {
                var loader = new ResourceItemLoader();
                loader.once(EventConst.BundleContentLoadComplete, (context) =>
                {
                    var data = (object[])context.data;
                    object asset = (object)data[0];
                    string assetName = (string)data[1];
                    var name = Path.GetFileNameWithoutExtension(assetName);
                    BaseConfig.DecodeCfg(name, asset);
                    _cfgLoadCount += 1;
                    EventUtil.dispatch(EventType.UpdateCfgProgress, new object[] { _cfgLoadCount, _cfgTotalCount, "配置资源加载中……" });
                    if (_cfgLoadCount >= _cfgTotalCount)
                    {
                        tcs.SetResult(1);
                    }
                });
                loader.LoadBundleContent(Path.Combine(preUri, "Configs/" + cfg.configs[i] + ".json"));
            }
            return task;

        }

        private Task<int> LoadOtherUI()
        {
            var tcs = new TaskCompletionSource<int>();
            Task<int> task = tcs.Task;

            //开始加载UI资源
            PreLoadConfig cfg = BaseConfig.GetConfig<PreLoadConfig>();
            _uiTotalCount = cfg.fuiItems.Count;
            _uiLoadCount = 0;
            for (var i = 0; i < _uiTotalCount; i++)
            {
                var loadingUri = cfg.fuiItems[i];
                var loader = new ResourceItemLoader();
                loader.once(EventConst.BundleLoadComplete, (context) =>
                {
                    var data = (object[])context.data;
                    AssetBundle assetsBundle = (AssetBundle)data[0];
                    if (assetsBundle != null)
                    {
                        UIPackage.AddPackage(assetsBundle);
                    }
                    _uiLoadCount++;
                    EventUtil.dispatch(EventType.UpdateCfgProgress, new object[] { _uiLoadCount, _uiTotalCount, "UI资源加载中……" });
                    if (_uiLoadCount >= _uiTotalCount)
                    {
                        tcs.SetResult(1);
                    }
                });
                loader.LoadBundleContent(Path.Combine(preUri, "UI/" + loadingUri + "_fui.bytes"));
            }
            return task;
        }
    }
}
