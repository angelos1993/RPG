using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RBG.BLL;
using RBG.DAL.Model;
using RBG.DAL.VMs;
using RBG.Utility;

namespace RBG.PL.Forms
{
    public partial class FrmInvoices : FrmMaster
    {
        #region Constructor

        public FrmInvoices()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private InvoiceManager _invoiceManager;
        private InvoiceManager InvoiceManager => _invoiceManager ?? (_invoiceManager = new InvoiceManager());
        private List<Invoice> Invoices { get; set; }
        private List<InvoiceVm> InvoicesList { get; set; }

        #endregion

        #region Events

        private void FrmInvoices_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ResetForm();
            Cursor = Cursors.Default;
        }

        private void txtClientName_TextChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FilterInvoices(sender);
            Cursor = Cursors.Default;
        }

        private void radInvoiceDate_CheckedChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FilterInvoices(sender);
            Cursor = Cursors.Default;
        }

        private void dtInvoiceDate_ValueChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (radSpesificDate.Checked)
            {
                radInvoiceDate_CheckedChanged(radSpesificDate, new EventArgs());
                return;
            }
            radSpesificDate.Checked = true;
            Cursor = Cursors.Default;
        }

        private void radInvoiceState_CheckedChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FilterInvoices(sender);
            Cursor = Cursors.Default;
        }

        private void dgvInvoices_DoubleClick(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            new FrmInvoiceDetails(int.Parse(dgvInvoices.SelectedRows[0].Cells[0].Value.ToString())).ShowDialog();
            Cursor = Cursors.Default;
        }

        #endregion

        #region Methods

        private void ResetForm()
        {
            GetInvoices();
            FilterInvoices();
            dgvInvoices.Columns[0].Visible = false;
        }

        private void GetInvoices()
        {
            Invoices = InvoiceManager.GetAllInvoices().OrderByDescending(invoice => invoice.Date).ToList();
        }

        private void FilterInvoices(object sender = null)
        {
            if (sender != null && !(sender as RadioButton)?.Checked == true)
                return;
            InvoicesList = Invoices.Select(invoice => new InvoiceVm
            {
                InvoiceId = invoice.Id,
                Date = invoice.Date,
                ClientName = invoice.Client.Name,
                Total = invoice.Total,
                Paid = invoice.Paid,
                Discount = invoice.Discount
            }).ToList();
            var txtSearch = txtClientName.Text.FullTrim();
            InvoicesList = InvoicesList.Where(invoiceVm => invoiceVm.ClientName.Contains(txtSearch)).ToList();

            #region Filter by Invoide Date

            if (radThisDay.Checked)
                InvoicesList = InvoicesList.Where(invoiceVm => invoiceVm.Date.Date == DateTime.Today.Date).ToList();
            else if (radThisMonth.Checked)
                InvoicesList = InvoicesList.Where(invoiceVm => invoiceVm.Date.Month == DateTime.Today.Month).ToList();
            else if (radSpesificDate.Checked && dtInvoiceDate.Value != default(DateTime))
                InvoicesList = InvoicesList.Where(invoiceVm => invoiceVm.Date.Date == dtInvoiceDate.Value.Date).ToList();

            #endregion

            #region Filter by Invoice State

            if (radPaidInvoices.Checked)
                InvoicesList = InvoicesList.Where(invoiceVm => invoiceVm.IsPaid).ToList();
            else if (radRemainingInvoices.Checked)
                InvoicesList = InvoicesList.Where(invoiceVm => !invoiceVm.IsPaid).ToList();

            #endregion

            FillGrid();
        }

        private void FillGrid()
        {
            dgvInvoices.DataSource = InvoicesList;
        }

        #endregion
    }
}