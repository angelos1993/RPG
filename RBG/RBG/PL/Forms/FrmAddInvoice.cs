using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RBG.BLL;
using RBG.DAL.Model;
using static RBG.Utility.Utility;

namespace RBG.PL.Forms
{
    public partial class FrmAddInvoice : FrmMaster
    {
        #region Constructor

        public FrmAddInvoice()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private ClientManager _clientManager;
        private ClientManager ClientManager => _clientManager ?? (_clientManager = new ClientManager());
        private MaterialManager _materialManager;
        private MaterialManager MaterialManager => _materialManager ?? (_materialManager = new MaterialManager());
        private List<Material> Materials { get; set; }

        #endregion

        #region Events

        private void FrmAddInvoice_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ResetForm();
            Cursor = Cursors.Default;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            new FrmAddClient().ShowDialog();
            SetAutocompletForClients();
            Cursor = Cursors.Default;
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            new FrmAddMaterial().ShowDialog();
            FillMaterials();
            Cursor = Cursors.Default;
        }

        private void btnInsertItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            InsertItem();
            Cursor = Cursors.Default;
        }

        private void dblInTotal_ValueChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            AdjustDoubleInputsValues();
            Cursor = Cursors.Default;
        }

        private void dblInPaid_ValueChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            AdjustDoubleInputsValues();
            Cursor = Cursors.Default;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SaveInvoice();
            Cursor = Cursors.Default;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        public void ResetForm()
        {
            dtInvoiceDate.Value = DateTime.Today;
            SetAutocompletForClients();
            FillMaterials();
        }

        public void SetAutocompletForClients()
        {
            var collection = new AutoCompleteStringCollection();
            collection.AddRange(ClientManager.GetAllClientsNames().ToArray());
            SetAutoCompleteSourceForTextBox(txtClientName,collection);
        }

        public void FillMaterials()
        {
            Materials = MaterialManager.GetAllMaterials().ToList();
            cmbMaterials.DataSource = Materials;
            cmbMaterials.DisplayMember = "Name";
            cmbMaterials.ValueMember= "Id";
        }

        public void InsertItem()
        {   
        }

        public void AdjustDoubleInputsValues()
        {
            dblInPaid.Enabled = dblInTotal.Value > 0;
            dblInPaid.Value = dblInPaid.Value > dblInTotal.Value ? dblInTotal.Value : dblInPaid.Value;
            dblInPaid.MaxValue = dblInTotal.Value;
            dblInRemaining.Value = dblInTotal.Value - dblInPaid.Value;
        }

        private void SaveInvoice()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}