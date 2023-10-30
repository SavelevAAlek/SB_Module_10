using SB_Module_10.ViewModels.Commands;
using System.Windows.Input;

namespace SB_Module_10.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _selectedViewModel;
        public ViewModelBase SelectedViewModel { get => _selectedViewModel; set => SetProperty(ref _selectedViewModel, value); }
        private bool _gridV;
        public bool GridV { get => _gridV; set => SetProperty(ref _gridV, value); }


        public ICommand SelectRoleCommand { get; set; }
        public MainWindowViewModel() 
        {
            GridV = true;
            SelectedViewModel = new AuthenticationViewModel(this);
            SelectRoleCommand = new AuthenticateCommand(this);
        }
    }
}
