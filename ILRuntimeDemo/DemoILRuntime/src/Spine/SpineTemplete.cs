using FairyGUI;
using Spine.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoILRuntime
{
    public class SpineTemplete : IRecycle
    {
        private int _refrenceCount;
        private SkeletonDataAsset _dataAsset;
        public delegate void SkeletonCreateCall(SpineSkeleton ske);
        private SkeletonCreateCall _createCallBack;
        public void Init(string uri)
        {
            _refrenceCount = 0;
            var loader = new ResourceItemLoader();
            loader.once(EventConst.BundleContentLoadComplete, onDataAssetComplete);
            loader.once(EventConst.BundleContentLoadFailed, onDataAssetFailed);
            loader.LoadBundleContent(uri);
        }

        public void CreateSkeleton(SkeletonCreateCall callback)
        {
            _createCallBack = callback;
            CheckCreate();
        }

        private void CheckCreate()
        {
            if (_dataAsset != null)
            {
                _refrenceCount++;
                var ske = ObjectPool.Get<SpineSkeleton>();
                ske.Init(this);
                _createCallBack(ske);
                _createCallBack = null;
            }
        }

        private void onDataAssetComplete(EventContext context)
        {

            if (_createCallBack != null)
            {
                var data = (object[])context.data;
                _dataAsset = (SkeletonDataAsset)data[0];
                //string assetName = (string)data[1];
                CheckCreate();
            }
        }

        private void onDataAssetFailed(EventContext context)
        {
            var data = (object[])context.data;
            string assetName = (string)data[0];
            string errorMessage = (string)data[1];
            if (_createCallBack != null)
            {
                _createCallBack(null);
            }
            _createCallBack = null;
        }

        public void OnRecycle()
        {
            _dataAsset = null;
            _createCallBack = null;
        }

        public void OnReuse()
        {

        }

        public void RemoveRefrence()
        {
            _refrenceCount--;
        }

        public int RefrenceCount
        {
            get { return _refrenceCount; }
        }

        public SkeletonDataAsset SkeletonDataAsset
        {
            get { return _dataAsset; }
        }
    }
}
