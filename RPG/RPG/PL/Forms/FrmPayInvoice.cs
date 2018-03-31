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
        private List<LightInvoiceVm> ClientInvoices { get; set; }
        private InvoicePaymentManager _invoicePaymentManager;

        private InvoicePaymentManager InvoicePaymentManager => _invoicePaymentManager ??
                                                               (_invoicePaymentManager = new InvoicePaymentManager());

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
            SetAutocompletForClients();
            txtClientName.Focus();
        }

        private void SetAutocompletForClients()
        {
            ClientsNames = ClientManager.GetAllClientsNames();
            TextBoxAutoCompleteUtility.SetAutoCompleteSourceForTextBox(txtClientName, ClientsNames);
        }

        private void ShowInvoices()
        {
            var isFormValid = true;
            if (!ClientsNames.Contains(txtClientName.Text.FullTrim()))
            {
                isFormValid = false;
                ShowErrorMsg(Resources.MakeSureOfClientName);
            }
            if (!isFormValid)
                return;
            ClientInvoices = InvoiceManager
                .GetClientRemainingInvoices(ClientManager.GetClientIdByName(txtClientName.Text.FullTrim()))
                .OrderBy(invoice => invoice.Date).ToList();
            if (ClientInvoices.Any())
            {
                FillGrid();
            }
            else
            {
                ShowInfoMsg(Resources.ClientHasNoRemainingInvoices);
                dblInTotal.Value = 0;
            }
        }

        private void FillGrid()
        {
            dgvInvoices.DataSource = ClientInvoices;
            dgvInvoices.Columns[0].Visible = false;
            dblInTotal.Value = ClientInvoices.Sum(invoice => (double) invoice.Remaining);
        }

        private void Pay()
        {
            var enteredAmount = (decimal) dblInPaid.Value;
            var paidInvoices = new List<KeyValuePair<DateTime, decimal>>();
            foreach (var invoice in ClientInvoices)
            {
                if (enteredAmount <= 0)
                    break;
                var paid = invoice.Remaining <= enteredAmount ? invoice.Remaining : enteredAmount;
                InvoicePaymentManager.AddInvoicePayment(new InvoicePayment
                {
                    Date = dtPaymentDate.Value,
                    InvoiceId = invoice.InvoiceId,
                    Paid = paid
                });
                paidInvoices.Add(new KeyValuePair<DateTime, decimal>(invoice.Date, paid));
                InvoiceManager.UpdateInvoicePaidAmount(invoice.InvoiceId, paid);
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