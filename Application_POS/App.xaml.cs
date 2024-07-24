using Application_POS.Navigation;
using Application_POS.ViewModels;
using Application_POS.ViewModels.Windows;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Application_POS
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            NavigationStore navigationStore = new NavigationStore();

            navigationStore.CurrentViewModel = new LoginViewModel(navigationStore);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);

        }
    }

}
