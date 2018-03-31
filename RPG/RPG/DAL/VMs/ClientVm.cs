using System.ComponentModel;

namespace RPG.DAL.VMs
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

        [DisplayName("البريد الإلكتروني")]
        public string Email { get; set; }

        [DisplayName("فيس بوك")]
        public string Facebook { get; set; }

        [DisplayName("ڤايبر")]
        public string Viber { get; set; }

        [DisplayName("واتس آب")]
        public string WhatsApp { get; set; }

        [DisplayName("أخري")]
        public string Other { get; set; }
    }
}