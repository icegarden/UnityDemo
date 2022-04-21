local Resources = UnityEngine.Resources;
local UObject = UnityEngine.Object;
Mediator = {}
function Mediator:new()
    local o = {};
    setmetatable(o, self);
    self.__index = self;
    return o;
end
function Mediator:onInit()

end
function Mediator:createView()
    local url = "Prefabs/ui/" .. self.moduleId;
    local obj = Resources.Load(url);
    local node = UObject.Instantiate(obj);
    self._view = node;
end

function Mediator:show()
    local view = self._view;
    LayerManager.ins():addChild(view,LayerId.UI_Top);
    view.transform.localPosition = Vector3(0, 0, 0);
    self:onAwake();
end
function Mediator:hide()
    local view = self._view;
    view.transform:SetParent(nil);
    self:onSleep();
end

function Mediator:onAwake()

end
function Mediator:onSleep()

end
return Mediator;
