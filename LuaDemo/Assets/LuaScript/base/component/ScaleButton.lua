local EventTriggerType = UnityEngine.EventSystems.EventTriggerType;
local Ease = DG.Tweening.Ease;
ScaleButton = ButtonBase:new();
function ScaleButton:new()
    local o = ButtonBase:new();
    setmetatable(o, self);
    self.__index = self;
    return o;
end

function ScaleButton:bind(view)
    self.view = view;
    self.tweenVal = 1;
    EventUtil.addListener(view, EventTriggerType.PointerDown, self.onPointerDown, self);
    EventUtil.addListener(view, EventTriggerType.PointerUp, self.onPointUp, self);
end
function ScaleButton:unBind()
    local view = self.view;
    self.view = nil;
    EventUtil.removeListener(view, EventTriggerType.PointerDown, self.onPointerDown, self);
    EventUtil.removeListener(view, EventTriggerType.PointerUp, self.onPointUp, self);
end

function ScaleButton:onPointerDown()
    self:killTween();
    TweenUtil.floatTo(self.tweenVal, 1.2, 0.1, self, self.onTweenUpdate, nil, Ease.Linear)
end

function ScaleButton:onTweenUpdate(val)
    self.tweenVal = val;
    local transform = self.view.transform;
    transform.localScale = Vector3(val, val, 1);
end
function ScaleButton:onPointUp()
    self:killTween();
    TweenUtil.floatTo(self.tweenVal, 1, 0.1, self, self.onTweenUpdate, nil, Ease.Linear)
end

function ScaleButton:killTween()
    local tween = self.tween;
    if (tween ~= nil) then
        tween:Kill();
    end
    self.tween = nil;
end
return ScaleButton
