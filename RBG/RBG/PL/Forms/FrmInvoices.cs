namespace RBG.PL.Forms
{
    public partial class FrmInvoices : FrmMaster
    {
        #region Constructor

        public FrmInvoices()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        #endregion

        #region Events

        #endregion

        #region Methods

        #endregion

        private void FrmInvoices_Load(object sender, System.EventArgs e)
        {
            //load all invoices
        }

        private void txtClientName_TextChanged(object sender, System.EventArgs e)
        {
            //filter
        }

        private void radInvoiceState_CheckedChanged(object sender, System.EventArgs e)
        {
            //filter
        }

        private void dgvInvoices_DoubleClick(object sender, System.EventArgs e)
        {
            //diaplay invoice details
        }
    }
}