using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SavingWater.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        private DelegateCommand _splash;
        public DelegateCommand Splash =>
            _splash ?? (_splash = new DelegateCommand(ExecuteSplashCommand));

        private DelegateCommand _water;
        public DelegateCommand Water =>
            _water ?? (_water = new DelegateCommand(ExecuteWaterCommand));

        private DelegateCommand _login;
        public DelegateCommand Login =>
            _login ?? (_login = new DelegateCommand(ExecuteLogin));

        async void ExecuteLogin()
        {
            await NavigationService.NavigateAsync("LoginPage");
        }

        async void ExecuteWaterCommand()
        {
            await NavigationService.NavigateAsync("ImportantInfo");
        }
      
       
       
        async void ExecuteSplashCommand()
        {
            await NavigationService.NavigateAsync("WhyIsWaterImportant");
        }
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }
    }
}
