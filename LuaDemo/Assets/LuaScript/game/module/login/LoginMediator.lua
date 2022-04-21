local RawImage = UnityEngine.UI.RawImage
local Texture2D = UnityEngine.Texture2D;
local Resources = UnityEngine.Resources;
local Sprite = UnityEngine.Sprite;
local Rect = UnityEngine.Rect;
local pb = require("pb");

LoginMediator = Mediator:new();

function LoginMediator:new()
    local o = Mediator:new();
    setmetatable(o, self);
    self.__index = self;
    return o;
end

function LoginMediator:onInit()
    local view = self._view;
    local img_bg = view.transform:Find("img_bg").gameObject;
    local btn_login = view.transform:Find("btn_login").gameObject;
    local scbtn = ScaleButton:new();
    scbtn:bind(btn_login);
    scbtn:setLabel("点击测试");
    self.img_bg = img_bg;
    self.btn_login = scbtn;
end

function LoginMediator:onUpdateTween(val)
    local progress = self.progress;
    progress:setValue(val);
end

function LoginMediator:onTweenComplete()
    dispatch(EventType.LoginComplete, "haha")
end

function LoginMediator:onLoginBtnClick()
    once(EventType.SocketConnect, self.onSocketConnet, self);
    NetService.connect("ws://120.26.61.250:9994");
end

function LoginMediator:onSocketConnet()
    Debug.log("准备发送数据")
    local ser = getService(LoginService);
    local info = {
        puid = "aabc12",
    }
    ser:getUserInfo(info);
end

function LoginMediator:onAwake()
    self.progress = ProgressBar:new();
    self.progress:bind(self._view.transform:Find("progress").gameObject);
    self.progress:setBase(0, 602, 0, "资源加载中……")
    self.progress:setValue(0);
    TweenUtil.intTo(0, 602, 5, self, self.onUpdateTween, self.onTweenComplete);
    local texture = Resources.Load("Images/T_Login_Bg", typeof(Texture2D));
    -- local sprite = Sprite.Create(texture, Rect(0, 0, texture.width, texture.height), Vector2(0.5,0.5));
    local rawImg = self.img_bg:GetComponent(typeof(RawImage));
    rawImg.texture = texture;
    self.btn_login:addClickListener(self.onLoginBtnClick, self);
end
function LoginMediator:onSleep()
    self.progress:unBind();
    self.progress = nil;
    self.btn_login:removeClickListener(self.onLoginBtnClick, self);
end
return LoginMediator
