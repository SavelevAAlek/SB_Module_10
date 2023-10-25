using System;
using System.Windows.Input;

namespace SB_Module_10.ViewModels.Commands
{
    public class AuthenticateCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private MainWindowViewModel _viewModel;

        public AuthenticateCommand(MainWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            if (parameter.ToString() == "Manager" && _viewModel.SelectedViewModel is AuthenticationViewModel)
                _viewModel.SelectedViewModel = new ManagerViewModel();
            else if (parameter.ToString() == "Consultant" && _viewModel.SelectedViewModel is AuthenticationViewModel)
                _viewModel.SelectedViewModel = new ConsultantViewModel();
            else if (parameter.ToString() == "Change role" && _viewModel.SelectedViewModel is ManagerViewModel)
                _viewModel.SelectedViewModel = new AuthenticationViewModel(_viewModel);
            else if (parameter.ToString() == "Change role" && _viewModel.SelectedViewModel is ConsultantViewModel)
                _viewModel.SelectedViewModel = new AuthenticationViewModel(_viewModel);
        }
    }
}
