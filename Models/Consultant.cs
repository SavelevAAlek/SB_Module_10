using SB_Module_10.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB_Module_10.Models
{
    public class Consultant : Repository, IConsultant
    {
        public void EditPhoneNumber(Client client, string phoneNumber)
        {
            foreach (var c in _context.ClientsList)
            {
                if (c.Equals(client))
                {
                    c.PhoneNumber = phoneNumber;
                    _context.SaveDataToDB();
                }
            }
        }
    }
}
