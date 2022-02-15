
namespace Accounting.Forms
{
    partial class frmBarcode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBarcode));
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBarcode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BtnCreate = new DevComponents.DotNetBar.ButtonX();
            this.BtnSave = new DevComponents.DotNetBar.ButtonX();
            this.BarcodeCtrl = new Accounting.Tools.BarCodeCtrl();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.ribbonControl1.Size = new System.Drawing.Size(584, 288);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl1.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl1.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl1.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "ساخت بارکد";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "کد";
            // 
            // TxtBarcode
            // 
            this.TxtBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TxtBarcode.Border.Class = "TextBoxBorder";
            this.TxtBarcode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtBarcode.Location = new System.Drawing.Point(265, 175);
            this.TxtBarcode.Name = "TxtBarcode";
            this.TxtBarcode.PreventEnterBeep = true;
            this.TxtBarcode.Size = new System.Drawing.Size(221, 28);
            this.TxtBarcode.TabIndex = 3;
            // 
            // BtnCreate
            // 
            this.BtnCreate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCreate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnCreate.Location = new System.Drawing.Point(400, 209);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5);
            this.BtnCreate.Size = new System.Drawing.Size(86, 28);
            this.BtnCreate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnCreate.TabIndex = 4;
            this.BtnCreate.Text = "ایجاد بارکد";
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click_1);
            // 
            // BtnSave
            // 
            this.BtnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtnSave.Location = new System.Drawing.Point(308, 209);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5);
            this.BtnSave.Size = new System.Drawing.Size(86, 28);
            this.BtnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "ذخیره";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click_1);
            // 
            // BarcodeCtrl
            // 
            this.BarcodeCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BarcodeCtrl.BarCode = "1234567890";
            this.BarcodeCtrl.BarCodeHeight = 50;
            this.BarcodeCtrl.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.BarcodeCtrl.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BarcodeCtrl.HeaderText = "BarCode Demo";
            this.BarcodeCtrl.LeftMargin = 10;
            this.BarcodeCtrl.Location = new System.Drawing.Point(81, 47);
            this.BarcodeCtrl.Name = "BarcodeCtrl";
            this.BarcodeCtrl.ShowFooter = true;
            this.BarcodeCtrl.ShowHeader = false;
            this.BarcodeCtrl.Size = new System.Drawing.Size(428, 109);
            this.BarcodeCtrl.TabIndex = 1;
            this.BarcodeCtrl.TopMargin = 10;
            this.BarcodeCtrl.VertAlign = Accounting.Tools.BarCodeCtrl.AlignType.Center;
            this.BarcodeCtrl.Weight = Accounting.Tools.BarCodeCtrl.BarCodeWeight.Small;
            // 
            // frmBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 288);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.TxtBarcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarcodeCtrl);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBarcode";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ساخت بارکد";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private Tools.BarCodeCtrl BarcodeCtrl;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtBarcode;
        private DevComponents.DotNetBar.ButtonX BtnCreate;
        private DevComponents.DotNetBar.ButtonX BtnSave;
    }
}