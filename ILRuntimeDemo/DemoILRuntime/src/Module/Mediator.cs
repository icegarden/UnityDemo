using FairyGUI;

namespace DemoILRuntime
{
    public abstract class Mediator<T> where T : GComponent
    {
        protected T _view;
        protected LayerId _layerId;
        protected float _maskAlpha = 0.7f;
        protected bool _ani = false;
        protected bool _inited = false;

        public Mediator()
        {

        }

        protected virtual void onAwake()
        {

        }

        protected virtual void onSleep()
        {

        }

        protected abstract void InitView();
        

        public void awake()
        {
            if (_view == null)
            {
                InitView();
              // _view = (T)UIPackage.CreateObject(_packageName, _skinName);
               // var obj = new UnityEngine.GameObject();
               // var panel =  obj.AddComponent<UIPanel>();
               // panel.packageName = _packageName;
               // panel.componentName = _skinName;
               // panel.CreateUI();
            }
            if (_view != null)
            {
                LayerManager.addChild(_view, _layerId);
                onAwake();
            }
        }

        public void sleep()
        {
            if(_view != null)
            {
                LayerManager.removeChild(_view);
                onSleep();
            }
        }
    }
}
