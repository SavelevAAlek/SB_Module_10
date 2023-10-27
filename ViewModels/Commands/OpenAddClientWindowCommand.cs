using SB_Module_10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SB_Module_10.ViewModels.Commands
{
    public class OpenAddClientWindowCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private readonly ViewModelBase _viewModel;
        private readonly Manager _manager;

        public OpenAddClientWindowCommand(ViewModelBase viewModel, Manager manager)
        {
            _viewModel = viewModel;
            _manager = manager;
        }

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter) => (_viewModel as ManagerViewModel).ClientControl = new AddClientViewModel(_manager, _viewModel);
    }
}
