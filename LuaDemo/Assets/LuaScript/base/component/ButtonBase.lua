local Text = UnityEngine.UI.Text;
local EventTriggerType = UnityEngine.EventSystems.EventTriggerType;
ButtonBase = {}
function ButtonBase:new()
    local o = {};
    setmetatable(o, self);
    self.__index = self;
    return o;
end

function ButtonBase:setLabel(txt)
    self.label = txt;
    local view = self.view;
    if (view ~= nil) then
        local label = view.transform:Find("label").gameObject;
        if (label ~= nil) then
            local tf = label:GetComponent(typeof(Text));
            if (tf ~= nil) then
                tf.text = txt;
            end
        end
    end
end
function ButtonBase:getLabel()
    return self.label;
end

function ButtonBase:addClickListener(func,callThis)
    local view = self.view;
    if (view == nil) then
        return;
    end
    EventUtil.addListener(view,EventTriggerType.PointerClick,func,callThis)
end

function ButtonBase:removeClickListener(func,callThis)
    local view = self.view;
    if (view == nil) then
        return;
    end
    EventUtil.removeListener(view,EventTriggerType.PointerClick,func,callThis)
end
-- 绑定一个视图
function ButtonBase:bind(view)
    self.view = view;
    if (self.label ~= nil) then
        self.setLabel(self.label)
    end
end
-- 
function ButtonBase:unBind()
    self.view = nil;
end
return ButtonBase;
