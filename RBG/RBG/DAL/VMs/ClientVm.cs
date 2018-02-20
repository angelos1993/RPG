using System.ComponentModel;

namespace RBG.DAL.VMs
{
    public class ClientVm
    {
        public int Id { get; set; }

        [DisplayName("الاسم")]
        public string Name { get; set; }

        [DisplayName("التليفون")]
        public string Phone { get; set; }

        [DisplayName("العنوان")]
        public string Address { get; set; }
    }
}