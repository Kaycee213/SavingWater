using Prism;
using Prism.Ioc;
using PrismMapsExample.Views;
using SavingWater.ViewModels;
using SavingWater.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SavingWater
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("WhyIsWaterImportant/NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {


            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
       
            containerRegistry.RegisterForNavigation<WhyIsWaterImportant, WhyIsWaterImportantViewModel>();
            containerRegistry.RegisterForNavigation<ImportantInfo, ImportantInfoViewModel>();

            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            //containerRegistry.RegisterForNavigation<SignUpPage, SignUpPageViewModel>();
            containerRegistry.RegisterForNavigation<OrderWater, OrderWaterViewModel>();
            containerRegistry.RegisterForNavigation<CheckOutPage, CheckOutPageViewModel>();

            //  containerRegistry.RegisterForNavigation<MapsView, MapsViewViewModel>();
            //  containerRegistry.RegisterForNavigation<MapsView, MapsViewViewModel>();

            containerRegistry.RegisterForNavigation<SignUpCopy, SignUpCopyViewModel>();
        }
    }

    internal class SignUpCopyViewModel
    {
    }
}
