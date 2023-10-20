using SB_Module_10.Models;
using System;

using System.Windows.Input;

namespace SB_Module_10.ViewModels.Commands
{
    public class AddClientCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private IManager _employee;
        private ViewModelBase _viewModel;

        public AddClientCommand(IManager employee, ViewModelBase viewModel)
        {
            _employee = employee;
            _viewModel = viewModel;
        }

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            _employee.AddClientToDB(
                (_viewModel as AddClientViewModel).Surname,
                (_viewModel as AddClientViewModel).Name,
                (_viewModel as AddClientViewModel).Patronymics,
                (_viewModel as AddClientViewModel).PhoneNumber,
                (_viewModel as AddClientViewModel).PassportSeries,
                (_viewModel as AddClientViewModel).PassportNumber);
        }
    }
}
