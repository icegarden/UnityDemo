local ArrayList = System.Collections.ArrayList
ObjectPool = {
    poolDic = {}
}
-- 走对象池的实例需要实现onReuse和onRecycle方法
function ObjectPool.get(cls, clsName)
    cls.__className = clsName;
    local key = clsName;
    local arr = ObjectPool.poolDic[key];
    if (arr == nil) then
        arr = ArrayList.New();
        ObjectPool.poolDic[key] = arr;
    end
    local count = arr.Count;
    if (count >= 1) then
        local ins = arr[0];
        arr:RemoveAt(0);
        if (ins.onReuse ~= nil) then
            ins:onReuse();
        end
        return ins;
    else
        local ins;
        if (cls.new) then
            ins = cls:new();
        else
            if (cls.New) then
                ins = cls.New();
            end
        end
        if (ins ~= nil) then
            if (ins.onReuse ~= nil) then
                ins:onReuse();
            end
        end
        return ins;
    end
end
function ObjectPool.recycle(ins)
    local clsName = ins.__className;
    if (clsName ~= nil) then
        local arr = ObjectPool.poolDic[clsName];
        if (arr == nil) then
            arr = ArrayList.New();
            ObjectPool.poolDic[clsName] = arr;
        end
        if (ins.onRecycle ~= nil) then
            ins:onRecycle();
        end
        arr:Add(ins);
    end
end

return ObjectPool;
