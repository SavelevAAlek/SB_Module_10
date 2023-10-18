using SB_Module_10.Infrastructure;
using System;

namespace SB_Module_10.Models
{
    public class Manager : Repository, IManager
    {
        public void AddClientToDB(string surname, string name, string phoneNumber, string passportSeries, string passportNumber, string patronymics = null)
        {
            var c = new Client(surname, name, patronymics, phoneNumber, passportSeries , passportNumber);
            _context.ClientsList.Add(c);
            _context.SaveDataToDB();
        }

        public void DeleteClient(Client client)
        {
            foreach (var c in _context.ClientsList)
            {
                if (c.Equals(client))
                {
                    _context.ClientsList.Remove(c);
                    _context.SaveDataToDB();
                }
            }
        }

        public void EditName(Client client, string name)
        {
            foreach (var c in _context.ClientsList)
            {
                if (c.Equals(client))
                {
                    c.Name = name;
                    _context.SaveDataToDB();
                    c.DataChangedTime = DateTime.Now;
                    c.ChangeInitiator = ToString();
                    c.FieldChanged = "Name";
                }
            }
        }

        public void EditPassportNumber(Client client, string passportNumber)
        {
            foreach (var c in _context.ClientsList)
            {
                if (c.Equals(client))
                {
                    c.PassportNumber = passportNumber;
                    _context.SaveDataToDB();
                }
            }
        }

        public void EditPassportSeries(Client client, string passportSeries)
        {
            foreach (var c in _context.ClientsList)
            {
                if (c.Equals(client))
                {
                    c.PassportSeries = passportSeries;
                    _context.SaveDataToDB();
                }
            }
        }

        public void EditPatronymics(Client client, string patronymics)
        {
            foreach (var c in _context.ClientsList)
            {
                if (c.Equals(client))
                {
                    c.Patronymics = patronymics;
                    _context.SaveDataToDB();
                }
            }
        }

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

        public void EditSurname(Client client, string surname)
        {
            foreach (var c in _context.ClientsList)
            {
                if (c.Equals(client))
                {
                    c.Surname = surname;
                    _context.SaveDataToDB();
                }
            }
        }
    }
}
