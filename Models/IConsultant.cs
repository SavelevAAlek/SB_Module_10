using SB_Module_10.Infrastructure;

namespace SB_Module_10.Models
{
    public interface IConsultant
    {
        void EditClient(Client client, string surname, string name, string patronymic, string phoneNumber, string passportSeries, string passportNumber);
    }
}