using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RPG.BLL;
using RPG.DAL.Model;
using RPG.DAL.VMs;
using RPG.Utility;
using RPG.Utility.Enums;

namespace RPG.PL.Forms
{
    public partial class FrmClients : FrmMaster
    {
        #region Constructor

        public FrmClients()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private ClientManager _clientManager;
        private ClientManager ClientManager => _clientManager ?? (_clientManager = new ClientManager());
        private InvoiceManager _invoiceManager;
        private InvoiceManager InvoiceManager => _invoiceManager ?? (_invoiceManager = new InvoiceManager());
        private List<Client> Clients { get; set; }
        private List<ClientVm> ClientsList { get; set; }

        #endregion

        #region Events

        private void FrmClients_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ResetForm();
            Cursor = Cursors.Default;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SearchClients();
            Cursor = Cursors.Default;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            new FrmAddClient().ShowDialog();
            ResetForm();
            Cursor = Cursors.Default;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            EditClient();
            Cursor = Cursors.Default;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBoxUtility.ShowConfirmationDialog(Resources.DeleteClientConfirmationMsg, DialogDefaultButton.No) !=
                DialogResult.Yes)
                return;
            Cursor = Cursors.WaitCursor;
            DeleteClient();
            Cursor = Cursors.Default;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void ResetForm()
        {
            GetClients();
            SearchClients();
            dgvClients.Columns[0].Visible = false;
        }

        private void GetClients()
        {
            Clients = ClientManager.GetAllClients().OrderBy(client => client.Name).ToList();
            ClientsList = Clients.Select(client => new ClientVm
            {
                Id = client.Id,
                Name = client.Name,
                Address = client.Address,
                Phone = client.Phone,
                Email = client.Email,
                Facebook = client.Facebook,
                Viber = client.Viber,
                WhatsApp = client.WhatsApp,
                Other = client.Other
            }).ToList();
        }

        private void SearchClients()
        {
            var searchText = txtSearch.Text.FullTrim();
            ClientsList = Clients.Where(client => client.Name != null && client.Name.Contains(searchText)
                                                  || client.Address != null && client.Address.Contains(searchText) ||
                                                  client.Phone != null && client.Phone.Contains(searchText) ||
                                                  client.Email != null && client.Email.Contains(searchText) ||
                                                  client.Facebook != null && client.Facebook.Contains(searchText) ||
                                                  client.Viber != null && client.Viber.Contains(searchText) ||
                                                  client.WhatsApp != null && client.WhatsApp.Contains(searchText) ||
                                                  client.Other != null && client.Other.Contains(searchText))
                .Select(client => new ClientVm
                {
                    Id = client.Id,
                    Name = client.Name,
                    Address = client.Address,
                    Phone = client.Phone,
                    Email = client.Email,
                    Facebook = client.Facebook,
                    Viber = client.Viber,
                    WhatsApp = client.WhatsApp,
                    Other = client.Other
                }).ToList();
            FillGrid();
        }

        private void FillGrid()
        {
            dgvClients.DataSource = ClientsList;
            btnEdit.Enabled = btnDelete.Enabled = ClientsList.Any();
        }

        private void EditClient()
        {
            var clientId = int.Parse(dgvClients.SelectedRows[0].Cells[0].Value.ToString());
            new FrmAddClient(clientId).ShowDialog();
            ResetForm();
        }

        private void DeleteClient()
        {
            var clientId = int.Parse(dgvClients.SelectedRows[0].Cells[0].Value.ToString());
            if (InvoiceManager.IsClientHasInvoices(clientId))
            {
                MessageBoxUtility.ShowErrorMsg(Resources.ClientNotDeletedDueToHisInvoices);
                return;
            }
            ClientManager.DeleteClient(clientId);
            ResetForm();
        }

        #endregion
    }
}