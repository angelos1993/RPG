using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RPG.BLL;
using RPG.DAL.Model;
using RPG.DAL.VMs;
using RPG.Utility;
using RPG.Utility.Enums;
using static RPG.Utility.MessageBoxUtility;

namespace RPG.PL.Forms
{
    public partial class FrmSuppliers : FrmMaster
    {
        #region Constructor

        public FrmSuppliers()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private SupplierManager _supplierManager;
        private SupplierManager SupplierManager => _supplierManager?? (_supplierManager= new SupplierManager());
        private PurchaseInvoiceManager _purchaseInvoiceManager;
        private PurchaseInvoiceManager PurchaseInvoiceManager=> _purchaseInvoiceManager ?? (_purchaseInvoiceManager = new PurchaseInvoiceManager());
        private List<Supplier> Suppliers{ get; set; }
        private List<PersonVm> SuppliersList { get; set; }

        #endregion

        #region Events

        private void FrmSuppliers_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ResetForm();
            Cursor = Cursors.Default;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SearchSuppliers();
            Cursor = Cursors.Default;
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            new FrmAddSupplier().ShowDialog();
            ResetForm();
            Cursor = Cursors.Default;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            EditSupplier();
            Cursor = Cursors.Default;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ShowConfirmationDialog(Resources.DeleteSupplierConfirmationMsg, DialogDefaultButton.No) !=
                DialogResult.Yes)
                return;
            Cursor = Cursors.WaitCursor;
            DeleteSupplier();
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
            GetSuppliers();
            SearchSuppliers();
            dgvSuppliers.Columns[0].Visible = false;
            txtSearch.Focus();
        }

        private void GetSuppliers()
        {
            Suppliers = SupplierManager.GetAllSuppliers().OrderBy(supplier => supplier.Name).ToList();
            SuppliersList = Suppliers.Select(supplier => new PersonVm
            {
                Id = supplier.Id,
                Name = supplier.Name,
                Address = supplier.Address,
                Phone = supplier.Phone,
                Email = supplier.Email,
                Facebook = supplier.Facebook,
                Viber = supplier.Viber,
                WhatsApp = supplier.WhatsApp,
                Other = supplier.Other
            }).ToList();
        }

        private void SearchSuppliers()
        {
            var searchText = txtSearch.Text.FullTrim();
            SuppliersList = Suppliers.Where(supplier => supplier.Name != null && supplier.Name.Contains(searchText)
                                                        || supplier.Address != null &&
                                                        supplier.Address.Contains(searchText) ||
                                                        supplier.Phone != null && supplier.Phone.Contains(searchText) ||
                                                        supplier.Email != null && supplier.Email.Contains(searchText) ||
                                                        supplier.Facebook != null &&
                                                        supplier.Facebook.Contains(searchText) ||
                                                        supplier.Viber != null && supplier.Viber.Contains(searchText) ||
                                                        supplier.WhatsApp != null &&
                                                        supplier.WhatsApp.Contains(searchText) ||
                                                        supplier.Other != null && supplier.Other.Contains(searchText))
                .Select(supplier => new PersonVm
                {
                    Id = supplier.Id,
                    Name = supplier.Name,
                    Address = supplier.Address,
                    Phone = supplier.Phone,
                    Email = supplier.Email,
                    Facebook = supplier.Facebook,
                    Viber = supplier.Viber,
                    WhatsApp = supplier.WhatsApp,
                    Other = supplier.Other
                }).ToList();
            FillGrid();
        }

        private void FillGrid()
        {
            dgvSuppliers.DataSource = SuppliersList;
            btnEdit.Enabled = btnDelete.Enabled = SuppliersList.Any();
        }

        private void EditSupplier()
        {
            var supplierId = int.Parse(dgvSuppliers.SelectedRows[0].Cells[0].Value.ToString());
            new FrmAddSupplier(supplierId).ShowDialog();
            ResetForm();
        }

        private void DeleteSupplier()
        {
            var supplierId = int.Parse(dgvSuppliers.SelectedRows[0].Cells[0].Value.ToString());
            if (PurchaseInvoiceManager.IsSupplierHasPurchaseInvoices(supplierId))
            {
                ShowErrorMsg(Resources.SupplierNotDeletedDueToHisInvoices);
                return;
            }

            SupplierManager.DeleteSupplier(supplierId);
            ResetForm();
        }

        #endregion
    }
}