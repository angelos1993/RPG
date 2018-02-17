using System;
using System.Windows.Forms;

namespace RBG.PL.Forms
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

        #endregion

        #region Events

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Login();
            Cursor = Cursors.Default;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void Login()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}