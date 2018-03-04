using System;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using RBG.Utility;
using static RBG.Utility.MessageBoxUtility;
using static RBG.Utility.Constants;

namespace RBG.PL.Forms
{
    public partial class FrmDatabase : FrmMaster
    {
        #region Constructor

        public FrmDatabase()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        #endregion

        #region Events

        private void FrmDatabase_Load(object sender, EventArgs e)
        {
            ShowOrHideControls(false);
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DisableButtons();
            BackupDatabase();
            Cursor = Cursors.Default;
        }

        private void btnBackupToDrive_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DisableButtons();
            BackupDatabaseToGoogleDrive();
            Cursor = Cursors.Default;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DisableButtons();
            RestoreDatabase();
            Cursor = Cursors.Default;
        }

        private void PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar.Value = e.Percent;
            lblProgress.Text = $@"{e.Percent}%";
        }

        private void Backup_Complet(object sender, ServerMessageEventArgs e)
        {
            Cursor = Cursors.Default;
            ShowOrHideControls(false);
            ShowInfoMsg(Resources.DatabaseBackupSuccessfully);
            Close();
        }

        private void Restore_Complete(object sender, ServerMessageEventArgs e)
        {
            Cursor = Cursors.Default;
            ShowOrHideControls(false);
            ShowInfoMsg(Resources.DatabaseRestoreSuccessfully);
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void BackupDatabase()
        {
            try
            {
                var folderBrowserDialog = new FolderBrowserDialog
                {
                    Description = @"من فضلك قم بإختيار المكان الذي تريد نسخ قاعدة البيانات فية"
                };
                if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                    return;
                ShowOrHideControls(true);
                var server = new Server(new ServerConnection(ServerName));
                var backup = new Backup { Action = BackupActionType.Database, Database = DatabaseName };
                backup.Devices.AddDevice(
                    $@"{folderBrowserDialog.SelectedPath}\{DatabaseName} - {DateTime.Now.ToFormattedDate()}.bak",
                    DeviceType.File);
                backup.Initialize = true;
                backup.PercentComplete += PercentComplete;
                backup.Complete += Backup_Complet;
                backup.SqlBackupAsync(server);
            }
            catch
            {
                Cursor = Cursors.Default;
                ShowErrorMsg(Resources.DatabaseBackupFailed);
            }
        }

        private void BackupDatabaseToGoogleDrive()
        {
            //todo: google drive service
        }
        private void RestoreDatabase()
        {
            try
            {
                var openFileDialog = new OpenFileDialog
                {
                    Title = @"من فضلك قم بإختيار ملف قاعدة البيانات الذي تريد إسترجاعة",
                    Filter = @"bak files (.bak)|*.bak",
                    Multiselect = false
                };
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                ShowOrHideControls(true);
                var server = new Server(new ServerConnection(ServerName));
                var restore = new Restore
                {
                    Database = DatabaseName,
                    Action = RestoreActionType.Database,
                    ReplaceDatabase = true,
                    NoRecovery = false
                };
                restore.Devices.AddDevice($@"{openFileDialog.FileName}", DeviceType.File);
                restore.PercentComplete += PercentComplete;
                restore.Complete += Restore_Complete;
                restore.SqlRestoreAsync(server);
            }
            catch
            {
                Cursor = Cursors.Default;
                ShowErrorMsg(Resources.DatabaseRestoreFailes);
            }
        }

        private void DisableButtons()
        {
            btnBackup.Enabled = btnBackupToDrive.Enabled = btnRestore.Enabled = false;
        }

        private void ShowOrHideControls(bool isVisible)
        {
            progressBar.Visible = isVisible;
            lblProgress.Visible = isVisible;
            lblProgress.Text = @"0%";
        }

        #endregion
    }
}