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
    public partial class FrmMaterials : FrmMaster
    {
        #region Constructor

        public FrmMaterials()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private MaterialManager _materialManager;
        private MaterialManager MaterialManager => _materialManager ?? (_materialManager = new MaterialManager());
        private List<Material> Materials { get; set; }
        private List<MaterialVm> MaterialsList { get; set; }

        #endregion

        #region Events

        private void FrmMaterials_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ResetForm();
            Cursor = Cursors.Default;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SearchMaterials();
            Cursor = Cursors.Default;
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            new FrmAddMaterial().ShowDialog();
            ResetForm();
            Cursor = Cursors.Default;
        }

        private void btnAddMaterialQuantity_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            new FrmAddMaterialQuantity().ShowDialog();
            ResetForm();
            Cursor = Cursors.Default;
        }

        private void radSort_CheckedChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SortMaterials();
            Cursor = Cursors.Default;
        }

        private void dgvMaterials_SelectionChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SetButtonsAvailability();
            Cursor = Cursors.Default;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            EditMaterial();
            Cursor = Cursors.Default;
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ArchiveOrunArchiveMaterial(true);
            Cursor = Cursors.Default;
        }

        private void btnUnArchive_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ArchiveOrunArchiveMaterial(false);
            Cursor = Cursors.Default;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ShowConfirmationDialog(Resources.DeleteMaterialConfirmationMsg, DialogDefaultButton.No) !=
                DialogResult.Yes)
                return;
            Cursor = Cursors.WaitCursor;
            DeleteMaterial();
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
            GetMaterials();
            SearchMaterials();
            dgvMaterials.Columns[0].Visible = false;
        }

        private void GetMaterials()
        {
            Materials = MaterialManager.GetAllMaterials().OrderBy(material => material.Name).ToList();
            MaterialsList = Materials.Select(material => new MaterialVm
            {
                Id = material.Id,
                Code = material.Code,
                Name = material.Name,
                Price = material.Price,
                Quantity = material.Quantity,
                IsArchived = material.IsArchived
            }).ToList();
        }

        private void SearchMaterials()
        {
            var searchText = txtSearch.Text.FullTrim().ToLower();
            MaterialsList = Materials.Where(material =>
                    material.Name.ToLower().Contains(searchText) || material.Code.ToLower().Contains(searchText))
                .Select(material => new MaterialVm
                {
                    Id = material.Id,
                    Code = material.Code,
                    Name = material.Name,
                    Price = material.Price,
                    Quantity = material.Quantity,
                    IsArchived = material.IsArchived
                }).ToList();
            SortMaterials();
        }

        private void SortMaterials()
        {
            if (radName.Checked)
                MaterialsList = MaterialsList.OrderBy(material => material.Name).ToList();
            else if (radCode.Checked)
                MaterialsList = MaterialsList.OrderBy(material => material.Code).ToList();
            else if (radPrice.Checked)
                MaterialsList = MaterialsList.OrderBy(material => material.Price).ToList();
            else
                MaterialsList = MaterialsList.OrderBy(material => material.Quantity).ToList();
            FillGrid();
        }

        private void FillGrid()
        {
            dgvMaterials.DataSource = MaterialsList;
            SetButtonsAvailability();
        }

        private void EditMaterial()
        {
            var materialId = int.Parse(dgvMaterials.SelectedRows[0].Cells[0].Value.ToString());
            new FrmAddMaterial(materialId).ShowDialog();
            ResetForm();
        }

        private void ArchiveOrunArchiveMaterial(bool isArchived)
        {
            var rowIndex = dgvMaterials.SelectedRows[0].Index;
            var material =
                MaterialManager.GetMaterialById(int.Parse(dgvMaterials.SelectedRows[0].Cells[0].Value.ToString()));
            material.IsArchived = isArchived;
            MaterialManager.UpdateMaterial(material);
            ResetForm();
            dgvMaterials.Rows[rowIndex].Selected = true;
        }

        private void DeleteMaterial()
        {
            var material =
                MaterialManager.GetMaterialById(int.Parse(dgvMaterials.SelectedRows[0].Cells[0].Value.ToString()));
            material.IsDeleted = true;
            MaterialManager.UpdateMaterial(material);
            ResetForm();
        }

        private void SetButtonsAvailability()
        {
            if (dgvMaterials.SelectedRows.Count <= 0)
            {
                btnEdit.Enabled = btnArchive.Enabled = btnUnArchive.Enabled = btnDelete.Enabled = false;
                return;
            }
            var isMaterialArchived = !bool.Parse(dgvMaterials.SelectedRows[0].Cells["IsArchived"]
                .Value.ToString());
            btnEdit.Enabled = btnArchive.Enabled = isMaterialArchived;
            btnUnArchive.Enabled = !isMaterialArchived;
            btnDelete.Enabled = true;
        }

        #endregion
    }
}