using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RBG.BLL;
using RBG.DAL.Model;
using RBG.DAL.VMs;
using RBG.Utility;
using static RBG.Utility.MessageBoxUtility;

namespace RBG.PL.Forms
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
            if (ShowConfirmationDialog("هل أنت متأكد من أنك تريد حذف هذه المادة / الخامة ؟") != DialogResult.Yes)
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
                Phone = client.Phone
            }).ToList();
        }

        private void SearchClients()
        {
            var searchText = txtSearch.Text.FullTrim();
            ClientsList = Clients
                .Where(client => client.Name.Contains(searchText) ||
                                 client.Address.Contains(searchText) || client.Phone.Contains(searchText))
                .Select(client => new ClientVm
                {
                    Id = client.Id,
                    Name = client.Name,
                    Address = client.Address,
                    Phone = client.Phone
                }).ToList();
            FillGrid();
        }

        private void FillGrid()
        {
            dgvClients.DataSource = ClientsList;
        }

        private void EditClient()
        {
            var clientId = int.Parse(dgvClients.SelectedRows[0].Cells[0].Value.ToString());
            new FrmAddClient(clientId).ShowDialog();
            ResetForm();
        }

        private void DeleteClient()
        {
            ClientManager.DeleteClient(int.Parse(dgvClients.SelectedRows[0].Cells[0].Value.ToString()));
            ResetForm();
        }

        #endregion
    }
}