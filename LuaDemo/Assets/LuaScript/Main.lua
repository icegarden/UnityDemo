local RectTransformUtility = UnityEngine.RectTransformUtility
local Input = UnityEngine.Input;
function start()
    TimeUtil.init();
    CfgDecoder.decodeCfgs();
    LayerManager.ins():init();
    RegistMediator.regist();
    RegistService.regist();
    ModuleManager.ins():openModule(ModuleId.Login);
    TimeUtil.addFrameListener(onWaitStageClick);
end

function onStageClick(e)
    local layer = LayerManager.ins():getLayer(LayerId.Root);
    local bool, out = RectTransformUtility.ScreenPointToLocalPointInRectangle(
                          layer.transform, e.position, nil, nil);
    local uri = PathUtil.getSkeEffectUri("dianji");
    local ske = SpineFactory.createSkeleton(uri);
    ske:addToLayer(LayerId.Top, out.x, out.y);
    function onComplete() ske:destroy(); end
    ske:once(EventType.SkeAniComplete, onComplete)
    ske:playAniByIndex(0, false);
end

function onWaitStageClick()
    local bool = Input.GetMouseButtonDown(0);
    if (bool == true) then
        local pos = {};
        pos.position = Input.mousePosition;
        onStageClick(pos)
    end
end
-- 场景切换通知
function OnLevelWasLoaded(level)
    collectgarbage("collect")
    Time.timeSinceLevelLoad = 0
end

function OnApplicationQuit() end
start();
