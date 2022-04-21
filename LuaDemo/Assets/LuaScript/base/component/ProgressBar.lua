local RectTransform = UnityEngine.RectTransform
ProgressBar = {}

function ProgressBar:new()
    local o = {};
    setmetatable(o, self);
    self.__index = self;
    return o;
end
-- 绑定一个视图组件
function ProgressBar:bind(view)
    self.img_bar = view.transform:Find("img_bar").gameObject;
    self.img_bg = view.transform:Find("img_bg").gameObject;
    self.tf_progress = view.transform:Find("tf_progress").gameObject;
end
-- 释放视图组件
function ProgressBar:unBind()
    self.tf_progress = nil;
    self.img_bar = nil;
    self.img_bg = nil;
end
-- style为1表示用a/b形式，否则用10%这种形式
function ProgressBar:setBase(min, max, style, preText)
    self.minValue = min;
    self.maxValue = max;
    self.style = style;
    self.preText = preText;
end

function ProgressBar:setValue(val)
    if (val < self.minValue) then
        val = self.minValue;
    end
    if (val > self.maxValue) then
        val = self.maxValue
    end
    local txt = self.preText;
    if (self.style == 1) then
        txt = txt .. (val / self.maxValue);
    else
        txt = txt .. (math.floor(val / self.maxValue * 100)) .. "%";
    end
    local tf = self.tf_progress:GetComponent(typeof(UnityEngine.UI.Text))
    tf.text = txt;

    self.img_bar.transform:SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, val)
end
return ProgressBar
