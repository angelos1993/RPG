using System;
using System.Windows.Forms;
using RPG.BLL;
using RPG.DAL.Model;
using RPG.Utility;

namespace RPG.PL.Forms
{
    public partial class FrmAddMaterial : FrmMaster
    {
        #region Constructor

        public FrmAddMaterial(int? materialId = null)
        {
            InitializeComponent();
            if (materialId.HasValue)
                SetFormForEditMode(materialId.Value);
        }

        #endregion

        #region Properties

        private MaterialManager _materialManager;
        private MaterialManager MaterialManager => _materialManager ?? (_materialManager = new MaterialManager());
        private bool IsEditMode { get; set; }
        private Material Material { get; set; }

        #endregion

        #region Events

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SaveMaterial();
            Cursor = Cursors.Default;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void SaveMaterial()
        {
            ErrorProvider.Clear();
            var isFormValid = true;
            if (Math.Abs(dblInPrice.Value) <= 0)
            {
                isFormValid = false;
                ErrorProvider.SetError(dblInPrice, Resources.ThisFieldIsRequired);
                dblInPrice.Focus();
            }
            if (txtName.Text.FullTrim().IsNullOrEmptyOrWhiteSpace())
            {
                isFormValid = false;
                ErrorProvider.SetError(txtName, Resources.ThisFieldIsRequired);
                txtName.Focus();
            }
            if (txtCode.Text.FullTrim().IsNullOrEmptyOrWhiteSpace())
            {
                isFormValid = false;
                ErrorProvider.SetError(txtCode, Resources.ThisFieldIsRequired);
                txtCode.Focus();
            }
            if (!isFormValid)
                return;
            var isMaterialCodeExists = !IsEditMode
                ? MaterialManager.IsMaterialCodeExists(txtCode.Text.FullTrim())
                : txtCode.Text.FullTrim() != Material.Code &&
                  MaterialManager.IsMaterialCodeExists(txtCode.Text.FullTrim());
            var isMaterialNameExists = !IsEditMode
                ? MaterialManager.IsMaterialNameExists(txtName.Text.FullTrim())
                : txtName.Text.FullTrim() != Material.Name &&
                  MaterialManager.IsMaterialNameExists(txtName.Text.FullTrim());
            if (isMaterialNameExists && isMaterialCodeExists)
                isFormValid = MessageBoxUtility.ShowConfirmationDialog(Resources.MaterialCodeAndNameAlreadyUsed) == DialogResult.Yes;
            else if (isMaterialNameExists)
                isFormValid = MessageBoxUtility.ShowConfirmationDialog(Resources.MaterialNameAlreadyUsed) == DialogResult.Yes;
            else if (isMaterialCodeExists)
                isFormValid = MessageBoxUtility.ShowConfirmationDialog(Resources.MaterialCodeAlreadyUsed) == DialogResult.Yes;
            if (!isFormValid)
                return;
            if (!IsEditMode)
            {
                MaterialManager.AddMaterial(new Material
                {
                    Code = txtCode.Text.FullTrim(),
                    Name = txtName.Text.FullTrim(),
                    Price = (decimal) dblInPrice.Value,
                    Quantity = (decimal) dblInQuantity.Value,
                    IsArchived = false
                });
            }
            else
            {
                Material.Code = txtCode.Text.FullTrim();
                Material.Name = txtName.Text.FullTrim();
                Material.Price = (decimal) dblInPrice.Value;
                Material.Quantity = (decimal) dblInQuantity.Value;
                MaterialManager.UpdateMaterial(Material);
            }
            MessageBoxUtility.ShowInfoMsg(IsEditMode ? Resources.MaterialEditedSuccessfully : Resources.MaterialAddedSuccessfully);
            Close();
        }

        private void SetFormForEditMode(int materialId)
        {
            IsEditMode = true;
            Material = MaterialManager.GetMaterialById(materialId);
            Text = @"تعديل مادة / خامة";
            txtCode.Text = Material.Code;
            txtName.Text = Material.Name;
            dblInPrice.Value = (double) Material.Price;
            dblInQuantity.Value = (double) Material.Quantity;
        }

        #endregion
    }
}