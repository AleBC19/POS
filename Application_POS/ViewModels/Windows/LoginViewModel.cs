using Application_POS.Commands;
using Application_POS.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Application_POS.ViewModels.Windows
{
    class LoginViewModel : ViewModelBase
    {
        public ICommand viewMainPage {  get; set; }
        public LoginViewModel(NavigationStore navigationStore)
        {
            viewMainPage = new NavigateCommand<MainPageViewModel>(navigationStore, () => new MainPageViewModel(navigationStore));
        }
    }
}
