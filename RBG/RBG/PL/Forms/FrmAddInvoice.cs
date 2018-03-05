using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RBG.BLL;
using RBG.DAL.Model;
using RBG.DAL.VMs;
using RBG.Utility;
using static RBG.Utility.TextBoxAutoCompleteUtility;
using static RBG.Utility.MessageBoxUtility;

namespace RBG.PL.Forms
{
    public partial class FrmAddInvoice : FrmMaster
    {
        #region Constructor

        public FrmAddInvoice()
        {
            InitializeComponent();
            InvoiceItemVms = new List<InvoiceItemVm>();
        }

        #endregion

        #region Properties

        private ClientManager _clientManager;
        private ClientManager ClientManager => _clientManager ?? (_clientManager = new ClientManager());
        private MaterialManager _materialManager;
        private MaterialManager MaterialManager => _materialManager ?? (_materialManager = new MaterialManager());
        private InvoiceManager _invoiceManager;
        private InvoiceManager InvoiceManager => _invoiceManager ?? (_invoiceManager = new InvoiceManager());
        private InvoiceItemManager _invoiceItemManager;

        private InvoiceItemManager InvoiceItemManager =>
            _invoiceItemManager ?? (_invoiceItemManager = new InvoiceItemManager());

        private InvoicePaymentManager _invoicePaymentManager;

        private InvoicePaymentManager InvoicePaymentManager =>
            _invoicePaymentManager ?? (_invoicePaymentManager = new InvoicePaymentManager());

        private List<Material> Materials { get; set; }
        private List<LightMaterialVm> MaterialsList { get; set; }
        private List<InvoiceItemVm> InvoiceItemVms { get; }
        private List<string> ClientsNames { get; set; }

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

        private void cmbMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SetAvailableQuantity();
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
            dblInPaid.Enabled = dblInDiscount.Enabled = dblInTotal.Value > 0;
            dblInPaid.Value = dblInPaid.Value > dblInTotal.Value ? dblInTotal.Value : dblInPaid.Value;
            dblInDiscount.MaxValue = dblInTotal.Value;
            dblInPaid.MaxValue = dblInTotal.Value;
            SetDiscountAndRemainingValue();
            Cursor = Cursors.Default;
        }

