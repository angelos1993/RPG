namespace RPG.PL.Forms
{
    partial class FrmEditAdmin
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
            this.txtCurrentUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.pnlCurrentData = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtCurrentPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pnlNewData = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtNewPasswordConfirmation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtNewPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtNewUsername = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.pnlCurrentData.SuspendLayout();
            this.pnlNewData.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCurrentUsername
            // 
            // 
            // 
            // 
            this.txtCurrentUsername.Border.Class = "TextBoxBorder";
            this.txtCurrentUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCurrentUsername.Location = new System.Drawing.Point(38, 3);
            this.txtCurrentUsername.Name = "txtCurrentUsername";
            this.txtCurrentUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCurrentUsername.Size = new System.Drawing.Size(318, 26);
            this.txtCurrentUsername.TabIndex = 0;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(362, 3);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(122, 23);
            this.labelX4.TabIndex = 11;
            this.labelX4.Text = "اسم المستخدم الحالي";
            // 
            // pnlCurrentData
            // 
            this.pnlCurrentData.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlCurrentData.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlCurrentData.Controls.Add(this.labelX6);
            this.pnlCurrentData.Controls.Add(this.txtCurrentPassword);
            this.pnlCurrentData.Controls.Add(this.labelX4);
            this.pnlCurrentData.Controls.Add(this.txtCurrentUsername);
            this.pnlCurrentData.Location = new System.Drawing.Point(12, 12);
            this.pnlCurrentData.Name = "pnlCurrentData";
            this.pnlCurrentData.Size = new System.Drawing.Size(493, 96);
            // 
            // 
            // 
            this.pnlCurrentData.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlCurrentData.Style.BackColorGradientAngle = 90;
            this.pnlCurrentData.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlCurrentData.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlCurrentData.Style.BorderBottomWidth = 1;
            this.pnlCurrentData.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlCurrentData.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlCurrentData.Style.BorderLeftWidth = 1;
            this.pnlCurrentData.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlCurrentData.Style.BorderRightWidth = 1;
            this.pnlCurrentData.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlCurrentData.Style.BorderTopWidth = 1;
            this.pnlCurrentData.Style.Class = "";
            this.pnlCurrentData.Style.CornerDiameter = 4;
            this.pnlCurrentData.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlCurrentData.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnlCurrentData.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlCurrentData.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnlCurrentData.StyleMouseDown.Class = "";
            this.pnlCurrentData.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnlCurrentData.StyleMouseOver.Class = "";
            this.pnlCurrentData.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnlCurrentData.TabIndex = 13;
            this.pnlCurrentData.Text = "البيانات الحالية";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(362, 35);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX6.Size = new System.Drawing.Size(122, 23);
            this.labelX6.TabIndex = 13;
            this.labelX6.Text = "كلمة المرور الحالية";
            // 
            // txtCurrentPassword
            // 
            // 
            // 
            // 
            this.txtCurrentPassword.Border.Class = "TextBoxBorder";
            this.txtCurrentPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCurrentPassword.Location = new System.Drawing.Point(38, 35);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCurrentPassword.Size = new System.Drawing.Size(318, 26);
            this.txtCurrentPassword.TabIndex = 1;
            this.txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // pnlNewData
            // 
            this.pnlNewData.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlNewData.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlNewData.Controls.Add(this.labelX1);
            this.pnlNewData.Controls.Add(this.txtNewPasswordConfirmation);
            this.pnlNewData.Controls.Add(this.labelX7);
            this.pnlNewData.Controls.Add(this.txtNewPassword);
            this.pnlNewData.Controls.Add(this.labelX8);
            this.pnlNewData.Controls.Add(this.txtNewUsername);
            this.pnlNewData.Location = new System.Drawing.Point(12, 114);
            this.pnlNewData.Name = "pnlNewData";
            this.pnlNewData.Size = new System.Drawing.Size(493, 128);
            // 
            // 
            // 
            this.pnlNewData.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlNewData.Style.BackColorGradientAngle = 90;
            this.pnlNewData.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlNewData.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlNewData.Style.BorderBottomWidth = 1;
            this.pnlNewData.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlNewData.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlNewData.Style.BorderLeftWidth = 1;
            this.pnlNewData.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlNewData.Style.BorderRightWidth = 1;
            this.pnlNewData.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlNewData.Style.BorderTopWidth = 1;
            this.pnlNewData.Style.Class = "";
            this.pnlNewData.Style.CornerDiameter = 4;
            this.pnlNewData.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlNewData.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnlNewData.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlNewData.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.pnlNewData.StyleMouseDown.Class = "";
            this.pnlNewData.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.pnlNewData.StyleMouseOver.Class = "";
            this.pnlNewData.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pnlNewData.TabIndex = 14;
            this.pnlNewData.Text = "البيانات الجديدة";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(362, 67);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(122, 23);
            this.labelX1.TabIndex = 15;
            this.labelX1.Text = "تأكيد كلمة المرور";
            // 
            // txtNewPasswordConfirmation
            // 
            // 
            // 
            // 
            this.txtNewPasswordConfirmation.Border.Class = "TextBoxBorder";
            this.txtNewPasswordConfirmation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNewPasswordConfirmation.Location = new System.Drawing.Point(38, 67);
            this.txtNewPasswordConfirmation.Name = "txtNewPasswordConfirmation";
            this.txtNewPasswordConfirmation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNewPasswordConfirmation.Size = new System.Drawing.Size(318, 26);
            this.txtNewPasswordConfirmation.TabIndex = 2;
            this.txtNewPasswordConfirmation.UseSystemPasswordChar = true;
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(362, 35);
            this.labelX7.Name = "labelX7";
            this.labelX7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX7.Size = new System.Drawing.Size(122, 23);
            this.labelX7.TabIndex = 13;
            this.labelX7.Text = "كلمة المرور الجديدة";
            // 
            // txtNewPassword
            // 
            // 
            // 
            // 
            this.txtNewPassword.Border.Class = "TextBoxBorder";
            this.txtNewPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNewPassword.Location = new System.Drawing.Point(38, 35);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNewPassword.Size = new System.Drawing.Size(318, 26);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(362, 3);
            this.labelX8.Name = "labelX8";
            this.labelX8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX8.Size = new System.Drawing.Size(122, 23);
            this.labelX8.TabIndex = 11;
            this.labelX8.Text = "اسم المستخدم الجديد";
            // 
            // txtNewUsername
            // 
            // 
            // 
            // 
            this.txtNewUsername.Border.Class = "TextBoxBorder";
            this.txtNewUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNewUsername.Location = new System.Drawing.Point(38, 3);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNewUsername.Size = new System.Drawing.Size(318, 26);
            this.txtNewUsername.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::RPG.Properties.Resources.Exit;
            this.btnClose.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnClose.Location = new System.Drawing.Point(125, 248);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 40);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "خروج";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::RPG.Properties.Resources.Save;
            this.btnSave.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(261, 248);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmEditAdmin
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(517, 297);
            this.Controls.Add(this.pnlNewData);
            this.Controls.Add(this.pnlCurrentData);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.DoubleBuffered = true;
            this.Name = "FrmEditAdmin";
            this.Text = "تعديل المستخدم";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.pnlCurrentData.ResumeLayout(false);
            this.pnlNewData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtCurrentUsername;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.GroupPanel pnlCurrentData;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCurrentPassword;
        private DevComponents.DotNetBar.Controls.GroupPanel pnlNewData;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNewPassword;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNewUsername;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNewPasswordConfirmation;
    }
}