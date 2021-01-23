using System.Collections.Generic;
using System.Linq;
using RPG.BLL.Infrastructure;
using RPG.DAL.Model;
using RPG.DAL.VMs;

namespace RPG.BLL
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

        public List<LightInvoiceVm> GetClientRemainingInvoices(int clientId)
        {
            return GetAllInvoices()
                .Where(invoice => invoice.ClientId == clientId
                                  && invoice.Total - invoice.Paid - invoice.Discount > 0)
                .Select(invoice => new LightInvoiceVm
                {
                    InvoiceId = invoice.Id,
                    Date = invoice.Date,
                    Total = invoice.Total,
                    Paid = invoice.Paid,
                    Discount = invoice.Discount
                }).ToList();
        }

        public void UpdateInvoicePaidAmount(int invoiceId, decimal paidAmount)
        {
            var invoice = UnitOfWork.InvoiceRepository.GetById(invoiceId);
            invoice.Paid += paidAmount;
            UpdateInvoice(invoice);
        }

        public void UpdateInvoice(Invoice invoice)
        {
            UnitOfWork.InvoiceRepository.Update(invoice);
        }

        public Invoice GetInvoiceById(int invoiceId)
        {
            return UnitOfWork.InvoiceRepository.GetById(invoiceId);
        }

        public bool IsClientHasInvoices(int clientId)
        {
            return UnitOfWork.InvoiceRepository.GetAll().Any(invoice => invoice.ClientId == clientId);
        }

        public void DeleteInvoice(Invoice invoice)
        {
            UnitOfWork.InvoiceRepository.Delete(invoice);
        }

        #endregion
    }
}