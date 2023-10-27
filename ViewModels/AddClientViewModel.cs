﻿using SB_Module_10.Models;
using SB_Module_10.ViewModels.Commands;
using System.Windows.Input;

namespace SB_Module_10.ViewModels
{
    public class AddClientViewModel : ViewModelBase
    {
        private readonly Manager _manager;
        private Client _client = new Client();
        private ViewModelBase _managerVM;
        public Client Client { get => _client; set => SetProperty(ref _client, value); }

        public ICommand AddClientCommand { get; set; }

        public AddClientViewModel(Manager manager, ViewModelBase viewModel)
        {
            _managerVM = viewModel;
            _manager = manager;
            AddClientCommand = new AddClientCommand(_manager, this, _managerVM);
        }
    }
}
