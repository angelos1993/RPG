using System.Windows.Forms;

namespace RBG.Utility
{
    public static class MessageBoxUtility
    {
        public static void ShowErrorMsg(string msg)
        {
            MessageBox.Show(msg, @"خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign);
        }

        public static void ShowWarningMsg(string msg)
        {
            MessageBox.Show(msg, @"تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        public static void ShowInfoMsg(string msg)
        {
            MessageBox.Show(msg, @"تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        public static DialogResult ShowConfirmationDialog(string msg)
        {
            return MessageBox.Show(msg, @"تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }
    }
}