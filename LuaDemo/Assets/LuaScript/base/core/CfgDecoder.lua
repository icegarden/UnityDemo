local Resources = UnityEngine.Resources;
local TextAsset = UnityEngine.TextAsset
local cjson = require("cjson");
CfgDecoder = {}
function CfgDecoder.decodeCfgs()

    local data = Resources.LoadAll("Cfgs/", typeof(TextAsset));
    local len = data.Length;
    local endInx = len - 1;
    for i = 1, endInx, 1 do
        local subData = data[i];
        local decoder = cjson.new();
        local tmp = decoder.decode(subData.text);
        local clskey = subData.name .. "Cfg"
        local rawcls = _G[clskey];
        if (rawcls ~= nil) then
            rawcls.decode(tmp);
        end
    end

end
return CfgDecoder;
