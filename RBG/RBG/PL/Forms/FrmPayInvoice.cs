using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RBG.BLL;
using RBG.DAL.Model;
using RBG.Utility;
using static RBG.Utility.TextBoxAutoCompleteUtility;
using static RBG.Utility.MessageBoxUtility;

namespace RBG.PL.Forms
{
    public partial class FrmPayInvoice : FrmMaster
    {
        #region Constructor

        public FrmPayInvoice()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private ClientManager _clientManager;
        private ClientManager ClientManager => _clientManager ?? (_clientManager = new ClientManager());
        private InvoiceManager _invoiceManager;
        private InvoiceManager InvoiceManager => _invoiceManager ?? (_invoiceManager = new InvoiceManager());
        private List<string> ClientsNames { get; set; }
        private List<Invoice> ClientInvoices { get; set; }

        #endregion

        #region Events

        private void FrmPayInvoice_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ResetForm();
            Cursor = Cursors.Default;
        }

        private void btnShowInvoices_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ShowInvoices();
            Cursor = Cursors.Default;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Pay();
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
            dtPaymentDate.Value = DateTime.Today;
            SetAutocompletForClients();
        }

        private void SetAutocompletForClients()
        {
            ClientsNames = ClientManager.GetAllClientsNames();
            SetAutoCompleteSourceForTextBox(txtClientName, ClientsNames);
        }

        private void ShowInvoices()
        {
            var isFormValid = true;
            //validate the enterded client name before get invoices
            if (!ClientsNames.Contains(txtClientName.Text.FullTrim()))
            {
                isFormValid = false;
                ShowErrorMsg(Resources.MakeSureOfClientName);
            }
            if (!isFormValid)
                return;
            //get all invoices for the entered client
            ClientInvoices = InvoiceManager
                .GetClientInvoices(ClientManager.GetClientIdByName(txtClientName.Text.FullTrim()))
                .OrderBy(invoice => invoice.Date).ToList();
            //fill the grid
            FillGrid();
            //set the max value of the paid input by the total
        }

        private void FillGrid()
        {
            dgvInvoices.DataSource = ClientInvoices;
        }

        private void Pay()
        {
             //validate the entered amount before pay
        }

        #endregion
    }
}