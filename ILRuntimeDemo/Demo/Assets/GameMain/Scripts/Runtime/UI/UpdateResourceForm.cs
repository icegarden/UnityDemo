using UnityEngine;
using UnityEngine.UI;
public class UpdateResourceForm : MonoBehaviour
{
    [SerializeField]
    private Text m_DescriptionText = null;

    [SerializeField]
    private Slider m_ProgressSlider = null;


    public void SetDesc(string desc)
    {
        m_DescriptionText.text = desc;
    }
    public void SetProgress(float progress, string description)
    {
        m_ProgressSlider.value = progress;
        m_DescriptionText.text = description;
    }
}