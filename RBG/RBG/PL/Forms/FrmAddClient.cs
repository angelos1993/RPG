using System.Windows.Forms;
using RBG.BLL;
using RBG.DAL.Model;
using RBG.Utility;
using static RBG.Utility.Constants;

namespace RBG.PL.Forms
{
    public partial class FrmAddClient : FrmMaster
    {
        #region Constructor

        public FrmAddClient()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private ClientManager _clientManager;
        private ClientManager ClientManager => _clientManager ?? (_clientManager = new ClientManager());

        #endregion

        #region Events

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SaveClient();
            Cursor = Cursors.Default;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void SaveClient()
        {
            var isFormValid = true;
            if (txtName.Text.FullTrim().IsNullOrEmptyOrWhiteSpace())
            {
                isFormValid = false;
                ErrorProvider.SetError(txtName, ValidationMsg);
                txtName.Focus();
            }
            if (!isFormValid)
                return;
            ClientManager.AddClient(new Client
            {
                Name = txtName.Text.FullTrim(),
                Address = txtAddress.Text.FullTrim(),
                Phone = txtPhone.Text.FullTrim()
            });
            Close();
        }

        #endregion
    }
}