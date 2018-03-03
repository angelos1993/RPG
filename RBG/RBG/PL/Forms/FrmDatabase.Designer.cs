namespace RBG.PL.Forms
{
    partial class FrmDatabase
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
            this.progressBar = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.lblProgress = new DevComponents.DotNetBar.LabelX();
            this.btnRestore = new DevComponents.DotNetBar.ButtonX();
            this.btnBackup = new DevComponents.DotNetBar.ButtonX();
            this.btnBackupToDrive = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            // 
            // 
            // 
            this.progressBar.BackgroundStyle.Class = "";
            this.progressBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBar.Location = new System.Drawing.Point(12, 218);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(612, 48);
            this.progressBar.TabIndex = 12;
            this.progressBar.Text = "progressBarX1";
            // 
            // lblProgress
            // 
            // 
            // 
            // 
            this.lblProgress.BackgroundStyle.Class = "";
            this.lblProgress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblProgress.Location = new System.Drawing.Point(12, 272);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(612, 23);
            this.lblProgress.TabIndex = 13;
            this.lblProgress.Text = "labelX1";
            this.lblProgress.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnRestore
            // 
            this.btnRestore.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRestore.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRestore.Image = global::RBG.Properties.Resources.Restore;
            this.btnRestore.ImageFixedSize = new System.Drawing.Size(120, 120);
            this.btnRestore.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnRestore.Location = new System.Drawing.Point(12, 12);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(200, 200);
            this.btnRestore.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRestore.TabIndex = 11;
            this.btnRestore.Text = "إستعادة قاعدة البيانات";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBackup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBackup.Image = global::RBG.Properties.Resources.Backup;
            this.btnBackup.ImageFixedSize = new System.Drawing.Size(120, 120);
            this.btnBackup.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBackup.Location = new System.Drawing.Point(424, 12);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(200, 200);
            this.btnBackup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBackup.TabIndex = 10;
            this.btnBackup.Text = "نسخ قاعدة البيانات";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnBackupToDrive
            // 
            this.btnBackupToDrive.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBackupToDrive.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBackupToDrive.Image = global::RBG.Properties.Resources.GoogleDrive;
            this.btnBackupToDrive.ImageFixedSize = new System.Drawing.Size(120, 120);
            this.btnBackupToDrive.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBackupToDrive.Location = new System.Drawing.Point(218, 12);
            this.btnBackupToDrive.Name = "btnBackupToDrive";
            this.btnBackupToDrive.Size = new System.Drawing.Size(200, 200);
            this.btnBackupToDrive.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBackupToDrive.TabIndex = 9;
            this.btnBackupToDrive.Text = "نسخ قاعدة البيانات إلي Google Drive";
            this.btnBackupToDrive.Click += new System.EventHandler(this.btnBackupToDrive_Click);
            // 
            // FrmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 298);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnBackupToDrive);
            this.DoubleBuffered = true;
            this.Name = "FrmDatabase";
            this.Text = "فاعدة البيانات";
            this.Load += new System.EventHandler(this.FrmDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnBackupToDrive;
        private DevComponents.DotNetBar.ButtonX btnBackup;
        private DevComponents.DotNetBar.ButtonX btnRestore;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBar;
        private DevComponents.DotNetBar.LabelX lblProgress;
    }
}