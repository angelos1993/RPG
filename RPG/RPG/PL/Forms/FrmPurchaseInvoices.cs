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
    public partial class FrmPurchaseInvoices : FrmMaster
    {
        #region Constructor

        public FrmPurchaseInvoices()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private PurchaseInvoiceManager _purchaseInvoiceManager;

        private PurchaseInvoiceManager PurchaseInvoiceManager =>
            _purchaseInvoiceManager ?? (_purchaseInvoiceManager = new PurchaseInvoiceManager());

        private MaterialManager _materialManager;
        private MaterialManager MaterialManager => _materialManager ?? (_materialManager = new MaterialManager());
        private PurchaseInvoiceItemManager _purchaseInvoiceItemManager;

        private PurchaseInvoiceItemManager PurchaseInvoiceItemManager =>
            _purchaseInvoiceItemManager ?? (_purchaseInvoiceItemManager = new PurchaseInvoiceItemManager());

        private PurchaseInvoicePaymentManager _purchaseInvoicePaymentManager;

        private PurchaseInvoicePaymentManager PurchaseInvoicePaymentManager =>
            _purchaseInvoicePaymentManager ?? (_purchaseInvoicePaymentManager = new PurchaseInvoicePaymentManager());

        private List<PurchaseInvoice> PurchaseInvoices { get; set; }
        private List<PurchaseInvoiceVm> PurchaseInvoicesList { get; set; }

        #endregion

        #region Events

        private void FrmInvoices_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ResetForm();
            Cursor = Cursors.Default;
        }

        private void txtSupplierName_TextChanged(object sender, EventArgs e)
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
                new FrmPurchaseInvoiceDetails(int.Parse(dgvInvoices.SelectedRows[0].Cells[0].Value.ToString()))
                    .ShowDialog();
            Cursor = Cursors.Default;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ShowConfirmationDialog(Resources.DeleteInvoiceConfirmationMsg) == DialogResult.Yes)
            {
                if (dgvInvoices.Rows.Count > 0)
                {
                    var purchaseInvoiceId = int.Parse(dgvInvoices.SelectedRows[0].Cells[0].Value.ToString());
                    var purchaseInvoice = PurchaseInvoiceManager.GetPurchaseInvoiceById(purchaseInvoiceId);
                    var purchaseInvoiceItems = purchaseInvoice.PurchaseInvoiceItems.ToList();
                    MaterialManager.UpdateQuantitiesAfterDeletingPurchaseInvoice(purchaseInvoiceItems);
                    PurchaseInvoiceItemManager.DeletePurchaseInvoiceItems(purchaseInvoiceItems);
                    PurchaseInvoicePaymentManager.DeletePurchaseInvoicePayments(purchaseInvoice.PurchaseInvoicePayments
                        .ToList());
                    PurchaseInvoiceManager.DeletePurchaseInvoice(purchaseInvoice);
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
            PurchaseInvoices = PurchaseInvoiceManager.GetAllPurchaseInvoices()
                .OrderByDescending(invoice => invoice.Date).ToList();
        }

        private void FilterInvoices(object sender = null)
        {
            if (sender != null && !(sender as RadioButton)?.Checked == true)
                return;
            PurchaseInvoicesList = PurchaseInvoices.Select(invoice => new PurchaseInvoiceVm
            {
                InvoiceId = invoice.Id,
                Date = invoice.Date,
                SupplierName = invoice.Supplier.Name,
                Total = invoice.Total,
                Paid = invoice.Paid,
                Discount = invoice.Discount
            }).ToList();
            var txtSearch = txtSupplierName.Text.FullTrim();
            PurchaseInvoicesList = PurchaseInvoicesList.Where(invoiceVm => invoiceVm.SupplierName.Contains(txtSearch))
                .ToList();

            #region Filter by Invoide Date

            if (radThisDay.Checked)
                PurchaseInvoicesList = PurchaseInvoicesList
                    .Where(invoiceVm => invoiceVm.Date.Date == DateTime.Today.Date).ToList();
            else if (radThisMonth.Checked)
                PurchaseInvoicesList = PurchaseInvoicesList
                    .Where(invoiceVm => invoiceVm.Date.Month == DateTime.Today.Month).ToList();
            else if (radSpesificDate.Checked && dtInvoiceDate.Value != default)
                PurchaseInvoicesList = PurchaseInvoicesList
                    .Where(invoiceVm => invoiceVm.Date.Date == dtInvoiceDate.Value.Date).ToList();

            #endregion

            #region Filter by Invoice State

            if (radPaidInvoices.Checked)
                PurchaseInvoicesList = PurchaseInvoicesList.Where(invoiceVm => invoiceVm.IsPaid).ToList();
            else if (radRemainingInvoices.Checked)
                PurchaseInvoicesList = PurchaseInvoicesList.Where(invoiceVm => !invoiceVm.IsPaid).ToList();

            #endregion

            FillGrid();
        }

        private void FillGrid()
        {
            dgvInvoices.DataSource = PurchaseInvoicesList;
            btnDelete.Enabled = PurchaseInvoicesList?.Any() == true;
        }

        #endregion
    }
}