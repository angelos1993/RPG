using System.Linq;
using RBG.BLL.Infrastructure;

namespace RBG.BLL
{
    public class AdminManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public bool Login(string username, string password)
        {
            return UnitOfWork.AdminRepository
                .Get(admin => admin.Username == username && admin.Password == password).Any();
        }

        #endregion
    }
}