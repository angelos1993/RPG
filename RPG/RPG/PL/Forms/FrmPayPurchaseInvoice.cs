using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RPG.BLL;
using RPG.DAL.Model;
using RPG.DAL.VMs;
using RPG.Utility;
using static RPG.Utility.MessageBoxUtility;

namespace RPG.PL.Forms
{
    public partial class FrmPayPurchaseInvoice : FrmMaster
    {
        #region Constructor

        public FrmPayPurchaseInvoice()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private SupplierManager _supplierManager;
        private SupplierManager SupplierManager => _supplierManager ?? (_supplierManager = new SupplierManager());
        private PurchaseInvoiceManager _purchaseInvoiceManager;

        private PurchaseInvoiceManager PurchaseInvoiceManager =>
            _purchaseInvoiceManager ?? (_purchaseInvoiceManager = new PurchaseInvoiceManager());
        private List<string> SuppliersNames { get; set; }
        private List<LightInvoiceVm> SupplierInvoices { get; set; }
        private PurchaseInvoicePaymentManager _purchaseInvoicePaymentManager;

        private PurchaseInvoicePaymentManager PurchaseInvoicePaymentManager =>
            _purchaseInvoicePaymentManager ?? (_purchaseInvoicePaymentManager = new PurchaseInvoicePaymentManager());

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

        private void dgvInvoices_DoubleClick(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            new FrmInvoiceDetails(int.Parse(dgvInvoices.SelectedRows[0].Cells[0].Value.ToString())).ShowDialog();
            Cursor = Cursors.Default;
        }

        private void dblInTotal_ValueChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            dblInPaid.MaxValue = dblInTotal.Value;
            dblInPaid.Value = 0;
            dblInPaid.Enabled = dblInTotal.Value > 0;
            dblInRemaining.Value = dblInTotal.Value - dblInPaid.Value;
            Cursor = Cursors.Default;
        }

        private void dblInPaid_ValueChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            dblInRemaining.Value = dblInTotal.Value - dblInPaid.Value;
            btnPay.Enabled = dblInPaid.Value > 0;
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
            SetAutocompleteForSuppliers();
            txtSupplierName.Focus();
        }

        private void SetAutocompleteForSuppliers()
        {
            SuppliersNames= SupplierManager.GetAllSuppliersNames();
            TextBoxAutoCompleteUtility.SetAutoCompleteSourceForTextBox(txtSupplierName, SuppliersNames);
        }

        private void ShowInvoices()
        {
            var isFormValid = true;
            if (!SuppliersNames.Contains(txtSupplierName.Text.FullTrim()))
            {
                isFormValid = false;
                ShowErrorMsg(Resources.MakeSureOfSupplierName);
            }
            if (!isFormValid)
                return;
            SupplierInvoices= PurchaseInvoiceManager
                .GetSupplierRemainingInvoices(SupplierManager.GetSupplierIdByName(txtSupplierName.Text.FullTrim()))
                .OrderBy(invoice => invoice.Date).ToList();
            if (SupplierInvoices.Any())
            {
                FillGrid();
            }
            else
            {
                ShowInfoMsg(Resources.SupplierHasNoRemainingInvoices);
                dblInTotal.Value = 0;
            }
        }

        private void FillGrid()
        {
            dgvInvoices.DataSource = SupplierInvoices;
            dgvInvoices.Columns[0].Visible = false;
            dblInTotal.Value = SupplierInvoices.Sum(invoice => (double) invoice.Remaining);
        }

        private void Pay()
        {
            var enteredAmount = (decimal) dblInPaid.Value;
            var paidInvoices = new List<KeyValuePair<DateTime, decimal>>();
            foreach (var invoice in SupplierInvoices)
            {
                if (enteredAmount <= 0)
                    break;
                var paid = invoice.Remaining <= enteredAmount ? invoice.Remaining : enteredAmount;
                PurchaseInvoicePaymentManager.AddPurchaseInvoicePayment(new PurchaseInvoicePayment
                {
                    Date = dtPaymentDate.Value,
                    InvoiceId = invoice.InvoiceId,
                    Paid = paid
                });
                paidInvoices.Add(new KeyValuePair<DateTime, decimal>(invoice.Date, paid));
                PurchaseInvoiceManager.UpdatePurchaseInvoicePaidAmount(invoice.InvoiceId, paid);
                enteredAmount -= paid;
            }
            ShowSuccessMsg(paidInvoices, (decimal) dblInRemaining.Value);
        }

        private void ShowSuccessMsg(List<KeyValuePair<DateTime, decimal>> paidInvoices, decimal remaining)
        {
            var msg = new StringBuilder($"{Environment.NewLine}تم الدفع للفواتير الآتية{Environment.NewLine}");
            foreach (var item in paidInvoices)
                msg.AppendLine($"{item.Value} : {item.Key.ToCustomShortDateString()}\n");
            msg.AppendLine($"{remaining} : المتبقي");
            ShowInfoMsg(msg.ToString());
            Close();
        }

        #endregion
    }
}