        private void dblInPaid_ValueChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SetDiscountAndRemainingValue();
            Cursor = Cursors.Default;
        }

        private void dblInDiscount_ValueChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SetDiscountAndRemainingValue();
            Cursor = Cursors.Default;
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DeleteItem();
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

        private void ResetForm()
        {
            dtInvoiceDate.Value = DateTime.Today;
            SetAutocompletForClients();
            FillMaterials();
        }

        private void SetAutocompletForClients()
        {
            ClientsNames = ClientManager.GetAllClientsNames();
            SetAutoCompleteSourceForTextBox(txtClientName, ClientsNames);
        }

        private void FillMaterials()
        {
            Materials = MaterialManager.GetAllUnArchivedMaterials().Where(material => material.Quantity > 0).ToList();
            MaterialsList = Materials.Select(material => new LightMaterialVm
            {
                Id = material.Id,
                Name = material.Name,
                Price = material.Price,
                AvailableQuantity = material.Quantity
            }).ToList();
            var materialsList = Materials.Select(material => new KeyValuePair<int, string>(material.Id, material.Name))
                .OrderBy(keyValuePair => keyValuePair.Value).ToList();
            materialsList.Insert(0, new KeyValuePair<int, string>(0, Resources.ComboBoxDefaultText));
            cmbMaterials.DataSource = materialsList;
            cmbMaterials.DisplayMember = "Value";
            cmbMaterials.ValueMember = "Key";
        }

        private void InsertItem()
        {
            ErrorProvider.Clear();
            var isFormValid = true;
            if (cmbMaterials.SelectedIndex == 0)
            {
                isFormValid = false;
                ErrorProvider.SetError(cmbMaterials, Resources.ShouldSelectMaterial);
            }
            if (Math.Abs(dblInQuantity.Value) <= 0)
            {
                isFormValid = false;
                ErrorProvider.SetError(dblInQuantity, Resources.ThisFieldIsRequired);
            }
            if (!isFormValid)
                return;
            var addedQuantity = (decimal) dblInQuantity.Value;
            var materialId = int.Parse(cmbMaterials.SelectedValue.ToString());
            if (InvoiceItemVms.Exists(item => item.MaterialId == materialId))
            {
                var invoiceItem = InvoiceItemVms.Find(item => item.MaterialId == materialId);
                invoiceItem.Quantity += addedQuantity;
                invoiceItem.TotalPrice = GetMaterialPrice(materialId) * invoiceItem.Quantity;
            }
            else
                InvoiceItemVms.Add(new InvoiceItemVm
                {
                    MaterialId = materialId,
                    MaterialName = ((KeyValuePair<int, string>) cmbMaterials.SelectedItem).Value,
                    Quantity = addedQuantity,
                    TotalPrice = GetMaterialPrice(materialId) * addedQuantity
                });
            MaterialsList.Find(material => material.Id == materialId).AvailableQuantity -= addedQuantity;
            FillGrid();
            SetTotalPrice();
            ResetInsertControls();
        }

        private void ResetInsertControls()
        {
            cmbMaterials.SelectedIndex = 0;
            dblInQuantity.Value = 0;
        }

        private decimal GetMaterialPrice(int materialId)
        {
            return Materials.Where(material => material.Id == materialId)
                .Select(material => material.Price).FirstOrDefault();
        }

        private void FillGrid()
        {
            dgvInvoiceItems.DataSource = null;
            dgvInvoiceItems.DataSource = InvoiceItemVms;
            dgvInvoiceItems.Columns[0].Visible = false;
            btnDeleteItem.Enabled = InvoiceItemVms.Any();
        }

        private void DeleteItem()
        {
            var materialId = int.Parse(dgvInvoiceItems.SelectedRows[0].Cells[0].Value.ToString());
            var deletedMaterialQuantity = decimal.Parse(dgvInvoiceItems.SelectedRows[0].Cells["Quantity"].Value
                .ToString());
            InvoiceItemVms.Remove(InvoiceItemVms.Find(item => item.MaterialId == materialId));
            MaterialsList.Find(material => material.Id == materialId).AvailableQuantity += deletedMaterialQuantity;
            FillGrid();
            SetTotalPrice();
            ResetInsertControls();
        }

        private void SaveInvoice()
        {
            ErrorProvider.Clear();
            var isFormValid = true;
            if (txtClientName.Text.IsNullOrEmptyOrWhiteSpace())
            {
                isFormValid = false;
                ErrorProvider.SetError(txtClientName, Resources.ThisFieldIsRequired);
            }
            else if (!ClientsNames.Contains(txtClientName.Text.FullTrim()))
            {
                isFormValid = ShowConfirmationDialog(Resources.ClientNotExists) == DialogResult.Yes;
                ClientManager.AddClient(new Client {Name = txtClientName.Text.FullTrim()});
            }
            if (!InvoiceItemVms.Any())
            {
                isFormValid = false;
                ShowErrorMsg(Resources.InvoiceWithoutItems);
            }
            if (!isFormValid)
                return;
            if (!InvoiceItemVms.Any())
            {
                ShowErrorMsg(Resources.NoItemsAdded);
                return;
            }
            var invoice = new Invoice
            {
                ClientId = ClientManager.GetClientIdByName(txtClientName.Text.FullTrim()),
                Date = dtInvoiceDate.Value,
                Total = (decimal) dblInTotal.Value,
                Paid = (decimal) dblInPaid.Value,
                Discount = (decimal) dblInDiscount.Value
            };
            InvoiceManager.AddInvoice(invoice);
            InvoiceItemManager.AddInvoiceItems(InvoiceItemVms.Select(item => new InvoiceItem
            {
                InvoiceId = invoice.Id,
                MaterialId = item.MaterialId,
                Quantity = item.Quantity,
                Price = item.TotalPrice
            }).ToList());
            if (invoice.Paid > 0)
                InvoicePaymentManager.AddInvoicePayment(new InvoicePayment
                {
                    InvoiceId = invoice.Id,
                    Date = dtInvoiceDate.Value,
                    Paid = (decimal) dblInPaid.Value
                });
            MaterialManager.UpdateQuantitiesAfterCreatingInvoice(InvoiceItemVms);
            ShowInfoMsg(Resources.InvoiceCreatedSuccessfully);
            Close();
        }

        private void SetTotalPrice()
        {
            dblInTotal.Value = (double) InvoiceItemVms.Select(item => item.TotalPrice).Sum();
        }

        private void SetAvailableQuantity()
        {
            if (cmbMaterials.SelectedIndex == 0)
            {
                lblMaterialAvailableQuantity.Text = string.Empty;
                return;
            }
            var selectedMaterial =
                MaterialsList.FirstOrDefault(
                    material => material.Id == int.Parse(cmbMaterials.SelectedValue.ToString()));
            if (selectedMaterial == null)
                return;
            lblMaterialAvailableQuantity.Text =
                string.Format(Resources.MaterialAvailableQuantity, selectedMaterial.AvailableQuantity);
            dblInQuantity.MaxValue = (double) selectedMaterial.AvailableQuantity;
        }

        private void SetDiscountAndRemainingValue()
        {
            dblInDiscount.MaxValue = dblInTotal.Value - dblInPaid.Value;
            dblInRemaining.Value = dblInTotal.Value - dblInDiscount.Value - dblInPaid.Value;
        }

        #endregion
    }
}