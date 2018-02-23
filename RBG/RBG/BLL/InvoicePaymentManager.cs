using RBG.BLL.Infrastructure;
using RBG.DAL.Model;

namespace RBG.BLL
{
    public class InvoicePaymentManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public void AddInvoicePayment(InvoicePayment invoicePayment)
        {
            UnitOfWork.InvoicePaymentRepository.Add(invoicePayment);
        }

        #endregion
    }
}