using System.ComponentModel;

namespace RBG.DAL.VMs
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
    }
}