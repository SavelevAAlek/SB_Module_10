using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB_Module_10.Models
{
    public class Client 
    {
        private Employee _employee;
        private DateTime _date;
        private string _fieldChanged;
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymics { get; set; }
        public string PhoneNumber { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
        public string PassportData { get => $"{PassportSeries} {PassportNumber}"; }
        public DateTime DataChangedTime { get => _date; set { _date = DateTime.Now; } }
        public string FieldChanged { get; set; }
        public string DataTypeChanged { get; set; }
        public object ChangeInitiator { get => _employee.ToString(); }

        public Client() { }
        public Client(Employee employee, Client client)
        {
            _employee = employee;   
        }
        public Client(string surname, string name, string patronymics, string phoneNumber, string passportSeries, string passportNumber)
        {
            Surname = surname;
            Name = name;
            Patronymics = patronymics;
            PhoneNumber = phoneNumber;
            PassportSeries = passportSeries;
            PassportNumber = passportNumber;
        }

        public override string ToString() => $"{Surname}#{Name}#{Patronymics}#{PhoneNumber}#{Patronymics}";

    }
}
