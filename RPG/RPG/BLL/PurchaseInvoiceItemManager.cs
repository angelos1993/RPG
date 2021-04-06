using System.Collections.Generic;
using System.Linq;
using RPG.BLL.Infrastructure;
using RPG.DAL.Model;
using RPG.DAL.VMs;

namespace RPG.BLL
{
    public class PurchaseInvoiceItemManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public void AddPurchaseInvoiceItems(List<PurchaseInvoiceItem> purchaseInvoiceItems)
        {
            purchaseInvoiceItems.ForEach(purchaseInvoiceItem =>
                UnitOfWork.PurchaseInvoiceItemRepository.Add(purchaseInvoiceItem));
        }

        public void DeletePurchaseInvoiceItems(List<PurchaseInvoiceItem> purchaseInvoiceItems)
        {
            UnitOfWork.PurchaseInvoiceItemRepository.DeleteRange(purchaseInvoiceItems);
        }

        public List<PurchaseInvoiceItemVm> GetPurchaseInvoiceItems(int purchaseInvoiceId)
        {
            return UnitOfWork.PurchaseInvoiceItemRepository
                .Get(purchaseInvoiceItem => purchaseInvoiceItem.InvoiceId == purchaseInvoiceId)
                .Select(purchaseInvoiceItem => new PurchaseInvoiceItemVm
                {
                    MaterialId = purchaseInvoiceItem.MaterialId,
                    MaterialCode = purchaseInvoiceItem.Material.Code,
                    MaterialName = purchaseInvoiceItem.Material.Name,
                    Quantity = purchaseInvoiceItem.Quantity,
                    UnitPrice = purchaseInvoiceItem.UnitPrice,
                    Notes = purchaseInvoiceItem.Notes
                }).ToList();
        }

        #endregion
    }
}