local DOTween = DG.Tweening.DOTween
local DOGetterInt = DG.Tweening.Core.DOGetter_int;
local DOSetterInt = DG.Tweening.Core.DOSetter_int;
local DOGetterFloat = DG.Tweening.Core.DOGetter_float;
local DOSetterFloat = DG.Tweening.Core.DOSetter_float;
local Ease = DG.Tweening.Ease;

TweenUtil = {};

function TweenUtil.intTo(startval, endval, duration, callthis, updatecall, completecallback, easy)
    local obj = {};
    easy = easy or Ease.Linear;
    obj.value = startval;
    local setfunc = TweenUtil.crateSetter(obj, updatecall, callthis);
    local getfunc = TweenUtil.createGetter(obj);
    local getter = DOGetterInt(getfunc);
    local setter = DOSetterInt(setfunc);
    local tween = DOTween.To(getter, setter, endval, duration);
    -- 不要用c#的链式写法，wrap那边不支持，那边需要2个参数，首个参数需要是tween的实例
    tween.SetEase(tween, easy);
    tween.OnComplete(tween, TweenUtil.createCompleteCallBack(completecallback, callthis))
    return tween;
end

function TweenUtil.floatTo(startval, endval, duration, callthis, updatecall, completecallback, easy)
    local obj = {};
    easy = easy or Ease.Linear;
    obj.value = startval;
    local setfunc = TweenUtil.crateSetter(obj, updatecall, callthis);
    local getfunc = TweenUtil.createGetter(obj);
    local getter = DOGetterFloat(getfunc);
    local setter = DOSetterFloat(setfunc);
    local tween = DOTween.To(getter, setter, endval, duration);
    tween.SetEase(tween, easy);
    tween.OnComplete(tween, TweenUtil.createCompleteCallBack(completecallback, callthis));
    return tween;
end

function TweenUtil.createGetter(obj)
    local func = function()
        return obj.value;
    end
    return func;
end

function TweenUtil.crateSetter(obj, updatecall, callthis)
    local func = function(val)
        obj.value = val;
        if (updatecall ~= nil) then
            if (callthis ~= nil) then
                updatecall(callthis, val);
            else
                updatecall(val);
            end

        end
    end
    return func;
end

function TweenUtil.createCompleteCallBack(callback, callthis)
    local func = function()
        if (callback ~= nil) then
            callback(callthis);
        end
    end
    return func;
end

return TweenUtil;
