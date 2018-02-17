﻿using System;
using System.Windows.Forms;
using RBG.BLL;
using RBG.DAL.Model;
using RBG.Utility;
using static RBG.Utility.Constants;
using static RBG.Utility.MessageBoxUtility;

namespace RBG.PL.Forms
{
    public partial class FrmAddMaterial : FrmMaster
    {
        #region Constructor

        public FrmAddMaterial()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private MaterialManager _materialManager;
        private MaterialManager MaterialManager => _materialManager ?? (_materialManager = new MaterialManager());

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
            var isFormValid = true;
            if (txtCode.Text.FullTrim().IsNullOrEmptyOrWhiteSpace())
            {
                isFormValid = false;
                ErrorProvider.SetError(txtCode, ValidationMsg);
            }
            if (txtName.Text.FullTrim().IsNullOrEmptyOrWhiteSpace())
            {
                isFormValid = false;
                ErrorProvider.SetError(txtName, ValidationMsg);
            }
            if (Math.Abs(dblInPrice.Value) <= 0)
            {
                isFormValid = false;
                ErrorProvider.SetError(dblInPrice, ValidationMsg);
            }
            if (!isFormValid)
                return;
            var isMaterialCodeExists = MaterialManager.IsMaterialCodeExists(txtCode.Text.FullTrim());
            var isMaterialNameExists = MaterialManager.IsMaterialNameExists(txtName.Text.FullTrim());
            if (isMaterialNameExists && isMaterialCodeExists)
            {
                ShowErrorMsg("الكود والاسم مستخدمان من قبل");
                txtCode.Focus();
            }
            else if (isMaterialNameExists)
            {
                ShowErrorMsg("الاسم الذي أدخلتة مستخدم من قبل");
                txtName.Focus();
            }
            else if (isMaterialCodeExists)
            {
                ShowErrorMsg("الكود الذي أدخلتة مستخدم من قبل");
                txtCode.Focus();
            }
            else
            {
                MaterialManager.AddMaterial(new Material
                {
                    Code = txtCode.Text.FullTrim(),
                    Name = txtName.Text.FullTrim(),
                    Price = (decimal) dblInPrice.Value
                });
                Close();
            }
        }

        #endregion
    }
}