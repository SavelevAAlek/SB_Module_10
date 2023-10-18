using SB_Module_10.Models;
using System.Collections.Generic;

namespace SB_Module_10.Infrastructure
{
    public interface IRepository
    {
        IEnumerable<Client> GetClient(string desiredClient);
        IEnumerable<Client> GetList();
    }
 }