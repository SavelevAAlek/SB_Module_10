using SB_Module_10.Models;
using SB_Module_10.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SB_Module_10.ViewModels
{
    public class AccountCreationViewModel : ViewModelBase
    {
        private Client _client;
        private string _accountType;

        public string AccountType { get => _accountType; set => SetProperty(ref _accountType, value); }
        public Client Client { get => _client; set => SetProperty(ref _client, value); }

        public ICommand CreateAccoutCommand { get; }
        public AccountCreationViewModel(Client client)
        {
            _client = client;
            CreateAccoutCommand = new AddAccountCommand(_client);
        }
    }
}
