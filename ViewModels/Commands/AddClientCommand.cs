using SB_Module_10.Models;
using System;

using System.Windows.Input;

namespace SB_Module_10.ViewModels.Commands
{
    public class AddClientCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private Manager _manager;
        private ViewModelBase _viewModel;

        public AddClientCommand(Manager manager, ViewModelBase viewModel)
        {
            _manager = manager;
            _viewModel = viewModel;
        }

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            _manager.AddClientToDB((_viewModel as AddClientViewModel).Client);
        }
    }
}
