using System.Windows.Forms;

namespace Accounting.Tools
{
    public class Messages
    {
        public static DialogResult Success()
        {
            return MessageBox.Show("عملیات با موفقیت انجام شد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult Exit()
        {
            return MessageBox.Show("آیا میخواهید خارج شوید؟", "پیغام", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        public static DialogResult DateNotValid()
        {
            return MessageBox.Show("تاریخ وارد شده معتبر نمیباشد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Failed()
        {
            return MessageBox.Show("در انجام عملیات خطایی رخ داد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Question()
        {
            return MessageBox.Show("آیا از انجام عملیات اطمینان دارید؟", "پیغام", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        public static DialogResult EnterDate()
        {
            return MessageBox.Show("لطفا تاریخ را وارد کنید", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
