using UnityEngine;

public partial class Game : MonoBehaviour
{
    public static UpdateResourceForm m_UpdateResourceForm = null;
    private void Start()
    {
        InitBuiltinComponents();
        InitCustomComponents();
        m_UpdateResourceForm = UnityEngine.Object.Instantiate(Game.BuiltinData.UpdateResourceFormTemplate);
        m_UpdateResourceForm.SetDesc("开始检测检测资源……");
    }

    
}
