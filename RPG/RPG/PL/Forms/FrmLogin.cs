using System;
using System.Windows.Forms;
using RPG.BLL;

namespace RPG.PL.Forms
{
    public partial class FrmLogin : FrmMaster
    {
        #region Constructor

        public FrmLogin()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private AdminManager _adminManager;
        private AdminManager AdminManager => _adminManager ?? (_adminManager = new AdminManager());

        #endregion

        #region Events

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lblValidationMsg.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblValidationMsg.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Login();
            Cursor = Cursors.Default;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Methods

        private void Login()
        {
            if (AdminManager.Login(txtUsername.Text, txtPassword.Text))
            {
                Hide();
                new FrmIndex().Show();
            }
            lblValidationMsg.Visible = true;
            txtPassword.Clear();
            txtUsername.SelectAll();
            txtUsername.Focus();
        }

        #endregion
    }
}