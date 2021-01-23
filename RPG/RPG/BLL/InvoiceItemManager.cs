using System.Collections.Generic;
using System.Linq;
using RPG.BLL.Infrastructure;
using RPG.DAL.Model;
using RPG.DAL.VMs;

namespace RPG.BLL
{
    public class InvoiceItemManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public void AddInvoiceItems(List<InvoiceItem> invoiceItems)
        {
            invoiceItems.ForEach(invoiceItem => UnitOfWork.InvoiceItemRepository.Add(invoiceItem));
        }

        public void DeleteInvoiceItems(List<InvoiceItem> invoiceItems)
        {
            UnitOfWork.InvoiceItemRepository.DeleteRange(invoiceItems);
        }

        public List<InvoiceItemVm> GetInvoiceItems(int invoiceId)
        {
            return UnitOfWork.InvoiceItemRepository.Get(invoiceItem => invoiceItem.InvoiceId == invoiceId)
                .Select(invoiceItem => new InvoiceItemVm
                {
                    MaterialId = invoiceItem.MaterialId,
                    MaterialCode = invoiceItem.Material.Code,
                    MaterialName = invoiceItem.Material.Name,
                    Quantity = invoiceItem.Quantity,
                    TotalPrice = invoiceItem.Price,
                    Notes = invoiceItem.Notes
                }).ToList();
        }

        #endregion
    }
}