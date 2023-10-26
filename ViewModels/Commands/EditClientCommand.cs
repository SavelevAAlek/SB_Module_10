using SB_Module_10.Models;
using System;
using System.Windows.Input;

namespace SB_Module_10.ViewModels.Commands
{
    public class EditClientCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private Employee _employee;
        private ClientViewModel _clientViewModel;
        private ViewModelBase _employeeViewModel;

        public EditClientCommand(ClientViewModel clientViewModel, ViewModelBase employeeViewModel, Employee employee)
        {
            _clientViewModel = clientViewModel;
            _employeeViewModel = employeeViewModel;
            _employee = employee;
        }

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            if (_employeeViewModel is ConsultantViewModel)
                (_employee as Consultant).EditClient(_clientViewModel.SelectedClient);
            else if (_employeeViewModel is ManagerViewModel)
                (_employee as Manager).EditClient(_clientViewModel.SelectedClient);
        }
    }
}
