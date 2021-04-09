using System;
using System.Windows.Forms;
using RPG.BLL;
using RPG.DAL.Model;
using RPG.Utility;
using static RPG.Utility.MessageBoxUtility;

namespace RPG.PL.Forms
{
    public partial class FrmAddSupplier : FrmMaster
    {
        #region Constructor

        public FrmAddSupplier(int? supplierId = null)
        {
            InitializeComponent();
            if(supplierId.HasValue)
                SetFormForEditMode(supplierId.Value);
        }

        #endregion

        #region Properties

        private SupplierManager _supplierManager;
        private SupplierManager SupplierManager => _supplierManager?? (_supplierManager= new SupplierManager());
        private bool IsEditMode { get; set; }
        private Supplier Supplier { get; set; }

        #endregion

        #region Events

        private void FrmAddSupplier_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void chkBoxViber_CheckedChanged(object sender, EventArgs e)
        {
            txtViber.Text = chkBoxViber.Checked ? txtPhone.Text : string.Empty;
            txtViber.Enabled = !chkBoxViber.Checked;
        }

        private void chkBoxWhatsApp_CheckedChanged(object sender, EventArgs e)
        {
            txtWhatsApp.Text = chkBoxWhatsApp.Checked ? txtPhone.Text : string.Empty;
            txtWhatsApp.Enabled = !chkBoxWhatsApp.Checked;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (chkBoxViber.Checked)
                txtViber.Text = txtPhone.Text;
            if (chkBoxWhatsApp.Checked)
                txtWhatsApp.Text = txtPhone.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SaveSupplier();
            Cursor = Cursors.Default;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void SaveSupplier()
        {
            ErrorProvider.Clear();
            var isFormValid = true;
            if (txtName.Text.FullTrim().IsNullOrEmptyOrWhiteSpace())
            {
                isFormValid = false;
                ErrorProvider.SetError(txtName, Resources.ThisFieldIsRequired);
            }

            if (!isFormValid)
            {
                txtName.Focus();
                return;
            }

            if (!IsEditMode)
            {
                SupplierManager.AddSupplier(new Supplier
                {
                    Name = txtName.Text.FullTrim(),
                    Address = txtAddress.Text.FullTrim(),
                    Phone = txtPhone.Text.FullTrim(),
                    Email = txtEmail.Text.FullTrim(),
                    Facebook = txtFacebook.Text.FullTrim(),
                    Viber = txtViber.Text.FullTrim(),
                    WhatsApp = txtWhatsApp.Text.FullTrim(),
                    Other = txtOther.Text.FullTrim()
                });
            }
            else
            {
                Supplier.Name = txtName.Text.FullTrim();
                Supplier.Address = txtAddress.Text.FullTrim();
                Supplier.Phone = txtPhone.Text.FullTrim();
                Supplier.Email = txtEmail.Text.FullTrim();
                Supplier.Facebook = txtFacebook.Text.FullTrim();
                Supplier.Viber = txtViber.Text.FullTrim();
                Supplier.WhatsApp = txtWhatsApp.Text.FullTrim();
                Supplier.Other = txtOther.Text.FullTrim();
                SupplierManager.UpdateSupplier(Supplier);
            }

            ShowInfoMsg(IsEditMode ? Resources.SupplierEditedSeccessfully : Resources.SupplierAddedSeccessfully);
            Close();
        }

        private void SetFormForEditMode(int supplierId)
        {
            IsEditMode = true;
            Supplier = SupplierManager.GetSupplierById(supplierId);
            Text = @"تعديل مُورد";
            txtName.Text = Supplier.Name;
            txtAddress.Text = Supplier.Address;
            txtPhone.Text = Supplier.Phone;
            txtEmail.Text = Supplier.Email;
            txtFacebook.Text = Supplier.Facebook;
            txtViber.Text = Supplier.Viber;
            txtWhatsApp.Text = Supplier.WhatsApp;
            txtOther.Text = Supplier.Other;
        }

        #endregion
    }
}