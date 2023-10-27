using SB_Module_10.Models;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace SB_Module_10.ViewModels.Commands
{
    public class DeleteClientCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        public event PropertyChangedEventHandler? PropertyChanged;

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
            var vm = _viewModel as ManagerViewModel;
            _employee.DeleteClient(vm.SelectedClient);
            vm.ClientsList.Remove(vm.SelectedClient);
        }
    }
}

