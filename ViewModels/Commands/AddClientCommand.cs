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
        private ManagerViewModel _managerVM;

        public AddClientCommand(Manager manager, ViewModelBase viewModel, ViewModelBase managerVM)
        {
            _managerVM = managerVM as ManagerViewModel;
            _manager = manager;
            _viewModel = viewModel;
        }

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            _manager.AddClientToDB((_viewModel as AddClientViewModel).Client);
            _managerVM.ClientsList.Add((_viewModel as AddClientViewModel).Client);
        }
    }
}
