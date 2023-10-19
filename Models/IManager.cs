namespace SB_Module_10.Models
{
    public interface IManager : IConsultant
    {
        void EditClient(Client client, string surname, string name, string patronymic, string phoneNumber, string passportSeries, string passportNumber);
        void DeleteClient(Client client);
        void AddClientToDB(string surname, string name, string phoneNumber, string passportSeries, string passportNumber, string patronymics = null);
    }
}