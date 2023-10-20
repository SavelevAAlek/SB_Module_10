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
    public class AddClientViewModel : ViewModelBase
    {
        private readonly IManager _manager;

        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymics { get; set; }
        public string PhoneNumber { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }

        public ICommand AddClientCommand { get; set; }

        public AddClientViewModel()
        {
            _manager = new Manager();
            AddClientCommand = new AddClientCommand(_manager, this);
        }
    }
}
