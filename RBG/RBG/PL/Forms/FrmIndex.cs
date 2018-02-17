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

        #endregion

        #region Client

        #endregion

        #region Material

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            new FrmAddMaterial().ShowDialog();
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            new FrmAddMaterial().ShowDialog();
        }

        private void btnListMaterials_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Admin

        #endregion

        #region DB

        #endregion

        #endregion

        #region Methods

        #endregion
    }
}