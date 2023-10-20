using SB_Module_10.Infrastructure;
using System.Collections.Generic;

namespace SB_Module_10.Models
{
    public abstract class Employee
    {
        protected Repository _repository;
        public Employee()
        {
            _repository = new Repository();
        }

        protected IEnumerable<KeyValuePair<string, string>> FindDifference(Client oldData, Client newData)
        {
            var differences = new List<KeyValuePair<string, string>>();

            if (oldData != null && newData != null)
            {
                if (oldData.Name != newData.Name)
                    differences.Add(new KeyValuePair<string, string>($"Изменено поле Name", $"Было: {oldData.Name}"));
                if (oldData.Surname != newData.Surname)
                    differences.Add(new KeyValuePair<string, string>($"Изменено поле Surname", $"Было: {oldData.Surname}"));
                if (oldData.Patronymics != newData.Patronymics)
                    differences.Add(new KeyValuePair<string, string>($"Изменено поле Patronymics", $"Было: {oldData.Patronymics}"));
                if (oldData.PhoneNumber != newData.PhoneNumber)
                    differences.Add(new KeyValuePair<string, string>($"Изменено поле PhoneNumber", $"Было: {oldData.PhoneNumber}"));
                if (oldData.PassportSeries != newData.PassportSeries)
                    differences.Add(new KeyValuePair<string, string>($"Изменено поле PassportSeries", $"Было: {oldData.PassportSeries}"));
                if (oldData.PassportNumber != newData.PassportNumber)
                    differences.Add(new KeyValuePair<string, string>($"Изменено поле PassportNumber", $"Было: {oldData.PassportNumber}"));
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
