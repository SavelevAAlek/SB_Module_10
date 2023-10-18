namespace SB_Module_10.Models
{
    public interface IManager : IConsultant
    {
        void EditName(Client client, string name);
        void EditSurname(Client client, string surname);
        void EditPatronymics(Client client, string patronymics);
        void EditPassportSeries(Client client, string passportSeries);
        void EditPassportNumber(Client client, string passportNumber);
        void DeleteClient(Client client);
        void AddClientToDB(string surname, string name, string phoneNumber, string passportSeries, string passportNumber, string patronymics = null);
    }
}