﻿using System.Linq;
using RBG.BLL.Infrastructure;
using RBG.DAL.Model;

namespace RBG.BLL
{
    public class InvoiceManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public void AddInvoice(Invoice invoice)
        {
            UnitOfWork.InvoiceRepository.Add(invoice);
        }

        public IQueryable<Invoice> GetAllInvoices()
        {
            return UnitOfWork.InvoiceRepository.GetAll();
        }

        #endregion
    }
}