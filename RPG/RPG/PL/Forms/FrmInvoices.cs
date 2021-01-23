using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RPG.BLL;
using RPG.DAL.Model;
using RPG.DAL.VMs;
using RPG.Utility;
using static RPG.Utility.MessageBoxUtility;

namespace RPG.PL.Forms
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
        private MaterialManager _materialManager;
        private MaterialManager MaterialManager => _materialManager ?? (_materialManager = new MaterialManager());
        private InvoiceItemManager _invoiceItemManager;

        private InvoiceItemManager InvoiceItemManager =>
            _invoiceItemManager ?? (_invoiceItemManager = new InvoiceItemManager());

        private InvoicePaymentManager _invoicePaymentManager;

        private InvoicePaymentManager InvoicePaymentManager =>
            _invoicePaymentManager ?? (_invoicePaymentManager = new InvoicePaymentManager());

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
            if (dgvInvoices.Rows.Count > 0)
                new FrmInvoiceDetails(int.Parse(dgvInvoices.SelectedRows[0].Cells[0].Value.ToString())).ShowDialog();
            Cursor = Cursors.Default;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ShowConfirmationDialog(Resources.DeleteInvoiceConfirmationMsg) == DialogResult.Yes)
            {
                if (dgvInvoices.Rows.Count > 0)
                {
                    var invoiceId = int.Parse(dgvInvoices.SelectedRows[0].Cells[0].Value.ToString());
                    var invoice = InvoiceManager.GetInvoiceById(invoiceId);
                    var invoiceItems = invoice.InvoiceItems.ToList();
                    MaterialManager.UpdateQuantitiesAfterDeletingInvoice(invoiceItems);
                    InvoiceItemManager.DeleteInvoiceItems(invoiceItems);
                    InvoicePaymentManager.DeleteInvoicePayments(invoice.InvoicePayments.ToList());
                    InvoiceManager.DeleteInvoice(invoice);
                    ResetForm();
                }
            }
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
            else if (radSpesificDate.Checked && dtInvoiceDate.Value != default)
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
            btnDelete.Enabled = InvoicesList?.Any() == true;
        }

        #endregion
    }
}