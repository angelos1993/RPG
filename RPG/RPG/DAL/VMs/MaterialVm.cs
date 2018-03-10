using System.ComponentModel;

namespace RPG.DAL.VMs
{
    public class MaterialVm
    {
        public int Id { get; set; }

        [DisplayName("الكود")]
        public string Code { get; set; }

        [DisplayName("الاسم")]
        public string Name { get; set; }

        [DisplayName("السعر")]
        public decimal Price { get; set; }

        [DisplayName("الكمية المتوفرة")]
        public decimal Quantity { get; set; }

        [DisplayName("منتهي / محذوف")]
        public bool IsArchived { get; set; }
    }
}