using System.Collections.Generic;
using System.Linq;
using RPG.BLL.Infrastructure;
using RPG.DAL.Model;

namespace RPG.BLL
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

        public List<string> GetAllClientsNames()
        {
            return GetAllClients().Select(client => client.Name).ToList();
        }

        public int GetClientIdByName(string clientName)
        {
            return UnitOfWork.ClientRepository.Get(client => client.Name == clientName).FirstOrDefault()?.Id ?? 0;
        }

        #endregion
    }
}