using UnityGameFramework.Runtime;
public static class UIExtension
{
    public static void OpenDialog(this UIComponent uiComponent, DialogParams dialogParams)
    {
        if (((ProcedureBase2)Game.Procedure.CurrentProcedure).UseNativeDialog)
        {
            OpenNativeDialog(dialogParams);
        }
        else
        {

        }
    }

    private static void OpenNativeDialog(DialogParams dialogParams)
    {
        // TODO：这里应该弹出原生对话框，先简化实现为直接按确认按钮
        if (dialogParams.OnClickConfirm != null)
        {
            dialogParams.OnClickConfirm(dialogParams.UserData);
        }
    }
}