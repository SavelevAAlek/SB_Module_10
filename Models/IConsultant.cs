using SB_Module_10.Infrastructure;

namespace SB_Module_10.Models
{
    public interface IConsultant
    {
        void EditPhoneNumber(Client client, string phoneNumber);
    }
}