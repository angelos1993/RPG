using System.Windows.Forms;
namespace RBG.Utility
{
    public static class MessageBoxUtility
    {
        public static void ShowErrorMsg(string msg)
        {
            MessageBox.Show(msg, @"خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowWarningMsg(string msg)
        {
            MessageBox.Show(msg, @"تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowInfoMsg(string msg)
        {
            MessageBox.Show(msg, @"تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowConfirmationDialog(string msg)
        {
            return MessageBox.Show(msg, @"تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}