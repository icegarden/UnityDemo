
using FairyGUI;
using Loading;
using System.IO;
using UnityEngine;

namespace DemoILRuntime
{
    public class LoadingMediator : Mediator<UI_LoadingSkin>
    {
        protected override void InitView()
        {
            _layerId = LayerId.UI_TOPMENU;
            _view = UI_LoadingSkin.CreateInstance();
            _view.m_pb_loading.max = 1;
            _view.m_pb_loading.value = 0;
        }

        public void onUpDateProgress(EventContext context)
        {
            var data = (object[])context.data;
            double cur = (double)data[0];
            double total = (double)data[1];
            string desc = (string)data[2];
            _view.m_pb_loading.max = total;
            _view.m_pb_loading.value = cur;
            _view.m_txt_tips.text = desc + cur + "/" + total;
        }

        private void ShowBg()
        {
            ImageUtil.SetImgFromBundle(_view.m_bg, "Images/bg/T_Login_Bg.jpg");
        }

        protected override void onAwake()
        {
            base.onAwake();
            EventUtil.on(EventType.UpdateCfgProgress, onUpDateProgress);
            ShowBg();
        }

        protected override void onSleep()
        {
            base.onSleep();
            EventUtil.off(EventType.UpdateCfgProgress, onUpDateProgress);
        }


    }
}
