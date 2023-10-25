namespace SB_Module_10.Models
{
    public interface IManager : IConsultant
    {
        void DeleteClient(Client client);
        void AddClientToDB(Client client);
    }
}