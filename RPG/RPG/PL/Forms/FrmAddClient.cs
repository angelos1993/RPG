using System;
using System.Windows.Forms;
using RPG.BLL;
using RPG.DAL.Model;
using RPG.Utility;

namespace RPG.PL.Forms
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

        private void chkBoxViber_CheckedChanged(object sender, EventArgs e)
        {
            txtViber.Text = chkBoxViber.Checked ? txtPhone.Text : string.Empty;
            txtViber.Enabled = !chkBoxViber.Checked;
        }

        private void chkBoxWhatsApp_CheckedChanged(object sender, EventArgs e)
        {
            txtWhatsApp.Text = chkBoxWhatsApp.Checked ? txtPhone.Text : string.Empty;
            txtWhatsApp.Enabled = !chkBoxWhatsApp.Checked;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (chkBoxViber.Checked)
                txtViber.Text = txtPhone.Text;
            if (chkBoxWhatsApp.Checked)
                txtWhatsApp.Text = txtPhone.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SaveClient();
            Cursor = Cursors.Default;
        }

        private void btnClose_Click(object sender, EventArgs e)
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
                    Phone = txtPhone.Text.FullTrim(),
                    Email = txtEmail.Text.FullTrim(),
                    Facebook = txtFacebook.Text.FullTrim(),
                    Viber = txtViber.Text.FullTrim(),
                    WhatsApp = txtWhatsApp.Text.FullTrim(),
                    Other = txtOther.Text.FullTrim()
                });
            }
            else
            {
                Client.Name = txtName.Text.FullTrim();
                Client.Address = txtAddress.Text.FullTrim();
                Client.Phone = txtPhone.Text.FullTrim();
                Client.Email = txtEmail.Text.FullTrim();
                Client.Facebook = txtFacebook.Text.FullTrim();
                Client.Viber = txtViber.Text.FullTrim();
                Client.WhatsApp = txtWhatsApp.Text.FullTrim();
                Client.Other = txtOther.Text.FullTrim();
                ClientManager.UpdateClient(Client);
            }
            MessageBoxUtility.ShowInfoMsg(IsEditMode ? Resources.ClientEditedSeccessfully : Resources.ClientAddedSeccessfully);
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
            txtEmail.Text = Client.Email;
            txtFacebook.Text = Client.Facebook;
            txtViber.Text = Client.Viber;
            txtWhatsApp.Text = Client.WhatsApp;
            txtOther.Text = Client.Other;
        }

        #endregion
    }
}