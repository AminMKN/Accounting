using System;
using System.Windows.Forms;

namespace Accounting.Forms
{
    public partial class frmBarcode : Form
    {
        public frmBarcode()
        {
            InitializeComponent();
        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            var name = Guid.NewGuid().ToString().Replace("-", "") + ".jpg";
            var folder = new FolderBrowserDialog();
            folder.ShowDialog();
            BarcodeCtrl.SaveImage(folder.SelectedPath + @"\" + name);
        }

        private void BtnCreate_Click_1(object sender, EventArgs e)
        {
            BarcodeCtrl.BarCode = TxtBarcode.Text;
        }
    }
}
