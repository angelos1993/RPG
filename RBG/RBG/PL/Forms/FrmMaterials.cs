using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RBG.BLL;
using RBG.DAL.Model;
using RBG.DAL.VMs;
using static RBG.Utility.MessageBoxUtility;

namespace RBG.PL.Forms
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
            GetMaterials();
            FillGrid();
            Cursor = Cursors.Default;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SearchMaterials();
            FillGrid();
            Cursor = Cursors.Default;
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            new FrmAddMaterial().ShowDialog();
            RefreshGrid();
            Cursor = Cursors.Default;
        }

        private void radSort_CheckedChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SortMaterials();
            FillGrid();
            Cursor = Cursors.Default;
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ShowConfirmationDialog("هل أنت متأكد من أنك تريد حذف هذه المادة / الخامة ؟") != DialogResult.Yes)
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

        private void GetMaterials()
        {
            Materials = MaterialManager.GetAllMaterials().OrderBy(material => material.Name).ToList();
            MaterialsList = Materials.Select(material => new MaterialVm
            {
                Code = material.Code,
                Name = material.Name,
                Price = material.Price
            }).ToList();
        }

        private void SearchMaterials()
        {
            var searchText = txtSearch.Text;
            MaterialsList = Materials
                .Where(material => material.Name.Contains(searchText) || material.Code.Contains(searchText))
                .Select(material => new MaterialVm {Code = material.Code, Name = material.Name, Price = material.Price})
                .ToList();
            SortMaterials();
        }

        private void SortMaterials()
        {
            if (radName.Checked)
                MaterialsList = MaterialsList.OrderBy(material => material.Name).ToList();
            else if (radCode.Checked)
                MaterialsList = MaterialsList.OrderBy(material => material.Code).ToList();
            else
                MaterialsList = MaterialsList.OrderBy(material => material.Price).ToList();
        }

        private void FillGrid()
        {
            dgvMaterials.DataSource = MaterialsList;
        }

        private void RefreshGrid()
        {
            GetMaterials();
            SearchMaterials();
            FillGrid();
        }

        private void DeleteMaterial()
        {
            MaterialManager.DeleteMaterial(dgvMaterials.SelectedRows[0].Cells[0].Value.ToString(),
                dgvMaterials.SelectedRows[0].Cells[1].Value.ToString());
            RefreshGrid();
        }

        #endregion
    }
}