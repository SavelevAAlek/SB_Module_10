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
        public void EditClient(Client newDataClient)
        {
            var temporaryClient = new Client(_repository._context.ClientsList.Find(c => c.PassportData == newDataClient.PassportData));

            if (temporaryClient != null )
            {
                var differences = FindDifference(temporaryClient, newDataClient);
                var _client = new Client(this, newDataClient, differences);
                int index = _repository._context.ClientsList.FindIndex(c => c.PassportData == newDataClient.PassportData);
                if (index != -1 )
                    _repository._context.ClientsList[index] = _client;

                _repository._context.SaveDataToDB();
            }

        }
        private IEnumerable<KeyValuePair<string, string>> FindDifference(Client oldData, Client newData)
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
    }
}
