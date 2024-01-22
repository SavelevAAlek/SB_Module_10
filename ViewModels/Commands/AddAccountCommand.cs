using SB_Module_10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SB_Module_10.ViewModels.Commands
{
    public class AddAccountCommand : ICommand
    {
        private Client _client;
        public event EventHandler? CanExecuteChanged;
        public AddAccountCommand(Client client)
        {
            _client = client;
        }
        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            if (parameter.ToString() == "Депозитный") _client.OpenDepositAccount();
            else _client.OpenNonDepositAccount();
        }
    }
}
