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

        #endregion

        #region Invoice

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {

        }

        private void btnListInvoices_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Client

        private void btnAddClient_Click(object sender, EventArgs e)
        {

        }

        private void btnListClients_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Material

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            new FrmAddMaterial().ShowDialog();
        }

        private void btnListMaterials_Click(object sender, EventArgs e)
        {
            new FrmMaterials().ShowDialog();
        }

        #endregion

        #region Admin

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnListAdmins_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region DB

        #endregion

        #endregion

        #region Methods

        #endregion
    }
}