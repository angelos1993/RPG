using System;

namespace RBG.DAL.VMs
{
    public class InvoiceVm
    {
        public int InvoiceId { get; set; }
        public DateTime Date { get; set; }
        //todo: format this date
        public string DateString => Date.ToLongDateString();
        public string ClientName { get; set; }
        public decimal Total { get; set; }
        public decimal Paid { get; set; }
        public decimal Discount { get; set; }
        public decimal Remaining => Total - Paid - Discount;
        public bool IsPaid => Remaining == 0;
    }
}