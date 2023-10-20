namespace SB_Module_10.Models
{
    public interface IManager : IConsultant
    {
        void DeleteClient(Client client);
        void AddClientToDB(string surname, string name, string patronymics, string phoneNumber, string passportSeries, string passportNumber);
    }
}