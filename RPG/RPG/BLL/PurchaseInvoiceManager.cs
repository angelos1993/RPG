using System.Collections.Generic;
using System.Linq;
using RPG.BLL.Infrastructure;
using RPG.DAL.Model;
using RPG.DAL.VMs;

namespace RPG.BLL
{
    public class PurchaseInvoiceManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public void AddPurchaseInvoice(PurchaseInvoice purchaseInvoice)
        {
            UnitOfWork.PurchaseInvoiceRepository.Add(purchaseInvoice);
        }

        public IQueryable<PurchaseInvoice> GetAllPurchaseInvoices()
        {
            return UnitOfWork.PurchaseInvoiceRepository.GetAll();
        }

        public List<LightInvoiceVm> GetSupplierRemainingInvoices(int supplierId)
        {
            return GetAllPurchaseInvoices()
                .Where(purchaseInvoice => purchaseInvoice.SupplierId == supplierId
                                          && purchaseInvoice.Total - purchaseInvoice.Paid - purchaseInvoice.Discount >
                                          0)
                .OrderBy(purchaseInvoice => purchaseInvoice.Id).Select(purchaseInvoice => new LightInvoiceVm
                {
                    InvoiceId = purchaseInvoice.Id,
                    Date = purchaseInvoice.Date,
                    Total = purchaseInvoice.Total,
                    Paid = purchaseInvoice.Paid,
                    Discount = purchaseInvoice.Discount
                }).ToList();
        }

        public void UpdatePurchaseInvoicePaidAmount(int purchaseInvoiceId, decimal paidAmount)
        {
            var purchaseInvoice = UnitOfWork.PurchaseInvoiceRepository.GetById(purchaseInvoiceId);
            purchaseInvoice.Paid += paidAmount;
            UpdatePurchaseInvoice(purchaseInvoice);
        }

        public void UpdatePurchaseInvoice(PurchaseInvoice purchaseInvoice)
        {
            UnitOfWork.PurchaseInvoiceRepository.Update(purchaseInvoice);
        }

        public PurchaseInvoice GetPurchaseInvoiceById(int purchaseInvoiceId)
        {
            return UnitOfWork.PurchaseInvoiceRepository.GetById(purchaseInvoiceId);
        }

        public bool IsSupplierHasPurchaseInvoices(int supplierId)
        {
            return UnitOfWork.PurchaseInvoiceRepository.GetAll()
                .Any(purchaseInvoice => purchaseInvoice.SupplierId == supplierId);
        }

        public void DeletePurchaseInvoice(PurchaseInvoice purchaseInvoice)
        {
            UnitOfWork.PurchaseInvoiceRepository.Delete(purchaseInvoice);
        }

        #endregion
    }
}