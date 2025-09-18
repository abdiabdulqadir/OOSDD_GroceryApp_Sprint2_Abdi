using Grocery.Core.Models;
using Grocery.Core.Interfaces.Repositories;

namespace Grocery.Core.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly List<Client> _clients;

        public ClientRepository()
        {
            _clients = new List<Client>
            {
                new Client(1, "Jan Jansen", "jan@email.com", "password123"),
                new Client(2, "Piet Pietersen", "piet@email.com", "geheim456"),
                new Client(3, "Marie Klaassen", "marie@email.com", "wachtwoord789")
            };
        }

        public List<Client> GetAll()
        {
            return _clients;
        }

        public Client? Get(int id)
        {
            return _clients.FirstOrDefault(c => c.Id == id);
        }

        // Deze methode is voor de interface IClientRepository
        public Client? Get(string email)
        {
            return _clients.FirstOrDefault(c => c.EmailAddress == email);
        }

        public Client Add(Client item)
        {
            _clients.Add(item);
            return item;
        }

        public Client? Delete(Client item)
        {
            var client = _clients.FirstOrDefault(c => c.Id == item.Id);
            if (client != null)
            {
                _clients.Remove(client);
                return client;
            }
            return null;
        }

        public Client? Update(Client item)
        {
            var existingClient = _clients.FirstOrDefault(c => c.Id == item.Id);
            if (existingClient != null)
            {
                existingClient.Name = item.Name;
                existingClient.EmailAddress = item.EmailAddress;
                existingClient.Password = item.Password;
                return existingClient;
            }
            return null;
        }
    }
}
