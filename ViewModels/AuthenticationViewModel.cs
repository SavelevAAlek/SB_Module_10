using SB_Module_10.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SB_Module_10.ViewModels
{
    public class AuthenticationViewModel : ViewModelBase
    {
        public ICommand SelectRoleCommand { get; set; }
        public AuthenticationViewModel(MainWindowViewModel mainWindowViewModel)
        {
            SelectRoleCommand = new AuthenticateCommand(mainWindowViewModel);
        }
    }
}
