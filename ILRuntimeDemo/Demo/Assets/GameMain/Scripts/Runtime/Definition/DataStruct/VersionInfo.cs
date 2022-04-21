public class VersionInfo
{
    /// <summary>
    /// 是否需要强制更新游戏应用
    /// </summary>
    public bool ForceUpdateGame;
   
    /// <summary>
    /// 最新的游戏版本号
    /// </summary>
    public string LatestGameVersion;
    

    /// <summary>
    /// 最新的游戏内部版本号
    /// </summary>
    public int InternalGameVersion;
    

    /// <summary>
    /// 最新的资源内部版本号
    /// </summary>
    public int InternalResourceVersion;
    
    /// <summary>
    /// 资源更新下载地址
    /// </summary>
    public string UpdatePrefixUri;
    
    /// <summary>
    /// 资源版本列表长度
    /// </summary>
    public int VersionListLength;
    
    /// <summary>
    /// 资源版本列表哈希值
    /// </summary>
    public int VersionListHashCode;
    

    /// <summary>
    /// 资源版本列表压缩后长度
    /// </summary>
    public int VersionListCompressedLength;
    

    public int VersionListCompressedHashCode;
    
}