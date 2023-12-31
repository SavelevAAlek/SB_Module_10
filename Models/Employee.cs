﻿using SB_Module_10.Infrastructure;
using System.Collections.Generic;

namespace SB_Module_10.Models
{
    public abstract class Employee
    {
        public Repository Repository;
        public Employee()
        {
            Repository = new Repository();
        }

        static protected IEnumerable<KeyValuePair<string, string>> FindDifference(Client oldData, Client newData)
        {
            var differences = new List<KeyValuePair<string, string>>();

            if (oldData != null && newData != null)
            {
                if (oldData.Name != newData.Name)
                    differences.Add(new KeyValuePair<string, string>($"Имя", oldData.Name));
                if (oldData.Surname != newData.Surname)
                    differences.Add(new KeyValuePair<string, string>($"Фамилия", oldData.Surname));
                if (oldData.Patronymics != newData.Patronymics)
                    differences.Add(new KeyValuePair<string, string>($"Отчество", oldData.Patronymics));
                if (oldData.PhoneNumber != newData.PhoneNumber)
                    differences.Add(new KeyValuePair<string, string>($"Номер телефона", oldData.PhoneNumber));
                if (oldData.PassportSeries != newData.PassportSeries)
                    differences.Add(new KeyValuePair<string, string>($"Серия паспорта", oldData.PassportSeries));
                if (oldData.PassportNumber != newData.PassportNumber)
                    differences.Add(new KeyValuePair<string, string>($"Номер паспорта", oldData.PassportNumber));
            }
            return differences;
        }

        public override string ToString()
        {
            if (this is Manager) return "Менеджер";
            else return "Консультант";
        }
    }
}
