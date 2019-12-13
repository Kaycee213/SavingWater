using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SavingWater.ViewModels
{
    public class OrderWaterViewModel : ViewModelBase
    {
        public OrderWaterViewModel(INavigationService navigationservice)
            : base(navigationservice)
        {

        }

        private DelegateCommand _checkout;
        public DelegateCommand CheckOut =>
            _checkout ?? (_checkout = new DelegateCommand(ExecuteCheckOut));

        async void ExecuteCheckOut()
        {
            await NavigationService.NavigateAsync("CheckOutPage");
        }

       
    }
}
