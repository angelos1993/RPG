using System.ComponentModel;

namespace RPG.DAL.VMs
{
    public class PurchaseInvoiceItemVm
    {
        public int MaterialId { get; set; }

        [DisplayName("الكود")]
        public string MaterialCode { get; set; }

        [DisplayName("المادة / الخامة")]
        public string MaterialName { get; set; }

        [DisplayName("الكمية")]
        public decimal Quantity { get; set; }

        [DisplayName("سعر الوحدة")]
        public decimal UnitPrice { get; set; }

        [DisplayName("السعر الكلي")] public decimal TotalPrice => UnitPrice * Quantity;

        [DisplayName("ملاحظات")]
        public string Notes { get; set; }
    }
}