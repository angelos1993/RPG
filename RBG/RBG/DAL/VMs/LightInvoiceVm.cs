using System;
using System.ComponentModel;
using RBG.Utility;

namespace RBG.DAL.VMs
{
    //todo: try to make InvoiceVm & this class inherit from each other, the problem is columns' order
    public class LightInvoiceVm
    {
        public int InvoiceId { get; set; }

        [Browsable(false)]
        public DateTime Date { get; set; }

        [DisplayName("التاريخ")]
        public string DateString => Date.ToCustomShortDateString();

        [DisplayName("الإجمالي")]
        public decimal Total { get; set; }

        [DisplayName("المدفوع")]
        public decimal Paid { get; set; }

        [DisplayName("تخفيض")]
        public decimal Discount { get; set; }

        [DisplayName("باقي")]
        public decimal Remaining => Total - Paid - Discount;
    }
}