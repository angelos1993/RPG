using System.Windows.Forms;
using RBG.BLL;
using RBG.DAL.Model;
using RBG.Utility;
using static RBG.Utility.MessageBoxUtility;

namespace RBG.PL.Forms
{
    public partial class FrmAddClient : FrmMaster
    {
        #region Constructor

        public FrmAddClient(int? clientId = null)
        {
            InitializeComponent();
            if(clientId.HasValue)
                SetFormForEditMode(clientId.Value);
        }

        #endregion

        #region Properties

        private ClientManager _clientManager;
        private ClientManager ClientManager => _clientManager ?? (_clientManager = new ClientManager());
        private bool IsEditMode { get; set; }
        private Client Client { get; set; }

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
            ErrorProvider.Clear();
            var isFormValid = true;
            if (txtName.Text.FullTrim().IsNullOrEmptyOrWhiteSpace())
            {
                isFormValid = false;
                ErrorProvider.SetError(txtName, Resources.ThisFieldIsRequired);
            }
            if (!isFormValid)
            {
                txtName.Focus();
                return;
            }
            if (!IsEditMode)
            {
                ClientManager.AddClient(new Client
                {
                    Name = txtName.Text.FullTrim(),
                    Address = txtAddress.Text.FullTrim(),
                    Phone = txtPhone.Text.FullTrim()
                });
            }
            else
            {
                Client.Name = txtName.Text.FullTrim();
                Client.Address = txtAddress.Text.FullTrim();
                Client.Phone = txtPhone.Text.FullTrim();
                ClientManager.UpdateClient(Client);
            }
            ShowInfoMsg(IsEditMode ? Resources.ClientEditedSeccessfully : Resources.ClientAddedSeccessfully);
            Close();
        }

        private void SetFormForEditMode(int clientId)
        {
            IsEditMode = true;
            Client = ClientManager.GetClientById(clientId);
            Text = @"تعديل عميل";
            txtName.Text = Client.Name;
            txtAddress.Text = Client.Address;
            txtPhone.Text = Client.Phone;
        }

        #endregion
    }
}