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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMaterials = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.radName = new System.Windows.Forms.RadioButton();
            this.radCode = new System.Windows.Forms.RadioButton();
            this.radPrice = new System.Windows.Forms.RadioButton();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnAddMaterial = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaterials
            // 
            this.dgvMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaterials.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMaterials.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvMaterials.Location = new System.Drawing.Point(12, 74);
            this.dgvMaterials.MultiSelect = false;
            this.dgvMaterials.Name = "dgvMaterials";
            this.dgvMaterials.ReadOnly = true;
            this.dgvMaterials.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterials.Size = new System.Drawing.Size(453, 326);
            this.dgvMaterials.TabIndex = 0;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.Border.Class = "TextBoxBorder";
            this.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearch.Location = new System.Drawing.Point(207, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(258, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.WatermarkText = "بحث في المواد / الخامات ...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // radName
            // 
            this.radName.AutoSize = true;
            this.radName.Checked = true;
            this.radName.Location = new System.Drawing.Point(327, 44);
            this.radName.Name = "radName";
            this.radName.Size = new System.Drawing.Size(54, 24);
            this.radName.TabIndex = 2;
            this.radName.TabStop = true;
            this.radName.Text = "الاسم";
            this.radName.UseVisualStyleBackColor = true;
            this.radName.CheckedChanged += new System.EventHandler(this.radSort_CheckedChanged);
            // 
            // radCode
            // 
            this.radCode.AutoSize = true;
            this.radCode.Location = new System.Drawing.Point(269, 44);
            this.radCode.Name = "radCode";
            this.radCode.Size = new System.Drawing.Size(52, 24);
            this.radCode.TabIndex = 3;
            this.radCode.Text = "الكود";
            this.radCode.UseVisualStyleBackColor = true;
            this.radCode.CheckedChanged += new System.EventHandler(this.radSort_CheckedChanged);
            // 
            // radPrice
            // 
            this.radPrice.AutoSize = true;
            this.radPrice.Location = new System.Drawing.Point(206, 44);
            this.radPrice.Name = "radPrice";
            this.radPrice.Size = new System.Drawing.Size(57, 24);
            this.radPrice.TabIndex = 4;
            this.radPrice.Text = "السعر";
            this.radPrice.UseVisualStyleBackColor = true;
            this.radPrice.CheckedChanged += new System.EventHandler(this.radSort_CheckedChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(375, 44);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(90, 23);
            this.labelX2.TabIndex = 18;
            this.labelX2.Text = "ترتيب حسب :";
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEdit.Image = global::RBG.Properties.Resources.Edit;
            this.btnEdit.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnEdit.Location = new System.Drawing.Point(309, 406);
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
            this.btnAddMaterial.Image = global::RBG.Properties.Resources.Save;
            this.btnAddMaterial.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.btnAddMaterial.Location = new System.Drawing.Point(12, 12);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(189, 26);
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
            this.btnClose.Location = new System.Drawing.Point(37, 406);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 40);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "خروج";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Image = global::RBG.Properties.Resources.Delete;
            this.btnDelete.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnDelete.Location = new System.Drawing.Point(173, 406);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 40);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "حذف";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 458);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.radPrice);
            this.Controls.Add(this.radCode);
            this.Controls.Add(this.radName);
            this.Controls.Add(this.btnAddMaterial);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvMaterials);
            this.DoubleBuffered = true;
            this.Name = "FrmMaterials";
            this.Text = "المواد / الخامات";
            this.Load += new System.EventHandler(this.FrmMaterials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvMaterials;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
        private DevComponents.DotNetBar.ButtonX btnAddMaterial;
        private System.Windows.Forms.RadioButton radName;
        private System.Windows.Forms.RadioButton radCode;
        private System.Windows.Forms.RadioButton radPrice;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btnEdit;
    }
}