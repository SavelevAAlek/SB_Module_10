using SB_Module_10.Models;
using System;
using System.Windows.Input;

namespace SB_Module_10.ViewModels.Commands
{
    public class DeleteClientCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private IManager _employee;
        private ViewModelBase _viewModel;

        public DeleteClientCommand(IManager employee, ViewModelBase viewModel)
        {
            _employee = employee;
            _viewModel = viewModel;
        }

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            _employee.DeleteClient((_viewModel as ManagerViewModel).SelectedClient);
        }
    }
}
