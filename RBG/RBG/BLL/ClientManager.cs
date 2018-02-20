using System.Linq;
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

        public Client GetClientById(int clientId)
        {
            return UnitOfWork.ClientRepository.GetById(clientId);
        }

        public void UpdateClient(Client client)
        {
            UnitOfWork.ClientRepository.Update(client);
        }

        public IQueryable<Client> GetAllClients()
        {
            return UnitOfWork.ClientRepository.GetAll();
        }

        public void DeleteClient(int clientId)
        {
            DeleteClient(GetClientById(clientId));
        }

        public void DeleteClient(Client client)
        {
            UnitOfWork.ClientRepository.Delete(client);
        }

        #endregion
    }
}