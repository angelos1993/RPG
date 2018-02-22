using System.ComponentModel;

namespace RBG.DAL.VMs
{
    public class InvoiceItemVm
    {
        //public int MaterialId { get; set; }
        [DisplayName("المادة / الخامة")]
        public string MaterialName { get; set; }
        [DisplayName("الكمية")]
        public decimal Quantity { get; set; }
        [DisplayName("سعر الوحدة")]
        public decimal PricePerMeter { get; set; }
        [DisplayName("السعر الكلي")]
        public decimal TotalPrice => Quantity * PricePerMeter;
    }
}