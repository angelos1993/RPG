namespace RBG.PL.Forms
{
    partial class FrmMaterials
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMaterials = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.radName = new System.Windows.Forms.RadioButton();
            this.radCode = new System.Windows.Forms.RadioButton();
            this.radPrice = new System.Windows.Forms.RadioButton();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.grpSearch = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnAddMaterial = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnArchive = new DevComponents.DotNetBar.ButtonX();
            this.btnAddMaterialQuantity = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMaterials
            // 
            this.dgvMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaterials.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaterials.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvMaterials.Location = new System.Drawing.Point(12, 81);
            this.dgvMaterials.MultiSelect = false;
            this.dgvMaterials.Name = "dgvMaterials";
            this.dgvMaterials.ReadOnly = true;
            this.dgvMaterials.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterials.Size = new System.Drawing.Size(785, 319);
            this.dgvMaterials.TabIndex = 0;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.Border.Class = "TextBoxBorder";
            this.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearch.Location = new System.Drawing.Point(21, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(293, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.WatermarkText = "بحث في المواد / الخامات ...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // radName
            // 
            this.radName.AutoSize = true;
            this.radName.BackColor = System.Drawing.Color.Transparent;
            this.radName.Checked = true;
            this.radName.Location = new System.Drawing.Point(143, 3);
            this.radName.Name = "radName";
            this.radName.Size = new System.Drawing.Size(54, 24);
            this.radName.TabIndex = 2;
            this.radName.TabStop = true;
            this.radName.Text = "الاسم";
            this.radName.UseVisualStyleBackColor = false;
            this.radName.CheckedChanged += new System.EventHandler(this.radSort_CheckedChanged);
            // 
            // radCode
            // 
            this.radCode.AutoSize = true;
            this.radCode.BackColor = System.Drawing.Color.Transparent;
            this.radCode.Location = new System.Drawing.Point(83, 3);
            this.radCode.Name = "radCode";
            this.radCode.Size = new System.Drawing.Size(52, 24);
            this.radCode.TabIndex = 3;
            this.radCode.Text = "الكود";
            this.radCode.UseVisualStyleBackColor = false;
            this.radCode.CheckedChanged += new System.EventHandler(this.radSort_CheckedChanged);
            // 
            // radPrice
            // 
            this.radPrice.AutoSize = true;
            this.radPrice.BackColor = System.Drawing.Color.Transparent;
            this.radPrice.Location = new System.Drawing.Point(20, 3);
            this.radPrice.Name = "radPrice";
            this.radPrice.Size = new System.Drawing.Size(57, 24);
            this.radPrice.TabIndex = 4;
            this.radPrice.Text = "السعر";
            this.radPrice.UseVisualStyleBackColor = false;
            this.radPrice.CheckedChanged += new System.EventHandler(this.radSort_CheckedChanged);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.radCode);
            this.groupPanel1.Controls.Add(this.radName);
            this.groupPanel1.Controls.Add(this.radPrice);
            this.groupPanel1.Location = new System.Drawing.Point(221, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(224, 63);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 21;
            this.groupPanel1.Text = "ترتيب حسب";
            // 
            // grpSearch
            // 
            this.grpSearch.CanvasColor = System.Drawing.SystemColors.Control;
            this.grpSearch.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Location = new System.Drawing.Point(451, 12);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(346, 63);
            // 
            // 
            // 
            this.grpSearch.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.grpSearch.Style.BackColorGradientAngle = 90;
            this.grpSearch.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.grpSearch.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpSearch.Style.BorderBottomWidth = 1;
            this.grpSearch.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.grpSearch.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpSearch.Style.BorderLeftWidth = 1;
            this.grpSearch.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpSearch.Style.BorderRightWidth = 1;
            this.grpSearch.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.grpSearch.Style.BorderTopWidth = 1;
            this.grpSearch.Style.Class = "";
            this.grpSearch.Style.CornerDiameter = 4;
            this.grpSearch.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.grpSearch.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.grpSearch.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.grpSearch.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.grpSearch.StyleMouseDown.Class = "";
            this.grpSearch.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.grpSearch.StyleMouseOver.Class = "";
            this.grpSearch.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.grpSearch.TabIndex = 22;
            this.grpSearch.Text = "بحث";
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit.Image = global::RBG.Properties.Resources.Edit;
            this.btnEdit.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnEdit.Location = new System.Drawing.Point(475, 406);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 40);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddMaterial.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddMaterial.Image = global::RBG.Properties.Resources.Add;
            this.btnAddMaterial.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnAddMaterial.Location = new System.Drawing.Point(12, 17);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(203, 26);
            this.btnAddMaterial.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddMaterial.TabIndex = 1;
            this.btnAddMaterial.Text = "إضافة مادة / خامة جديدة";
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Image = global::RBG.Properties.Resources.Exit;
            this.btnClose.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(203, 406);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 40);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "خروج";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnArchive
            // 
            this.btnArchive.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnArchive.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnArchive.Image = global::RBG.Properties.Resources.Archive;
            this.btnArchive.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnArchive.Location = new System.Drawing.Point(339, 406);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(130, 40);
            this.btnArchive.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnArchive.TabIndex = 5;
            this.btnArchive.Text = "أرشفة";
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // btnAddMaterialQuantity
            // 
            this.btnAddMaterialQuantity.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddMaterialQuantity.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddMaterialQuantity.Image = global::RBG.Properties.Resources.IncreaseQuantity;
            this.btnAddMaterialQuantity.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnAddMaterialQuantity.Location = new System.Drawing.Point(12, 49);
            this.btnAddMaterialQuantity.Name = "btnAddMaterialQuantity";
            this.btnAddMaterialQuantity.Size = new System.Drawing.Size(203, 26);
            this.btnAddMaterialQuantity.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddMaterialQuantity.TabIndex = 23;
            this.btnAddMaterialQuantity.Text = "إضافة كمية لـ مادة / خامة";
            this.btnAddMaterialQuantity.Click += new System.EventHandler(this.btnAddMaterialQuantity_Click);
            // 
            // FrmMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 458);
            this.Controls.Add(this.btnAddMaterialQuantity);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddMaterial);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.dgvMaterials);
            this.DoubleBuffered = true;
            this.Name = "FrmMaterials";
            this.Text = "المواد / الخامات";
            this.Load += new System.EventHandler(this.FrmMaterials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvMaterials;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnArchive;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
        private DevComponents.DotNetBar.ButtonX btnAddMaterial;
        private System.Windows.Forms.RadioButton radName;
        private System.Windows.Forms.RadioButton radCode;
        private System.Windows.Forms.RadioButton radPrice;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel grpSearch;
        private DevComponents.DotNetBar.ButtonX btnAddMaterialQuantity;
    }
}