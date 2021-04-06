using System.Collections.Generic;
using System.Linq;
using RPG.BLL.Infrastructure;
using RPG.DAL.Model;
using RPG.DAL.VMs;

namespace RPG.BLL
{
    public class PurchaseInvoicePaymentManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public void AddPurchaseInvoicePayment(PurchaseInvoicePayment purchaseInvoicePayment)
        {
            UnitOfWork.PurchaseInvoicePaymentRepository.Add(purchaseInvoicePayment);
        }

        public List<InvoicePaymentVm> GetPurchaseInvoicePayments(int purchaseInvoiceId)
        {
            return UnitOfWork.PurchaseInvoicePaymentRepository
                .Get(purchaseInvoicePayment => purchaseInvoicePayment.InvoiceId == purchaseInvoiceId)
                .Select(purchaseInvoicePayment => new InvoicePaymentVm
                    {Date = purchaseInvoicePayment.Date, Paid = purchaseInvoicePayment.Paid}).ToList();
        }

        public void DeletePurchaseInvoicePayments(List<PurchaseInvoicePayment> purchaseInvoicePayments)
        {
            UnitOfWork.PurchaseInvoicePaymentRepository.DeleteRange(purchaseInvoicePayments);
        }

        #endregion
    }
}