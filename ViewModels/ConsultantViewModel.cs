using SB_Module_10.Infrastructure;
using SB_Module_10.Models;
using SB_Module_10.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SB_Module_10.ViewModels
{
    public class ConsultantViewModel : ViewModelBase
    {
        private readonly IRepository _repository;
        private readonly IConsultant _consultant;
        private ObservableCollection<Client> _clientsList;
        private string _desiredClientsData = "";
        private Client _selectedClient;

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
        public Client SelectedClient {  get => _selectedClient; set =>  SetProperty(ref _selectedClient, value);}
        
        public ICommand EditClientCommand { get; set; }

        public ConsultantViewModel()
        {
            _consultant = new Consultant();
            _repository = new Repository();
            ClientsList = new ObservableCollection<Client>(_repository.GetList());
            EditClientCommand = new EditClientCommand(_consultant, this);
        }
    }
}
