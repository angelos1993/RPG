using System;
using System.Globalization;
using RBG.BLL;
using RBG.Utility;

namespace RBG.PL.Forms
{
    public partial class FrmInvoiceDetails : FrmMaster
    {
        #region Constructor

        public FrmInvoiceDetails(int invoiceId)
        {
            InitializeComponent();
            ResetForm(invoiceId);
        }

        #endregion

        #region Properties

        private InvoiceManager _invoiceManager;
        private InvoiceManager InvoiceManager => _invoiceManager ?? (_invoiceManager = new InvoiceManager());
        private InvoiceItemManager _invoiceItemManager;

        private InvoiceItemManager InvoiceItemManager =>
            _invoiceItemManager ?? (_invoiceItemManager = new InvoiceItemManager());

        private InvoicePaymentManager _invoicePaymentManager;

        private InvoicePaymentManager InvoicePaymentManager =>
            _invoicePaymentManager ?? (_invoicePaymentManager = new InvoicePaymentManager());

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
            var invoice = InvoiceManager.GetInvoiceById(invoiceId);
            lblClientName.Text = invoice.Client.Name;
            lblInvoiceDate.Text = invoice.Date.ToCustomShortDateString();
            dgvInvoiceItems.DataSource = InvoiceItemManager.GetInvoiceItems(invoice.Id);
            lblTotal.Text = invoice.Total.ToString(CultureInfo.InvariantCulture);
            lblPaid.Text = invoice.Paid.ToString(CultureInfo.InvariantCulture);
            lblDiscount.Text = invoice.Discount.ToString(CultureInfo.InvariantCulture);
            lblRemaining.Text =
                (invoice.Total - invoice.Paid - invoice.Discount).ToString(CultureInfo.InvariantCulture);
            dgvInvoicePayments.DataSource = InvoicePaymentManager.GetInvoicePayments(invoice.Id);
            dgvInvoiceItems.Columns[0].Visible = false;
        }

        #endregion
    }
}