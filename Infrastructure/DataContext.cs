using Newtonsoft.Json;
using SB_Module_10.Models;
using System.Collections.Generic;
using System.IO;

namespace SB_Module_10.Infrastructure
{
    public class DataContext
    {
        private readonly string _dataPath = @"ClientsList.json";
        public List<Client> ClientsList { get; set; }
        public DataContext()
        {
            if (File.Exists(_dataPath))
            {
                ClientsList = ReadDataFromDB();
            }
            else
            {
                ClientsList = CreateTestData();
                SaveDataToDB();
            }
        }
        private List<Client> CreateTestData()
        {
            var clients = new List<Client>();
            for (int i = 0; i < 10; i++)
            {
                var client = new Client($"Surname {i}", $"Name {i}", $"Patronymics {i}", $"+7{i}", $"{i}", $"{i}");
                clients.Add(client);
            }
            return clients;
        }

        private List<Client> ReadDataFromDB()
        {
            using FileStream fs = new FileStream(_dataPath, FileMode.Open, FileAccess.Read);
            using StreamReader sr = new StreamReader(fs);
            var data = sr.ReadToEnd();
            List<Client>? clients = JsonConvert.DeserializeObject<List<Client>>(data);
            return clients;         
        }

        public void SaveDataToDB()
        {
            using FileStream fs = new FileStream(_dataPath, FileMode.Create, FileAccess.Write);
            using StreamWriter sw = new StreamWriter(fs);
            sw.Write(JsonConvert.SerializeObject(ClientsList));
            sw.Close();
        }
    }
}
