using UnityEditor;

namespace ET
{
    public static class ToolsEditor
    {

        
        [MenuItem("Tools/Proto2CS")]
        public static void Proto2CS()
        {
            InnerProto2CS.Proto2CS();
            UnityEngine.Debug.Log("proto2cs succeed!");
        }
    }
}