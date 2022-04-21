using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairyGUI;
using Spine;
using Spine.Unity;
using UnityEngine;

namespace DemoILRuntime
{
    public class SpineSkeleton : IRecycle
    {
        private SpineTemplete _templete;
        private GLoader3D _loader;
        private SkeletonAnimation _animation;
        public delegate void OnPlayCompleteCall();

        public OnPlayCompleteCall completeCall;
        public void Init(SpineTemplete templete)
        {
            _templete = templete;
            _loader = ObjectPool.Get<GLoader3D>();
            _loader.asLoader3D.SetSpine(_templete.SkeletonDataAsset, 0, 0, Vector2.zero);
            _animation = _loader.asLoader3D.spineAnimation;
        }

        public void Play(string aniName,bool loop)
        {
            if (aniName == null || aniName.Equals(""))
            {
                return;
            }
            _animation.AnimationState.SetAnimation(0,aniName,loop);
            if (loop)
            {
                //如果添加了complete回调，不管是不是loop，都只播放一次
                //所以如果要loop播放，先把事件移除掉
                _animation.AnimationState.Complete -= OnPlayComplete;
            }
            else
            {
                _animation.AnimationState.Complete += OnPlayComplete;
            }
            
        }

        private void OnPlayComplete(TrackEntry entry)
        {
            _animation.AnimationState.Complete -= OnPlayComplete;
            if(completeCall != null)
            {
                completeCall();
            }
        }
        public void OnRecycle()
        {
            if(_templete != null)
            {
                _templete.RemoveRefrence();
                _templete = null;
            }
            if(_animation != null)
            {
                GameObject.Destroy(_animation.gameObject);
                _animation = null;
            }
            if(_loader != null)
            {
                ObjectPool.Recycle(_loader);
                _loader = null;
            }
            
        }

        public void OnReuse()
        {

        }

        public void Destroy()
        {
            if( _loader != null)
            {
                _loader.RemoveFromParent();
            }
            ObjectPool.Recycle(this);
        }

        public GLoader3D disPlayObject
        {
            private set
            {
                _loader = value;
            }
            get
            {
                return _loader;
            }
        }
    }
}
