using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SavingWater.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        public LoginPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Login";

        }

        private DelegateCommand _signup;
        public DelegateCommand SignUp =>
            _signup ?? (_signup = new DelegateCommand(ExecuteSignUp));

        private DelegateCommand _order;
        public DelegateCommand Order =>
            _order ?? (_order = new DelegateCommand(ExecuteOrder));

        public async void ExecuteOrder()
        {
            await NavigationService.NavigateAsync("OrderWater");
        }
        public async void ExecuteSignUp()
        {
            await NavigationService.NavigateAsync("SignUpCopy");
            //await NavigationService.NavigateAsync("SignUpPage");
        }
    }
}
