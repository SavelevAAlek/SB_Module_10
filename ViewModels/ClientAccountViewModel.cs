using SB_Module_10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB_Module_10.ViewModels
{
    public class ClientAccountViewModel : ViewModelBase
    {
        private Client _client;
        public Client Client { get => _client; set => SetProperty(ref _client, value); }

        public ClientAccountViewModel(Client client)
        {
            Client = client;
        } 
    }
}
