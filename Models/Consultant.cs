namespace SB_Module_10.Models
{
    public class Consultant : Employee, IConsultant
    {
        public void EditClient(Client newDataClient)
        {
            var temporaryClient = new Client(Repository._context.ClientsList.Find(c => c.PassportData == newDataClient.PassportData));

            if (temporaryClient != null )
            {
                var differences = FindDifference(temporaryClient, newDataClient);
                var _client = new Client(this, newDataClient, differences);
                int index = Repository._context.ClientsList.FindIndex(c => c.PassportData == newDataClient.PassportData);
                if (index != -1 )
                    Repository._context.ClientsList[index] = _client;

                Repository._context.SaveDataToDB();
            }
        }
        
    }
}
