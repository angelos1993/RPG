using System;
using System.ComponentModel;
using RBG.Utility;

namespace RBG.DAL.VMs
{
    public class InvoicePaymentVm
    {
        [Browsable(false)]
        public DateTime Date { get; set; }

        [DisplayName("التاريخ")]
        public string DateString => Date.ToCustomShortDateString();

        [DisplayName("المبلغ المدفوع")]
        public decimal Paid { get; set; }
    }
}