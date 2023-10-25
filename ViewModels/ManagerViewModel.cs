using SB_Module_10.Infrastructure;
using SB_Module_10.Models;
using SB_Module_10.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace SB_Module_10.ViewModels
{
    public class ManagerViewModel : ViewModelBase
    {
        private readonly IRepository _repository;
        private readonly IManager _manager;
        private ObservableCollection<Client> _clientsList;
        private string _desiredClientsData = "";
        private Client _selectedClient;
        private ViewModelBase _clientControl;

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
                    SetProperty (ref _selectedClient, value);
                    ClientControl = new ClientViewModel(SelectedClient, this);
                }
            }
        }

        public ICommand EditClientCommand { get; set; }

        public ManagerViewModel()
        {
            _manager = new Manager();
            _repository = new Repository();
            ClientsList = new ObservableCollection<Client>(_repository.GetList());
            EditClientCommand = new EditClientCommand(_manager, this);
        }
    }
}
