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
    internal class AddProductViewModel : ViewModelBase
    {
        public ICommand viewProducts {  get; set; }

        public AddProductViewModel (NavigationStore navigationStore)
        {
            viewProducts = new NavigateCommand<ProductsViewModel>(navigationStore, () => new ProductsViewModel(navigationStore));
        }
    }
}
