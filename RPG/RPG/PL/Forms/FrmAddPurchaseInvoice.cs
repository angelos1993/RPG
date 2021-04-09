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
    public partial class FrmAddPurchaseInvoice : FrmMaster
    {
        #region Constructor

        public FrmAddPurchaseInvoice()
        {
            InitializeComponent();
            PurchaseInvoiceItemVms = new List<PurchaseInvoiceItemVm>();
        }

        #endregion

        #region Properties

        private SupplierManager _supplierManager;
        private SupplierManager SupplierManager => _supplierManager ?? (_supplierManager = new SupplierManager());
        private MaterialManager _materialManager;
        private MaterialManager MaterialManager => _materialManager ?? (_materialManager = new MaterialManager());
        private PurchaseInvoiceManager _purchaseInvoiceManager;

        private PurchaseInvoiceManager PurchaseInvoiceManager =>
            _purchaseInvoiceManager ?? (_purchaseInvoiceManager = new PurchaseInvoiceManager());

        private PurchaseInvoiceItemManager _purchaseInvoiceItemManager;

        private PurchaseInvoiceItemManager PurchaseInvoiceItemManager =>
            _purchaseInvoiceItemManager ?? (_purchaseInvoiceItemManager = new PurchaseInvoiceItemManager());

        private PurchaseInvoicePaymentManager _purchaseInvoicePaymentManager;

        private PurchaseInvoicePaymentManager PurchaseInvoicePaymentManager =>
            _purchaseInvoicePaymentManager ?? (_purchaseInvoicePaymentManager = new PurchaseInvoicePaymentManager());

        private List<Material> Materials { get; set; }
        private List<LightMaterialVm> MaterialsList { get; set; }
        private List<PurchaseInvoiceItemVm> PurchaseInvoiceItemVms { get; }
        private List<string> SuppliersNames { get; set; }

        #endregion

        #region Events

        private void FrmAddPurchaseInvoice_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ResetForm();
            Cursor = Cursors.Default;
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            new FrmAddSupplier().ShowDialog();
            SetAutocompleteForSuppliers();
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
            SavePurchaseInvoice();
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
            SetAutocompleteForSuppliers();
            FillMaterials();
            txtSupplierName.Focus();
        }

        private void SetAutocompleteForSuppliers()
        {
            SuppliersNames = SupplierManager.GetAllSuppliersNames();
            TextBoxAutoCompleteUtility.SetAutoCompleteSourceForTextBox(txtSupplierName, SuppliersNames);
        }

        private void FillMaterials()
        {
            Materials = MaterialManager.GetAllUnArchivedMaterials().Where(material => material.Quantity > 0).ToList();
            MaterialsList = Materials.Select(material => new LightMaterialVm
            {
                Id = material.Id,
                Code = material.Code,
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
            if (Math.Abs(dblInUnitPrice.Value) <= 0)
            {
                isFormValid = false;
                ErrorProvider.SetError(dblInUnitPrice, Resources.ThisFieldIsRequired);
            }
            if (!isFormValid)
                return;
            var unitPrice = (decimal) dblInUnitPrice.Value;
            var addedQuantity = (decimal) dblInQuantity.Value;
            var materialId = int.Parse(cmbMaterials.SelectedValue.ToString());
            if (PurchaseInvoiceItemVms.Exists(item => item.MaterialId == materialId))
            {
                var purchaseInvoiceItem = PurchaseInvoiceItemVms.Find(item => item.MaterialId == materialId);
                purchaseInvoiceItem.Quantity += addedQuantity;
            }
            else
                PurchaseInvoiceItemVms.Add(new PurchaseInvoiceItemVm
                {
                    MaterialId = materialId,
                    MaterialCode = MaterialsList.FirstOrDefault(material => material.Id == materialId)?.Code,
                    MaterialName = ((KeyValuePair<int, string>) cmbMaterials.SelectedItem).Value,
                    UnitPrice = unitPrice,
                    Quantity = addedQuantity,
                    Notes = txtNotes.Text.FullTrim()
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
            dblInUnitPrice.Value = 0;
        }
        
        private void FillGrid()
        {
            dgvInvoiceItems.DataSource = null;
            dgvInvoiceItems.DataSource = PurchaseInvoiceItemVms;
            dgvInvoiceItems.Columns[0].Visible = false;
            btnDeleteItem.Enabled = PurchaseInvoiceItemVms.Any();
        }

        private void DeleteItem()
        {
            var materialId = int.Parse(dgvInvoiceItems.SelectedRows[0].Cells[0].Value.ToString());
            var deletedMaterialQuantity = decimal.Parse(dgvInvoiceItems.SelectedRows[0].Cells["Quantity"].Value
                .ToString());
            PurchaseInvoiceItemVms.Remove(PurchaseInvoiceItemVms.Find(item => item.MaterialId == materialId));
            MaterialsList.Find(material => material.Id == materialId).AvailableQuantity += deletedMaterialQuantity;
            FillGrid();
            SetTotalPrice();
            ResetInsertControls();
        }

        private void SavePurchaseInvoice()
        {
            ErrorProvider.Clear();
            var isFormValid = true;
            Supplier newSupplier = null;
            if (txtSupplierName.Text.IsNullOrEmptyOrWhiteSpace())
            {
                isFormValid = false;
                ErrorProvider.SetError(txtSupplierName, Resources.ThisFieldIsRequired);
            }
            else if (!SuppliersNames.Contains(txtSupplierName.Text.FullTrim()))
            {
                isFormValid = ShowConfirmationDialog(Resources.SupplierNotExists) == DialogResult.Yes;
                newSupplier = new Supplier {Name = txtSupplierName.Text.FullTrim()};
            }

            if (!PurchaseInvoiceItemVms.Any())
            {
                isFormValid = false;
                ShowErrorMsg(Resources.InvoiceWithoutItems);
            }

            if (!isFormValid)
                return;
            if (!PurchaseInvoiceItemVms.Any())
            {
                ShowErrorMsg(Resources.NoItemsAdded);
                return;
            }

            if (newSupplier != null)
            {
                SupplierManager.AddSupplier(newSupplier);
            }

            var purchaseInvoice = new PurchaseInvoice
            {
                SupplierId = SupplierManager.GetSupplierIdByName(txtSupplierName.Text.FullTrim()),
                Date = dtInvoiceDate.Value,
                Total = (decimal) dblInTotal.Value,
                Paid = (decimal) dblInPaid.Value,
                Discount = (decimal) dblInDiscount.Value
            };
            PurchaseInvoiceManager.AddPurchaseInvoice(purchaseInvoice);
            PurchaseInvoiceItemManager.AddPurchaseInvoiceItems(PurchaseInvoiceItemVms.Select(item =>
                new PurchaseInvoiceItem
                {
                    InvoiceId = purchaseInvoice.Id,
                    MaterialId = item.MaterialId,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice,
                    Notes = item.Notes
                }).ToList());
            if (purchaseInvoice.Paid > 0)
                PurchaseInvoicePaymentManager.AddPurchaseInvoicePayment(new PurchaseInvoicePayment
                {
                    InvoiceId = purchaseInvoice.Id,
                    Date = dtInvoiceDate.Value,
                    Paid = (decimal) dblInPaid.Value
                });
            MaterialManager.UpdateQuantitiesAfterCreatingPurchaseInvoice(PurchaseInvoiceItemVms);
            ShowInfoMsg(Resources.InvoiceCreatedSuccessfully);
            Close();
        }

        private void SetTotalPrice()
        {
            dblInTotal.Value = (double) PurchaseInvoiceItemVms.Select(item => item.TotalPrice).Sum();
        }

        private void SetDiscountAndRemainingValue()
        {
            dblInDiscount.MaxValue = dblInTotal.Value - dblInPaid.Value;
            dblInRemaining.Value = dblInTotal.Value - dblInDiscount.Value - dblInPaid.Value;
        }

        #endregion
    }
}