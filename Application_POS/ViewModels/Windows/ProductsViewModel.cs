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
    class ProductsViewModel : MainPageViewModel
    {
        public ICommand viewAddProduct {  get; set; }
        public ProductsViewModel(NavigationStore navigationStore) : base(navigationStore)
        {
            viewAddProduct = new NavigateCommand<AddProductViewModel>(navigationStore, () => new AddProductViewModel(navigationStore));
        }

    }
}
