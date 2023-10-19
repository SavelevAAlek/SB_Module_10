using SB_Module_10.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB_Module_10.Models
{
    public class Consultant : Employee, IConsultant
    {
        public void EditClient(Client client, 
            string phoneNumber, 
            string surname = null, 
            string name = null, 
            string patronymic = null, 
            string passportSeries = null, 
            string passportNumber = null)
        {
            foreach (var c in _repository._context.ClientsList)
            {
                if (c.PassportData == client.PassportData)
                {
                    c.PhoneNumber = phoneNumber;
                    break;
                }
            }
            _repository._context.SaveDataToDB();
        }
    }
}
