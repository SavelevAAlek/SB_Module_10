using SB_Module_10.Models;
using SB_Module_10.ViewModels.Commands;
using System.Windows.Input;

namespace SB_Module_10.ViewModels
{
    public class AddClientViewModel : ViewModelBase
    {
        private readonly Manager _manager;
        private Client _client = new Client();
        public Client Client { get => _client; set => SetProperty(ref _client, value); }

        public ICommand AddClientCommand { get; set; }

        public AddClientViewModel(Manager manager)
        {
            _manager = manager;
            AddClientCommand = new AddClientCommand(_manager, this);
        }
    }
}
