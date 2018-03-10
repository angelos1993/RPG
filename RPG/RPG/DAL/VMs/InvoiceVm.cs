using System;
using System.ComponentModel;
using RPG.Utility;

namespace RPG.DAL.VMs
{
    public class InvoiceVm
    {
        public int InvoiceId { get; set; }

        [Browsable(false)]
        public DateTime Date { get; set; }

        [DisplayName("التاريخ")]
        public string DateString => Date.ToCustomShortDateString();

        [DisplayName("اسم العميل")]
        public string ClientName { get; set; }

        [DisplayName("الإجمالي")]
        public decimal Total { get; set; }

        [DisplayName("المدفوع")]
        public decimal Paid { get; set; }

        [DisplayName("تخفيض")]
        public decimal Discount { get; set; }

        [DisplayName("باقي")]
        public decimal Remaining => Total - Paid - Discount;

        [DisplayName("خالص ؟")]
        public bool IsPaid => Remaining == 0;
    }
}