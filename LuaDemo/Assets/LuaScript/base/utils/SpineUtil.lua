SpineUtil = {}
-- 播放一次动画，播放完什么都不管
function SpineUtil.playAni(ske, aniname)

end

function SpineUtil.playAniOnce(ske, aniname)

end
-- 根据文件名播放一个动画，播完就销毁
function SpineUtil.playEffectOnce(filename)
    local uri = PathUtil.getEffectUri(filename);
    local ske = SpineFactory.createSkeleton(uri);
end
return SpineUtil;
