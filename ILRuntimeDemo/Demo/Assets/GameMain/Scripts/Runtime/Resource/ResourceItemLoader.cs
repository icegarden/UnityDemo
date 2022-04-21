using GameFramework.Resource;
using UnityGameFramework.Runtime;
using UnityEngine;
using FairyGUI;
public class ResourceItemLoader : EventDispatcher
{
    private string _loadUri;
    public void LoadBundleContent(string uri)
    {
        _loadUri = uri;
        EventUtil.on(EventConst.BundleLoadComplete, OnLoadAssetsBundleComplete);
        Game.Resource.LoadAsset(uri, new LoadAssetCallbacks(OnLoadBundleContentSuccess, OnLoadBundleContentFail));
    }

    private void OnLoadAssetsBundleComplete(EventContext context)
    {
        var  data = (object[])context.data;
        var assetsBundle = (AssetBundle)data[0];
        if (assetsBundle.Contains(_loadUri))
        {
            EventUtil.off(EventConst.BundleLoadComplete, OnLoadAssetsBundleComplete);
            DispatchEvent(EventConst.BundleLoadComplete, new object[] { assetsBundle });
        }

    }


    private void OnLoadBundleContentSuccess(string assetName, object asset, float duration, object userData)
    {
        DispatchEvent(EventConst.BundleContentLoadComplete, new object[] { asset, assetName });

    }

    private void OnLoadBundleContentFail(string assetName, LoadResourceStatus status, string errorMessage, object userData)
    {
        EventUtil.off(EventConst.BundleLoadComplete, OnLoadAssetsBundleComplete);
        DispatchEvent(EventConst.BundleContentLoadFailed, new object[] { assetName, errorMessage });
        Log.Info("'{0}' load faied ,caused by: '{1}'", assetName, errorMessage);
    }

    public void on(string type, EventCallback0 callback,  bool isOnce = false)
    {
        if (isOnce)
        {
            EventCallback0 tmp = null;
            tmp = () => {
                callback();
                RemoveEventListener(type, tmp);
            };
            AddEventListener(type, tmp);
        }
        else
        {
            AddEventListener(type, callback);
        }
        
    }


    public void on(string type, EventCallback1 callback, bool isOnce = false)
    {
        if (isOnce)
        {
            EventCallback1 tmp = null;
            tmp = (EventContext context) => { 
                callback(context);
                RemoveEventListener(type, tmp);
            };
            AddEventListener(type, tmp);
        }
        else
        {
            AddEventListener(type, callback);
        }
        
    }

    public  void once(string type, EventCallback0 callback)
    {
        on(type, callback, true);
    }

    public  void once(string type, EventCallback1 callback)
    {
        on(type, callback, true);
    }

    public  void off(string type, EventCallback0 callback)
    {
        RemoveEventListener(type, callback);
    }

    public  void off(string type, EventCallback1 callback)
    {
        RemoveEventListener(type, callback);
    }

    public  void dispatch(string type, object[] data = null)
    {
        DispatchEvent(type, data);
    }
    
}