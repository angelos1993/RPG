using System.Collections.Generic;
using RBG.BLL.Infrastructure;
using RBG.DAL.Model;

namespace RBG.BLL
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

        #endregion
    }
}