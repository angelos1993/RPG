﻿using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace RPG.PL.Forms
{
    public partial class FrmMaster : Office2007Form
    {
        #region Constructor

        public FrmMaster()
        {
            InitializeComponent();
            SetupForm();
        }

        #endregion

        #region Properties

        public ErrorProvider ErrorProvider;
        #endregion

        #region Events

        private void SetupForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            MaximizeBox = false;
            EnableGlass = false;
            ShowInTaskbar = false;
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular);
            AutoScaleMode = AutoScaleMode.Font;
            ErrorProvider = new ErrorProvider
            {
                ContainerControl = this,
                RightToLeft = true
            };
        }

        #endregion
    }
}