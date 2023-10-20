using SB_Module_10.Models;
using System.Collections.Generic;
using System.Linq;

namespace SB_Module_10.Infrastructure
{
    public class Repository : IRepository
    {
        public readonly DataContext _context;
        public Repository()
        {
            _context = new DataContext();
        }

        public IEnumerable<Client> GetClient(string desiredClient)
        {
            var _clients = new List<Client>();
            foreach (var client in _context.ClientsList)
            {
                if (client.ToString().Contains(desiredClient))
                    _clients.Add(client);
            }
            return _clients;
        }

        public IEnumerable<Client> GetList() => _context.ClientsList.ToList();
    }
}
