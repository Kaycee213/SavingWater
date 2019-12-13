using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SavingWater.Models;
using SavingWater.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Water.Models;

/*namespace SavingWater.ViewModels
{

    public class SignUpPageViewModel : ViewModelBase
    {

        public SignUpPageViewModel(INavigationService navigationService )
            : base(navigationService)
        {
            Title = "SignUp";


        }

        private DelegateCommand _order;
        public DelegateCommand Order =>
   //         _order ?? (_order = new DelegateCommand(ExecuteOrder));
        private User _latestuser;
        public User LatestUser
        {
            get { return _latestuser; }
            set { SetProperty(ref _latestuser, value); }
        }


        async void ExecuteOrder()
        {
            var db = new UserDatabase();
            await db.InsertUser(LatestUser);
            //await _userdatabase.InsertUser(LatestUser);

        }
        
    }
}*/
