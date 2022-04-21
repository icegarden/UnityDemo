local SkeletonDataAsset = Spine.Unity.SkeletonDataAsset
local Resources = UnityEngine.Resources;

SpineTemplete = {}

function SpineTemplete:new()
    local o = {};
    setmetatable(o, self);
    self.__index = self;
    o.refrence = 0;
    return o;
end
function SpineTemplete:init(uri)
    self.uri = uri;
    self.dataAssets = Resources.Load(self.uri, typeof(SkeletonDataAsset))
end

function SpineTemplete:addRefrence()
    self.refrence = self.refrence + 1;
end
function SpineTemplete:reduceRefrence()
    self.refrence = self.refrence - 1;
end

function SpineTemplete:buildArmature()
    self:addRefrence();
    local ske = ObjectPool.get(Skeleton, "Skeleton");
    ske:setMouseEnable(false);
    -- local ske = Skeleton:new();
    ske:init(self);
    return ske;
end

function SpineTemplete:destroy()
    self.dataAssets = nil;
    self.refrence = 0;
    ObjectPool.recycle(self);
end
return SpineTemplete;
