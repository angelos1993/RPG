namespace RBG.PL.Forms
{
    partial class FrmIndex
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
            this.pnlButtons = new DevComponents.DotNetBar.PanelEx();
            this.btnDatabase = new DevComponents.DotNetBar.ButtonX();
            this.btnAdmin = new DevComponents.DotNetBar.ButtonX();
            this.btnMaterial = new DevComponents.DotNetBar.ButtonX();
            this.btnClient = new DevComponents.DotNetBar.ButtonX();
            this.btnInvoice = new DevComponents.DotNetBar.ButtonX();
            this.btnAddInvoice = new DevComponents.DotNetBar.ButtonItem();
            this.btnAddMaterial = new DevComponents.DotNetBar.ButtonItem();
            this.btnListMaterials = new DevComponents.DotNetBar.ButtonItem();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.CanvasColor = System.Drawing.Color.Transparent;
            this.pnlButtons.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlButtons.Controls.Add(this.btnDatabase);
            this.pnlButtons.Controls.Add(this.btnAdmin);
            this.pnlButtons.Controls.Add(this.btnMaterial);
            this.pnlButtons.Controls.Add(this.btnClient);
            this.pnlButtons.Controls.Add(this.btnInvoice);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlButtons.RightToLeftLayout = true;
            this.pnlButtons.Size = new System.Drawing.Size(908, 100);
            this.pnlButtons.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlButtons.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlButtons.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlButtons.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlButtons.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlButtons.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlButtons.Style.GradientAngle = 90;
            this.pnlButtons.TabIndex = 0;
            // 
            // btnDatabase
            // 
            this.btnDatabase.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDatabase.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDatabase.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDatabase.Image = global::RBG.Properties.Resources.DB;
            this.btnDatabase.ImageFixedSize = new System.Drawing.Size(80, 70);
            this.btnDatabase.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDatabase.Location = new System.Drawing.Point(400, 0);
            this.btnDatabase.Name = "btnDatabase";
            this.btnDatabase.Size = new System.Drawing.Size(100, 100);
            this.btnDatabase.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDatabase.TabIndex = 4;
            this.btnDatabase.Text = "قاعدة البيانات";
            this.btnDatabase.Visible = false;
            // 
            // btnAdmin
            // 
            this.btnAdmin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdmin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdmin.Image = global::RBG.Properties.Resources.Admin;
            this.btnAdmin.ImageFixedSize = new System.Drawing.Size(80, 70);
            this.btnAdmin.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAdmin.Location = new System.Drawing.Point(300, 0);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(100, 100);
            this.btnAdmin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "المستخدمين";
            // 
            // btnMaterial
            // 
            this.btnMaterial.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMaterial.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnMaterial.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMaterial.Image = global::RBG.Properties.Resources.Materials;
            this.btnMaterial.ImageFixedSize = new System.Drawing.Size(80, 70);
            this.btnMaterial.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnMaterial.Location = new System.Drawing.Point(200, 0);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(100, 100);
            this.btnMaterial.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnMaterial.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAddMaterial,
            this.btnListMaterials});
            this.btnMaterial.TabIndex = 2;
            this.btnMaterial.Text = "الخامات / المواد";
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // btnClient
            // 
            this.btnClient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClient.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClient.Image = global::RBG.Properties.Resources.Clients;
            this.btnClient.ImageFixedSize = new System.Drawing.Size(80, 70);
            this.btnClient.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnClient.Location = new System.Drawing.Point(100, 0);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(100, 100);
            this.btnClient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "العملاء";
            // 
            // btnInvoice
            // 
            this.btnInvoice.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInvoice.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInvoice.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInvoice.Image = global::RBG.Properties.Resources.Invoice;
            this.btnInvoice.ImageFixedSize = new System.Drawing.Size(70, 70);
            this.btnInvoice.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnInvoice.Location = new System.Drawing.Point(0, 0);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(100, 100);
            this.btnInvoice.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInvoice.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAddInvoice});
            this.btnInvoice.TabIndex = 0;
            this.btnInvoice.Text = "الفواتير";
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.GlobalItem = false;
            this.btnAddInvoice.Image = global::RBG.Properties.Resources.Add;
            this.btnAddInvoice.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Text = "إضافة فاتورة جديدة ...";
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.GlobalItem = false;
            this.btnAddMaterial.Image = global::RBG.Properties.Resources.Add;
            this.btnAddMaterial.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Text = "إضافة خامة / مادة جديدة ...";
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // btnListMaterials
            // 
            this.btnListMaterials.GlobalItem = false;
            this.btnListMaterials.Name = "btnListMaterials";
            this.btnListMaterials.Text = "عرض كل المواد / الخامات ...";
            this.btnListMaterials.Click += new System.EventHandler(this.btnListMaterials_Click);
            // 
            // FrmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 488);
            this.Controls.Add(this.pnlButtons);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIndex";
            this.Text = "RBG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIndex_FormClosing);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnlButtons;
        private DevComponents.DotNetBar.ButtonX btnInvoice;
        private DevComponents.DotNetBar.ButtonX btnClient;
        private DevComponents.DotNetBar.ButtonX btnDatabase;
        private DevComponents.DotNetBar.ButtonX btnAdmin;
        private DevComponents.DotNetBar.ButtonX btnMaterial;
        private DevComponents.DotNetBar.ButtonItem btnAddInvoice;
        private DevComponents.DotNetBar.ButtonItem btnAddMaterial;
        private DevComponents.DotNetBar.ButtonItem btnListMaterials;
    }
}