using SB_Module_10.Models;
using SB_Module_10.ViewModels.Commands;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SB_Module_10.ViewModels
{
    public class ClientViewModel : ViewModelBase
    {
        private Client _selectedClient;
        private readonly ViewModelBase _employeeViewModel;
        private readonly Employee _employee;
        public bool GridVisibility { get; set; }

        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }

        public Client SelectedClient { get => _selectedClient; set => SetProperty(ref _selectedClient, value); }

        public ICommand EditClientCommand { get; set; } 
        public ICommand OpenAccountCreationCommand { get; set; }

        public ClientViewModel(Client client, ViewModelBase employeeViewModel, Employee employee)
        {
            _selectedClient = client;
            _employeeViewModel = employeeViewModel;
            _employee = employee;

            if (_employeeViewModel is ConsultantViewModel)
            {
                PassportSeries = "****";
                PassportNumber = "******";
                GridVisibility = true;
            }
            else 
            {
                PassportSeries = SelectedClient.PassportSeries;
                PassportNumber = SelectedClient.PassportNumber;
                GridVisibility = false;
            }

            EditClientCommand = new EditClientCommand(this, _employeeViewModel, _employee);
            OpenAccountCreationCommand = new OpenAccountCreationWindow(_selectedClient);
        }
        public ClientViewModel(ViewModelBase viewModel, Employee employee) { }
    }
}
