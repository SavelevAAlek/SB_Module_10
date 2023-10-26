using SB_Module_10.Infrastructure;
using SB_Module_10.Models;
using System.Collections.ObjectModel;

namespace SB_Module_10.ViewModels
{
    public class ConsultantViewModel : ViewModelBase
    {
        private readonly IRepository _repository;
        private ObservableCollection<Client> _clientsList;
        private string _desiredClientsData = "";
        private Client _selectedClient;
        private ViewModelBase _clientControl;
        private readonly Consultant _employee;

        public ViewModelBase ClientControl { get => _clientControl; set => SetProperty(ref _clientControl, value); }
        public ObservableCollection<Client> ClientsList { get => _clientsList; set => SetProperty(ref _clientsList, value); }
        public string DesiredClientsData
        {
            get => _desiredClientsData;
            set
            {
                _desiredClientsData = value;
                if (_desiredClientsData != "")
                    ClientsList = new ObservableCollection<Client>(_repository.GetClient(DesiredClientsData));
                else
                    ClientsList = new ObservableCollection<Client>(_repository.GetList());
            }
        }
        public Client SelectedClient
        {
            get => _selectedClient;
            set
            {
                if (value != null)
                {
                    SetProperty(ref _selectedClient, value);
                    ClientControl = new ClientViewModel(SelectedClient, this, _employee);
                }
            }
        }


        public ConsultantViewModel()
        {         
            _repository = new Repository();
            _employee = new Consultant();
            ClientsList = new ObservableCollection<Client>(_repository.GetList());
        }
    }
}
