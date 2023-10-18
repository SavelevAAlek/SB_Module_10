using SB_Module_10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB_Module_10.Infrastructure
{
    public class Repository : IRepository
    {
        protected readonly DataContext _context;
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
