using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RPG.BLL;
using RPG.DAL.Model;
using RPG.Utility;

namespace RPG.PL.Forms
{
    public partial class FrmAddMaterialQuantity : FrmMaster
    {
        #region Constructor

        public FrmAddMaterialQuantity()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private MaterialManager _materialManager;
        private MaterialManager MaterialManager => _materialManager ?? (_materialManager = new MaterialManager());
        private List<Material> Materials { get; set; }

        #endregion

        #region Events

        private void FrmAddMaterialQuantity_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ResetForm();
            Cursor = Cursors.Default;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Save();
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
            Materials = MaterialManager.GetAllUnArchivedMaterials().ToList();
            var materialsList = Materials.Select(material => new KeyValuePair<int, string>(material.Id, material.Name))
                .OrderBy(keyValuePair => keyValuePair.Value).ToList();
            materialsList.Insert(0, new KeyValuePair<int, string>(0, Resources.ComboBoxDefaultText));
            cmbMaterials.DataSource = materialsList;
            cmbMaterials.DisplayMember = "Value";
            cmbMaterials.ValueMember = "Key";
        }

        private void Save()
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
            var selectedMaterial = Materials
                .FirstOrDefault(material => material.Id == int.Parse(cmbMaterials.SelectedValue.ToString()));
            if (selectedMaterial != null)
            {
                selectedMaterial.Quantity += (decimal) dblInQuantity.Value;
                MaterialManager.UpdateMaterial(selectedMaterial);
                MessageBoxUtility.ShowInfoMsg(Resources.MaterialQuantityAddedSeccessfully);
            }
            Close();
        }

        #endregion
    }
}