using SB_Module_10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SB_Module_10.ViewModels.Commands
{
    public class EditClientCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private IConsultant _consultant;
        private ViewModelBase _viewModel;

        public EditClientCommand(IConsultant consultant, ViewModelBase viewModel)
        {
            _consultant = consultant;
            _viewModel = viewModel;
        }

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            
        }
    }
}
