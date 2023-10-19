using SB_Module_10.Infrastructure;
using SB_Module_10.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SB_Module_10.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _selectedViewModel;
        public ViewModelBase SelectedViewModel { get => _selectedViewModel; set => SetProperty(ref _selectedViewModel, value); }

        public ICommand SelectRoleCommand { get; set; }
        public MainWindowViewModel() 
        {
            SelectedViewModel = new AuthenticationViewModel(this);
            SelectRoleCommand = new AuthenticateCommand(this);
        }
    }
}
