local GameObject = UnityEngine.GameObject
local SkeletonGraphic = Spine.Unity.SkeletonGraphic
local function createSkeleton(ske)
    local templete = ske.templete;
    local dataAssets = templete.dataAssets;
    local obj = GameObject.New();
    local instance = SkeletonGraphic.AddSkeletonGraphicComponent(obj, dataAssets, nil);
    ske.instance = instance;
    ske.gameObj = obj;
end

local function addListener(ske)
    local instance = ske.instance;
    local state = instance.AnimationState;
    local function createListener(func, callthis)
        function callBack(entry)
            func(callthis, entry)
        end
        return callBack
    end
    local completeCall = ske.completeCall;
    if (completeCall == nil) then
        completeCall = createListener(ske.onComplete, ske);
        ske.completeCall = completeCall;
        state.Complete = state.Complete + completeCall;
    end
end

local function removeListener(ske)
    local instance = ske.instance;
    local state = instance.AnimationState;
    local completeCall = ske.completeCall;
    if (completeCall ~= nil) then
        ske.completeCall = nil;
        state.Complete = state.Complete - completeCall;
    end
end

Skeleton = EventDispatcher:new();
function Skeleton:new()
    local o = EventDispatcher:new();
    setmetatable(o, self);
    self.__index = self;
    return o;
end
function Skeleton:init(templete)
    self.templete = templete;
    createSkeleton(self);
end
function Skeleton:setMouseEnable(enable)
    enable = enable or false;
    self.mouseEnable = enable;
    if (self.instance ~= nil) then
        self.instance.raycastTarget = enable;
    end
end
function Skeleton:addTo(parent, x, y)
    self.instance.gameObject.transform:SetParent(parent.transform);
    x = x or 0;
    y = y or 0;
    self.instance.gameObject.transform.localPosition = Vector3(x, y, 0);
    if (self.mouseEnable == nil) then
        self:setMouseEnable(true);
    else
        self:setMouseEnable(self.mouseEnable);
    end
end

function Skeleton:addToLayer(id, x, y)
    local parent = LayerManager.ins():getLayer(id);
    self:addTo(parent, x, y);
end
-- 根据索引播放动画
function Skeleton:playAniByIndex(inx, loop)
    local skedata = self.templete.dataAssets:GetSkeletonData(false);
    if (skedata == nil) then
        return
    end
    local animations = skedata.Animations;
    if (animations == nil) then
        return;
    end
    local count = animations.Count;
    if (inx <= count - 1) then
        local ani = animations.Items[inx];
        if (ani ~= nil) then
            self:playAniByName(ani.Name, loop);
        end
    end
end
-- 根据动画名来播放动画
function Skeleton:playAniByName(name, loop)
    local dataAssets = self.templete.dataAssets;
    local ani = dataAssets:GetSkeletonData(false):FindAnimation(name);
    if (ani ~= nil) then
        self.instance.AnimationState:SetAnimation(0, ani, loop);
    end
    -- 狗b，如果添加了complete回调，不管是不是loop，都只播放一次
    -- 所以监听事件在非loop的时候添加
    -- 其他帧事件，可以加在初始化的时候
    if (loop == true) then
        removeListener(self)
    else
        addListener(self);
    end
end

function Skeleton:onComplete(entry)
    self:dispatch(EventType.SkeAniComplete);
end
function Skeleton:onRecycle()
    self.mouseEnable = nil;
end
function Skeleton:destroy()
    local templete = self.templete;
    if (templete == nil) then
        return;
    end
    templete:reduceRefrence();
    self:offAll();
    self.templete = nil;
    self.instance.gameObject.transform:SetParent(nil)
    local state = self.instance.AnimationState;
    state.Complete = state.Complete - self.completeCall;
    self.completeCall = nil;
    self.instance = nil;
    local obj = self.gameObj;
    self.gameObj = nil;
    GameObject.Destroy(obj);
    ObjectPool.recycle(self);
end
return Skeleton;
