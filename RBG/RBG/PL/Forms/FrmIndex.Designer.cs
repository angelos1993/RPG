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
            this.pnlInvoices = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnPayInvoice = new DevComponents.DotNetBar.ButtonX();
            this.btnListInvoices = new DevComponents.DotNetBar.ButtonX();
            this.btnAddInvoice = new DevComponents.DotNetBar.ButtonX();
            this.picInvoices = new System.Windows.Forms.PictureBox();
            this.pnlMaterials = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnAddMaterialQuantity = new DevComponents.DotNetBar.ButtonX();
            this.btnListMaterials = new DevComponents.DotNetBar.ButtonX();
            this.btnAddMaterial = new DevComponents.DotNetBar.ButtonX();
            this.picMaterials = new System.Windows.Forms.PictureBox();
            this.pnlClients = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnListClients = new DevComponents.DotNetBar.ButtonX();
            this.btnAddClient = new DevComponents.DotNetBar.ButtonX();
            this.picClients = new System.Windows.Forms.PictureBox();
            this.pnlAdmins = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnEditAdmin = new DevComponents.DotNetBar.ButtonX();
            this.picAdmins = new System.Windows.Forms.PictureBox();
            this.pnlDB = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.picDB = new System.Windows.Forms.PictureBox();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.pnlInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInvoices)).BeginInit();
            this.pnlMaterials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMaterials)).BeginInit();
            this.pnlClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClients)).BeginInit();
            this.pnlAdmins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmins)).BeginInit();
            this.pnlDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDB)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInvoices
            // 
            this.pnlInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInvoices.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlInvoices.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlInvoices.Controls.Add(this.btnPayInvoice);
            this.pnlInvoices.Controls.Add(this.btnListInvoices);
            this.pnlInvoices.Controls.Add(this.btnAddInvoice);
            this.pnlInvoices.Controls.Add(this.picInvoices);
            this.pnlInvoices.Location = new System.Drawing.Point(666, 12);
            this.pnlInvoices.Name = "pnlInvoices";
            this.pnlInvoices.Size = new System.Drawing.Size(400, 200);
            // 
            // 
            // 
            this.pnlInvoices.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlInvoices.Style.BackColorGradientAngle = 90;
            this.pnlInvoices.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlInvoices.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlInvoices.Style.BorderBottomWidth = 1;
            this.pnlInvoices.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlInvoices.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlInvoices.Style.BorderLeftWidth = 1;
            this.pnlInvoices.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlInvoices.Style.BorderRightWidth = 1;
            this.pnlInvoices.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlInvoices.Style.BorderTopWidth = 1;
            this.pnlInvoices.Style.Class = "";
            this.pnlInvoices.Style.CornerDiameter = 4;
            this.pnlInvoices.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlInvoices.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnlInvoices.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlInvoices.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnlInvoices.StyleMouseDown.Class = "";
            this.pnlInvoices.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnlInvoices.StyleMouseOver.Class = "";
            this.pnlInvoices.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnlInvoices.TabIndex = 1;
            this.pnlInvoices.Text = "الفواتير";
            // 
            // btnPayInvoice
            // 
            this.btnPayInvoice.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPayInvoice.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPayInvoice.Image = global::RBG.Properties.Resources.Pay;
            this.btnPayInvoice.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnPayInvoice.Location = new System.Drawing.Point(185, 66);
            this.btnPayInvoice.Name = "btnPayInvoice";
            this.btnPayInvoice.Size = new System.Drawing.Size(200, 40);
            this.btnPayInvoice.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPayInvoice.TabIndex = 8;
            this.btnPayInvoice.Text = "دفع";
            this.btnPayInvoice.Click += new System.EventHandler(this.btnPayInvoice_Click);
            // 
            // btnListInvoices
            // 
            this.btnListInvoices.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnListInvoices.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnListInvoices.Image = global::RBG.Properties.Resources.List;
            this.btnListInvoices.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnListInvoices.Location = new System.Drawing.Point(185, 112);
            this.btnListInvoices.Name = "btnListInvoices";
            this.btnListInvoices.Size = new System.Drawing.Size(200, 40);
            this.btnListInvoices.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnListInvoices.TabIndex = 7;
            this.btnListInvoices.Text = "عرض الكل";
            this.btnListInvoices.Click += new System.EventHandler(this.btnListInvoices_Click);
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddInvoice.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddInvoice.Image = global::RBG.Properties.Resources.Add;
            this.btnAddInvoice.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnAddInvoice.Location = new System.Drawing.Point(185, 19);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(200, 40);
            this.btnAddInvoice.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddInvoice.TabIndex = 6;
            this.btnAddInvoice.Text = "إضافة جديد";
            this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // picInvoices
            // 
            this.picInvoices.BackColor = System.Drawing.Color.Transparent;
            this.picInvoices.Image = global::RBG.Properties.Resources.Invoice;
            this.picInvoices.Location = new System.Drawing.Point(31, 19);
            this.picInvoices.Name = "picInvoices";
            this.picInvoices.Size = new System.Drawing.Size(120, 120);
            this.picInvoices.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInvoices.TabIndex = 0;
            this.picInvoices.TabStop = false;
            // 
            // pnlMaterials
            // 
            this.pnlMaterials.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMaterials.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlMaterials.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlMaterials.Controls.Add(this.btnAddMaterialQuantity);
            this.pnlMaterials.Controls.Add(this.btnListMaterials);
            this.pnlMaterials.Controls.Add(this.btnAddMaterial);
            this.pnlMaterials.Controls.Add(this.picMaterials);
            this.pnlMaterials.Location = new System.Drawing.Point(260, 12);
            this.pnlMaterials.Name = "pnlMaterials";
            this.pnlMaterials.Size = new System.Drawing.Size(400, 200);
            // 
            // 
            // 
            this.pnlMaterials.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlMaterials.Style.BackColorGradientAngle = 90;
            this.pnlMaterials.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlMaterials.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlMaterials.Style.BorderBottomWidth = 1;
            this.pnlMaterials.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlMaterials.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlMaterials.Style.BorderLeftWidth = 1;
            this.pnlMaterials.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlMaterials.Style.BorderRightWidth = 1;
            this.pnlMaterials.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlMaterials.Style.BorderTopWidth = 1;
            this.pnlMaterials.Style.Class = "";
            this.pnlMaterials.Style.CornerDiameter = 4;
            this.pnlMaterials.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlMaterials.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnlMaterials.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlMaterials.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnlMaterials.StyleMouseDown.Class = "";
            this.pnlMaterials.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnlMaterials.StyleMouseOver.Class = "";
            this.pnlMaterials.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnlMaterials.TabIndex = 2;
            this.pnlMaterials.Text = "الخامات / المواد";
            // 
            // btnAddMaterialQuantity
            // 
            this.btnAddMaterialQuantity.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddMaterialQuantity.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddMaterialQuantity.Image = global::RBG.Properties.Resources.IncreaseQuantity;
            this.btnAddMaterialQuantity.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnAddMaterialQuantity.Location = new System.Drawing.Point(185, 66);
            this.btnAddMaterialQuantity.Name = "btnAddMaterialQuantity";
            this.btnAddMaterialQuantity.Size = new System.Drawing.Size(200, 40);
            this.btnAddMaterialQuantity.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddMaterialQuantity.TabIndex = 8;
            this.btnAddMaterialQuantity.Text = "إضافة كمية لـ مادة / خامة";
            this.btnAddMaterialQuantity.Click += new System.EventHandler(this.btnAddMaterialQuantity_Click);
            // 
            // btnListMaterials
            // 
            this.btnListMaterials.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnListMaterials.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnListMaterials.Image = global::RBG.Properties.Resources.List;
            this.btnListMaterials.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnListMaterials.Location = new System.Drawing.Point(185, 112);
            this.btnListMaterials.Name = "btnListMaterials";
            this.btnListMaterials.Size = new System.Drawing.Size(200, 40);
            this.btnListMaterials.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnListMaterials.TabIndex = 7;
            this.btnListMaterials.Text = "عرض الكل";
            this.btnListMaterials.Click += new System.EventHandler(this.btnListMaterials_Click);
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddMaterial.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddMaterial.Image = global::RBG.Properties.Resources.Add;
            this.btnAddMaterial.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnAddMaterial.Location = new System.Drawing.Point(185, 20);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(200, 40);
            this.btnAddMaterial.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddMaterial.TabIndex = 6;
            this.btnAddMaterial.Text = "إضافة مادة جديد";
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // picMaterials
            // 
            this.picMaterials.BackColor = System.Drawing.Color.Transparent;
            this.picMaterials.Image = global::RBG.Properties.Resources.Materials;
            this.picMaterials.Location = new System.Drawing.Point(27, 19);
            this.picMaterials.Name = "picMaterials";
            this.picMaterials.Size = new System.Drawing.Size(120, 120);
            this.picMaterials.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMaterials.TabIndex = 0;
            this.picMaterials.TabStop = false;
            // 
            // pnlClients
            // 
            this.pnlClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlClients.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlClients.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlClients.Controls.Add(this.btnListClients);
            this.pnlClients.Controls.Add(this.btnAddClient);
            this.pnlClients.Controls.Add(this.picClients);
            this.pnlClients.Location = new System.Drawing.Point(666, 218);
            this.pnlClients.Name = "pnlClients";
            this.pnlClients.Size = new System.Drawing.Size(400, 200);
            // 
            // 
            // 
            this.pnlClients.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlClients.Style.BackColorGradientAngle = 90;
            this.pnlClients.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlClients.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlClients.Style.BorderBottomWidth = 1;
            this.pnlClients.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlClients.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlClients.Style.BorderLeftWidth = 1;
            this.pnlClients.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlClients.Style.BorderRightWidth = 1;
            this.pnlClients.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlClients.Style.BorderTopWidth = 1;
            this.pnlClients.Style.Class = "";
            this.pnlClients.Style.CornerDiameter = 4;
            this.pnlClients.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlClients.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnlClients.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlClients.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnlClients.StyleMouseDown.Class = "";
            this.pnlClients.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnlClients.StyleMouseOver.Class = "";
            this.pnlClients.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnlClients.TabIndex = 3;
            this.pnlClients.Text = "العملاء";
            // 
            // btnListClients
            // 
            this.btnListClients.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnListClients.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnListClients.Image = global::RBG.Properties.Resources.ShowAllClients;
            this.btnListClients.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnListClients.Location = new System.Drawing.Point(185, 79);
            this.btnListClients.Name = "btnListClients";
            this.btnListClients.Size = new System.Drawing.Size(200, 40);
            this.btnListClients.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnListClients.TabIndex = 7;
            this.btnListClients.Text = "عرض كل العملاء";
            this.btnListClients.Click += new System.EventHandler(this.btnListClients_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddClient.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddClient.Image = global::RBG.Properties.Resources.Add;
            this.btnAddClient.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnAddClient.Location = new System.Drawing.Point(185, 33);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(200, 40);
            this.btnAddClient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddClient.TabIndex = 6;
            this.btnAddClient.Text = "إضافة عميل جديد";
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // picClients
            // 
            this.picClients.BackColor = System.Drawing.Color.Transparent;
            this.picClients.Image = global::RBG.Properties.Resources.Clients;
            this.picClients.Location = new System.Drawing.Point(31, 19);
            this.picClients.Name = "picClients";
            this.picClients.Size = new System.Drawing.Size(120, 120);
            this.picClients.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClients.TabIndex = 0;
            this.picClients.TabStop = false;
            // 
            // pnlAdmins
            // 
            this.pnlAdmins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAdmins.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlAdmins.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlAdmins.Controls.Add(this.btnEditAdmin);
            this.pnlAdmins.Controls.Add(this.picAdmins);
            this.pnlAdmins.Location = new System.Drawing.Point(260, 218);
            this.pnlAdmins.Name = "pnlAdmins";
            this.pnlAdmins.Size = new System.Drawing.Size(400, 200);
            // 
            // 
            // 
            this.pnlAdmins.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlAdmins.Style.BackColorGradientAngle = 90;
            this.pnlAdmins.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlAdmins.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlAdmins.Style.BorderBottomWidth = 1;
            this.pnlAdmins.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlAdmins.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlAdmins.Style.BorderLeftWidth = 1;
            this.pnlAdmins.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlAdmins.Style.BorderRightWidth = 1;
            this.pnlAdmins.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlAdmins.Style.BorderTopWidth = 1;
            this.pnlAdmins.Style.Class = "";
            this.pnlAdmins.Style.CornerDiameter = 4;
            this.pnlAdmins.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlAdmins.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnlAdmins.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlAdmins.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnlAdmins.StyleMouseDown.Class = "";
            this.pnlAdmins.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnlAdmins.StyleMouseOver.Class = "";
            this.pnlAdmins.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnlAdmins.TabIndex = 4;
            this.pnlAdmins.Text = "المستخدمين";
            // 
            // btnEditAdmin
            // 
            this.btnEditAdmin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditAdmin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEditAdmin.Image = global::RBG.Properties.Resources.Edit;
            this.btnEditAdmin.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnEditAdmin.Location = new System.Drawing.Point(185, 60);
            this.btnEditAdmin.Name = "btnEditAdmin";
            this.btnEditAdmin.Size = new System.Drawing.Size(200, 40);
            this.btnEditAdmin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEditAdmin.TabIndex = 6;
            this.btnEditAdmin.Text = "تعديل المستخدم";
            this.btnEditAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // picAdmins
            // 
            this.picAdmins.BackColor = System.Drawing.Color.Transparent;
            this.picAdmins.Image = global::RBG.Properties.Resources.Admin;
            this.picAdmins.Location = new System.Drawing.Point(27, 19);
            this.picAdmins.Name = "picAdmins";
            this.picAdmins.Size = new System.Drawing.Size(120, 120);
            this.picAdmins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdmins.TabIndex = 0;
            this.picAdmins.TabStop = false;
            // 
            // pnlDB
            // 
            this.pnlDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDB.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlDB.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlDB.Controls.Add(this.picDB);
            this.pnlDB.Location = new System.Drawing.Point(666, 424);
            this.pnlDB.Name = "pnlDB";
            this.pnlDB.Size = new System.Drawing.Size(400, 200);
            // 
            // 
            // 
            this.pnlDB.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlDB.Style.BackColorGradientAngle = 90;
            this.pnlDB.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlDB.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlDB.Style.BorderBottomWidth = 1;
            this.pnlDB.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlDB.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlDB.Style.BorderLeftWidth = 1;
            this.pnlDB.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlDB.Style.BorderRightWidth = 1;
            this.pnlDB.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlDB.Style.BorderTopWidth = 1;
            this.pnlDB.Style.Class = "";
            this.pnlDB.Style.CornerDiameter = 4;
            this.pnlDB.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlDB.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnlDB.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlDB.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnlDB.StyleMouseDown.Class = "";
            this.pnlDB.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnlDB.StyleMouseOver.Class = "";
            this.pnlDB.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnlDB.TabIndex = 5;
            this.pnlDB.Text = "قاعدة البيانات";
            this.pnlDB.Visible = false;
            // 
            // picDB
            // 
            this.picDB.BackColor = System.Drawing.Color.Transparent;
            this.picDB.Image = global::RBG.Properties.Resources.DB;
            this.picDB.Location = new System.Drawing.Point(31, 22);
            this.picDB.Name = "picDB";
            this.picDB.Size = new System.Drawing.Size(120, 120);
            this.picDB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDB.TabIndex = 0;
            this.picDB.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::RBG.Properties.Resources.Exit;
            this.btnClose.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(12, 601);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 40);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "خروج";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 653);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlDB);
            this.Controls.Add(this.pnlAdmins);
            this.Controls.Add(this.pnlClients);
            this.Controls.Add(this.pnlMaterials);
            this.Controls.Add(this.pnlInvoices);
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
            this.pnlInvoices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picInvoices)).EndInit();
            this.pnlMaterials.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMaterials)).EndInit();
            this.pnlClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClients)).EndInit();
            this.pnlAdmins.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAdmins)).EndInit();
            this.pnlDB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.GroupPanel pnlInvoices;
        private System.Windows.Forms.PictureBox picInvoices;
        private DevComponents.DotNetBar.ButtonX btnListInvoices;
        private DevComponents.DotNetBar.ButtonX btnAddInvoice;
        private DevComponents.DotNetBar.Controls.GroupPanel pnlMaterials;
        private DevComponents.DotNetBar.ButtonX btnListMaterials;
        private DevComponents.DotNetBar.ButtonX btnAddMaterial;
        private System.Windows.Forms.PictureBox picMaterials;
        private DevComponents.DotNetBar.Controls.GroupPanel pnlClients;
        private DevComponents.DotNetBar.ButtonX btnListClients;
        private DevComponents.DotNetBar.ButtonX btnAddClient;
        private System.Windows.Forms.PictureBox picClients;
        private DevComponents.DotNetBar.Controls.GroupPanel pnlAdmins;
        private DevComponents.DotNetBar.ButtonX btnEditAdmin;
        private System.Windows.Forms.PictureBox picAdmins;
        private DevComponents.DotNetBar.Controls.GroupPanel pnlDB;
        private System.Windows.Forms.PictureBox picDB;
        private DevComponents.DotNetBar.ButtonX btnAddMaterialQuantity;
        private DevComponents.DotNetBar.ButtonX btnPayInvoice;
        private DevComponents.DotNetBar.ButtonX btnClose;
    }
}