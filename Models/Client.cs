using System;
using System.Collections.Generic;

namespace SB_Module_10.Models
{
    public class Client 
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymics { get; set; }
        public string PhoneNumber { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
        public string PassportData { get => $"{PassportSeries} {PassportNumber}"; }
        public DateTime DataChangedTime { get; set; }
        public string ChangeInitiator { get; set; } 
        public Dictionary<string, string> Changes { get; set; } = new Dictionary<string, string>();

        public Client() { }
        public Client(string surname, string name, string patronymics, string phoneNumber, string passportSeries, string passportNumber)
        {
            Surname = surname;
            Name = name;
            Patronymics = patronymics;
            PhoneNumber = phoneNumber;
            PassportSeries = passportSeries;
            PassportNumber = passportNumber;
        }
        public Client(Client client) : this (client.Surname, client.Name, client.Patronymics, client.PhoneNumber, client.PassportSeries, client.PassportNumber) { }
        public Client(Employee employee, Client client, IEnumerable<KeyValuePair<string, string>> changes) 
            : this(client.Surname, client.Name, client.Patronymics, client.PhoneNumber, client.PassportSeries, client.PassportNumber)
        {
            ChangeInitiator = employee.ToString();
            DataChangedTime = DateTime.Now.ToLocalTime();
            Changes = new Dictionary<string, string>(changes);
        }

        public override string ToString() => $"{Surname}#{Name}#{Patronymics}#{PhoneNumber}#{Patronymics}";

    }
}
