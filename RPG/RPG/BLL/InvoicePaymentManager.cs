using System.Collections.Generic;
using System.Linq;
using RPG.BLL.Infrastructure;
using RPG.DAL.Model;
using RPG.DAL.VMs;

namespace RPG.BLL
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

        public List<InvoicePaymentVm> GetInvoicePayments(int invoiceId)
        {
            return UnitOfWork.InvoicePaymentRepository.Get(invoicePayment => invoicePayment.InvoiceId == invoiceId)
                .Select(invoicePayment => new InvoicePaymentVm {Date = invoicePayment.Date, Paid = invoicePayment.Paid})
                .ToList();
        }

        #endregion
    }
}