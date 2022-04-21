using FairyGUI;
using Login;
namespace DemoILRuntime
{
    public class LoginMediator : Mediator<UI_LoginSkin>
    {

        protected override void InitView()
        {
            _layerId = LayerId.UI_UP_MENU;
            _view = UI_LoginSkin.CreateInstance();
        }

        private void OnStartClick()
        {
           
        }


        protected override void onAwake()
        {
            base.onAwake();
            _view.m_btn_start.onClick.Add(OnStartClick);
            ImageUtil.SetImgFromBundle(_view.m_bg, "Images/bg/T_Login_Bg.jpg");
        }
    }
}
