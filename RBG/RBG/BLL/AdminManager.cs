using System.Linq;
using RBG.BLL.Infrastructure;
using RBG.Utility;

namespace RBG.BLL
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

        #endregion
    }
}