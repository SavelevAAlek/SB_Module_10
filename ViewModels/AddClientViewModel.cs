using SB_Module_10.Models;
using SB_Module_10.ViewModels.Commands;
using System.Windows.Input;

namespace SB_Module_10.ViewModels
{
    public class AddClientViewModel : ViewModelBase
    {
        private readonly IManager _manager;

        public Client Client { get; private set; }

        public ICommand AddClientCommand { get; set; }

        public AddClientViewModel()
        {
            _manager = new Manager();
            AddClientCommand = new AddClientCommand(_manager, this);
        }
    }
}
