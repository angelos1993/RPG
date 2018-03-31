using System.Windows.Forms;
using RPG.BLL;
using RPG.Utility;
using static RPG.Utility.MessageBoxUtility;

namespace RPG.PL.Forms
{
    public partial class FrmEditAdmin : FrmMaster
    {
        #region Constructor

        public FrmEditAdmin()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private AdminManager _adminManager;
        private AdminManager AdminManager => _adminManager ?? (_adminManager = new AdminManager());

        #endregion

        #region Events

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ChangeAdminData();
            Cursor = Cursors.Default;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void ChangeAdminData()
        {
            ErrorProvider.Clear();
            var currentAdmin = AdminManager.GetCurrentAdmin();
            var isFormValid = true;
            if (txtCurrentUsername.Text != currentAdmin.Username)
            {
                isFormValid = false;
                ErrorProvider.SetError(txtCurrentUsername, Resources.CurrentUsernameInvalid);
            }
            if (txtCurrentPassword.Text.ToMd5Hash() != currentAdmin.Password)
            {
                isFormValid = false;
                ErrorProvider.SetError(txtCurrentPassword, Resources.CurrentPasswordInvalid);
            }
            if (!isFormValid)
                return;
            if (txtNewUsername.Text.IsNullOrEmptyOrWhiteSpace())
            {
                isFormValid = false;
                ErrorProvider.SetError(txtNewUsername, Resources.ThisFieldIsRequired);
            }
            if (txtNewPassword.Text.IsNullOrEmptyOrWhiteSpace())
            {
                isFormValid = false;
                ErrorProvider.SetError(txtNewPassword, Resources.ThisFieldIsRequired);
            }
            if (txtNewPasswordConfirmation.Text.IsNullOrEmptyOrWhiteSpace())
            {
                isFormValid = false;
                ErrorProvider.SetError(txtNewPasswordConfirmation, Resources.ThisFieldIsRequired);
            }
            if (!isFormValid)
                return;
            if (txtNewPassword.Text != txtNewPasswordConfirmation.Text)
            {
                isFormValid = false;
                ErrorProvider.SetError(txtNewPassword, Resources.NewPasswordConfirmationNotMached);
                ErrorProvider.SetError(txtNewPasswordConfirmation, Resources.NewPasswordConfirmationNotMached);
            }
            if (!isFormValid)
                return;
            if (currentAdmin.Username == txtNewUsername.Text &&
                currentAdmin.Password == txtNewPassword.Text.ToMd5Hash())
            {
                ShowErrorMsg(Resources.UsernameOrPasswordShouldChanged);
                ErrorProvider.SetError(txtNewUsername, Resources.UsernameOrPasswordShouldChanged);
                ErrorProvider.SetError(txtNewPassword, Resources.UsernameOrPasswordShouldChanged);
                ErrorProvider.SetError(txtNewPasswordConfirmation, Resources.UsernameOrPasswordShouldChanged);
                return;
            }
            currentAdmin.Username = txtNewUsername.Text;
            currentAdmin.Password = txtNewPassword.Text.ToMd5Hash();
            AdminManager.UpdateAdmin(currentAdmin);
            ShowInfoMsg(Resources.UpdateAdminDataSuccessfully);
            Close();
        }

        #endregion
    }
}