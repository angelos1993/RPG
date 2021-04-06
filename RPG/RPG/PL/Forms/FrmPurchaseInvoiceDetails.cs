using System;
using System.Globalization;
using RPG.BLL;
using RPG.Utility;

namespace RPG.PL.Forms
{
    public partial class FrmPurchaseInvoiceDetails : FrmMaster
    {
        #region Constructor

        public FrmPurchaseInvoiceDetails(int invoiceId)
        {
            InitializeComponent();
            ResetForm(invoiceId);
        }

        #endregion

        #region Properties

        private PurchaseInvoiceManager _purchaseInvoiceManager;

        private PurchaseInvoiceManager PurchaseInvoiceManager =>
            _purchaseInvoiceManager ?? (_purchaseInvoiceManager = new PurchaseInvoiceManager());
        private PurchaseInvoiceItemManager _purchaseInvoiceItemManager;

        private PurchaseInvoiceItemManager PurchaseInvoiceItemManager =>
            _purchaseInvoiceItemManager ?? (_purchaseInvoiceItemManager = new PurchaseInvoiceItemManager());

        private PurchaseInvoicePaymentManager _purchaseInvoicePaymentManager;

        private PurchaseInvoicePaymentManager PurchaseInvoicePaymentManager =>
            _purchaseInvoicePaymentManager ?? (_purchaseInvoicePaymentManager = new PurchaseInvoicePaymentManager());

        #endregion

        #region Events

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void ResetForm(int invoiceId)
        {
            var invoice = PurchaseInvoiceManager.GetPurchaseInvoiceById(invoiceId);
            lblSupplierName.Text = invoice.Supplier.Name;
            lblInvoiceDate.Text = invoice.Date.ToCustomShortDateString();
            dgvInvoiceItems.DataSource = PurchaseInvoiceItemManager.GetPurchaseInvoiceItems(invoice.Id);
            lblTotal.Text = invoice.Total.ToString(CultureInfo.InvariantCulture);
            lblPaid.Text = invoice.Paid.ToString(CultureInfo.InvariantCulture);
            lblDiscount.Text = invoice.Discount.ToString(CultureInfo.InvariantCulture);
            lblRemaining.Text =
                (invoice.Total - invoice.Paid - invoice.Discount).ToString(CultureInfo.InvariantCulture);
            dgvInvoicePayments.DataSource = PurchaseInvoicePaymentManager.GetPurchaseInvoicePayments(invoice.Id);
            dgvInvoiceItems.Columns[0].Visible = false;
        }

        #endregion
    }
}