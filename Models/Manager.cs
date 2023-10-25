namespace SB_Module_10.Models
{
    public class Manager : Employee, IManager
    {
        public void AddClientToDB(Client client)
        {
            _repository._context.ClientsList.Add(client);
            _repository._context.SaveDataToDB();
        }

        public void DeleteClient(Client client)
        {
            if (client != null) _repository._context.ClientsList.Remove(client);
            _repository._context.SaveDataToDB();
        }

        public void EditClient(Client newDataClient)
        {
            var temporaryClient = new Client(_repository._context.ClientsList.Find(c => c.PassportData == newDataClient.PassportData));

            if (temporaryClient != null)
            {
                var differences = FindDifference(temporaryClient, newDataClient);
                var _client = new Client(this, newDataClient, differences);
                int index = _repository._context.ClientsList.FindIndex(c => c.PassportData == newDataClient.PassportData);
                if (index != -1)
                    _repository._context.ClientsList[index] = _client;

                _repository._context.SaveDataToDB();
            }
        }
    }
}
