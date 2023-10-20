﻿using SB_Module_10.Models;
using System;
using System.Windows.Input;

namespace SB_Module_10.ViewModels.Commands
{
    public class EditClientCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private IConsultant _employee;
        private ViewModelBase _viewModel;

        public EditClientCommand(IConsultant employee, ViewModelBase viewModel)
        {
            _employee = employee;
            _viewModel = viewModel;
        }

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            _employee.EditClient((_viewModel as ConsultantViewModel).SelectedClient);
        }
    }
}
