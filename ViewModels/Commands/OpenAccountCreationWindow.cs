using SB_Module_10.Models;
using SB_Module_10.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SB_Module_10.ViewModels.Commands
{
    public class OpenAccountCreationWindow : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        Client _client;
        public OpenAccountCreationWindow(Client client)
        {
            _client = client;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            AccountCreationWindow window = new AccountCreationWindow();
            window.DataContext = new AccountCreationViewModel(_client);
            window.ShowDialog();
        }
    }
}
