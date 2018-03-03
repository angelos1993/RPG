using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace RBG.PL.Forms
{
    public partial class FrmIndex : Office2007Form
    {
        #region Constructor

        public FrmIndex()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        #endregion

        #region Events

        #region Form

        private void FrmIndex_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Invoice

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            new FrmAddInvoice().ShowDialog();
        }

        private void btnPayInvoice_Click(object sender, EventArgs e)
        {
            new FrmPayInvoice().ShowDialog();
        }

        private void btnListInvoices_Click(object sender, EventArgs e)
        {
            new FrmInvoices().ShowDialog();
        }

        #endregion

        #region Client

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            new FrmAddClient().ShowDialog();
        }

        private void btnListClients_Click(object sender, EventArgs e)
        {
            new FrmClients().ShowDialog();
        }

        #endregion

        #region Material

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            new FrmAddMaterial().ShowDialog();
        }

        private void btnAddMaterialQuantity_Click(object sender, EventArgs e)
        {
            new FrmAddMaterialQuantity().ShowDialog();
        }

        private void btnListMaterials_Click(object sender, EventArgs e)
        {
            new FrmMaterials().ShowDialog();
        }

        #endregion

        #region Admin

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            new FrmEditAdmin().ShowDialog();
        }

        #endregion

        #region DB

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            new FrmDatabase().ShowDialog();
        }

        #endregion

        #endregion

        #region Methods

        #endregion
    }
}