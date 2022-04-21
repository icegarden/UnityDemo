local GameObject = UnityEngine.GameObject;
local RectTransform = UnityEngine.RectTransform;
local CanvasRenderer = UnityEngine.CanvasRenderer;
LayerManager = {}
function LayerManager.ins()
    if (LayerManager.__ins == nil) then
        LayerManager.__ins = LayerManager:new();
    end
    return LayerManager.__ins;
end

function LayerManager:new()
    if (LayerManager.__ins ~= nil) then
        return LayerManager.__ins;
    end
    local o = {};
    setmetatable(o, self);
    self.__index = self;
    o.layerDic = {};
    return o;
end

function LayerManager:init()
    self:createLayer(LayerId.Root);
    self:createLayer(LayerId.Map_Container, LayerId.Root);
    self:createLayer(LayerId.UI_Root, LayerId.Root);
    self:createLayer(LayerId.Top, LayerId.Root);
    self:createLayer(LayerId.UI_Bottom, LayerId.UI_Root);
    self:createLayer(LayerId.UI_Middle, LayerId.UI_Root);
    self:createLayer(LayerId.UI_Top, LayerId.UI_Root);
    self:createLayer(LayerId.Alert, LayerId.UI_Root);
    self:createLayer(LayerId.Message, LayerId.UI_Root);

    local layer = self.layerDic[LayerId.Root];
    local camera = GameObject.Find("Main Camera");
    local canvas = camera:GetComponentInChildren(typeof(UnityEngine.Canvas));
    layer.transform:SetParent(canvas.transform);
    layer.transform.localPosition = Vector3(0,0,0);
end

function LayerManager:createLayer(id, ...)
    local arg = {...};
    local parentId = arg[1];
    local layer = GameObject.New(id);
    layer:AddComponent(typeof(RectTransform));
    layer:AddComponent(typeof(CanvasRenderer));
    if (parentId ~= nil) then
        local parent = self.layerDic[parentId];
        layer.transform:SetParent(parent.transform);
    end
    layer.transform.localPosition = Vector3(0,0,0);
    self.layerDic[id] = layer;
end

function LayerManager:addChild(child, layerId)
    local layer = self.layerDic[layerId];
    if (layer ~= nil) then
        child.transform:SetParent(layer.transform);
    end
end

function LayerManager:getLayer(id)
    return self.layerDic[id];
end

return LayerManager
