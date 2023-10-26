namespace SB_Module_10.Models
{
    public class Manager : Employee, IManager
    {
        public void AddClientToDB(Client client)
        {
            Repository._context.ClientsList.Add(client);
            Repository._context.SaveDataToDB();
        }

        public void DeleteClient(Client client)
        {
            if (client != null) Repository._context.ClientsList.Remove(client);
            Repository._context.SaveDataToDB();
        }

        public void EditClient(Client newDataClient)
        {
            var temporaryClient = new Client(Repository._context.ClientsList.Find(c => c.PassportData == newDataClient.PassportData || c.PhoneNumber == newDataClient.PhoneNumber));

            if (temporaryClient != null)
            {
                var differences = FindDifference(temporaryClient, newDataClient);
                var _client = new Client(this, newDataClient, differences);
                int index = Repository._context.ClientsList.FindIndex(c => c.PassportData == newDataClient.PassportData || c.PhoneNumber == newDataClient.PhoneNumber);
                if (index != -1)
                    Repository._context.ClientsList[index] = _client;

                Repository._context.SaveDataToDB();
            }
        }
    }
}
