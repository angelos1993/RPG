using System.Linq;
using RPG.BLL.Infrastructure;
using RPG.DAL.Model;
using RPG.Utility;

namespace RPG.BLL
{
    public class AdminManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public bool Login(string username, string password)
        {
            var hashedPassword = password.ToMd5Hash();
            return UnitOfWork.AdminRepository
                .Get(admin => admin.Username == username && admin.Password == hashedPassword).Any();
        }

        public Admin GetCurrentAdmin()
        {
            return UnitOfWork.AdminRepository.GetAll().FirstOrDefault();
        }

        public void UpdateAdmin(Admin admin)
        {
            UnitOfWork.AdminRepository.Update(admin);
        }

        #endregion
    }
}