SpineFactory = {
    templeteDic = {}
}

function SpineFactory.createSkeleton(uri)
    local dic = SpineFactory.templeteDic;
    local templete = dic[uri];
    if (templete == nil) then
        templete = ObjectPool.get(SpineTemplete, "SpineTemplete");
        templete:init(uri);
        dic[uri] = templete;
    end
    local ske = templete:buildArmature();
    return ske;
end
return SpineFactory;
