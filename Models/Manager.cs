using SB_Module_10.Infrastructure;
using System;

namespace SB_Module_10.Models
{
    public class Manager : Employee, IManager
    {
        public void AddClientToDB(string surname, string name, string phoneNumber, string passportSeries, string passportNumber, string patronymics = null)
        {
            var c = new Client(surname, name, patronymics, phoneNumber, passportSeries , passportNumber);
            _repository._context.ClientsList.Add(c);
            _repository._context.SaveDataToDB();
        }

        public void DeleteClient(Client client)
        {
            foreach (var c in _repository._context.ClientsList)
            {
                if (c.PassportData == client.PassportData)
                {
                    _repository._context.ClientsList.Remove(c);
                    _repository._context.SaveDataToDB();
                }
            }
        }

        public void EditClient(Client client, string surname, string name, string patronymic, string phoneNumber, string passportSeries, string passportNumber)
        {

            foreach (var c in _repository._context.ClientsList)
            {
                if (c.PassportData == client.PassportData)
                {
                    if (c.Surname !=  surname) c.Surname = surname;
                    if (c.Name != name) c.Name = name;
                    if (c.Patronymics != patronymic) c.Patronymics = patronymic;
                    if (c.PhoneNumber != phoneNumber) c.PhoneNumber = phoneNumber;
                    if (c.PassportSeries != passportSeries) c.PassportSeries = passportSeries;
                    if (c.PassportNumber != passportNumber) c.PassportNumber = passportNumber;
                }
                var _client = new Client(this, c);
                int index = _repository._context.ClientsList.IndexOf(c);
                _repository._context.ClientsList.RemoveAt(index);
                _repository._context.ClientsList.Insert(index, _client);
                break;
            }
            _repository._context.SaveDataToDB();
        }
    }
}
