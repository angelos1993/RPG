using RBG.BLL.Infrastructure;
using RBG.DAL.Model;

namespace RBG.BLL
{
    public class ClientManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public void AddClient(Client client)
        {
            UnitOfWork.ClientRepository.Add(client);
        }

        #endregion
    }
}