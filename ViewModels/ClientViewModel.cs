using SB_Module_10.Models;

namespace SB_Module_10.ViewModels
{
    public class ClientViewModel : ViewModelBase
    {
        private Client _selectedClient;
        private readonly ViewModelBase _viewModel;

        public string PassportData { get; set; }
        
        public Client SelectedClient { get => _selectedClient; set => SetProperty(ref _selectedClient, value); }

        public ClientViewModel(Client client, ViewModelBase viewModel)
        {
            _selectedClient = client;
            _viewModel = viewModel;

            if (_viewModel is ConsultantViewModel)
                PassportData = "**** ******";
            else PassportData = SelectedClient.PassportData;
        }
    }
}
