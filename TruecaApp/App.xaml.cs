using System;
using System.Threading.Tasks;
using TruecaApp.Classes;
using TruecaApp.Pages;
using TruecaApp.ViewModels;
using TruecaApp.Views;
using Xamarin.Forms;

namespace TruecaApp
{
    public partial class App : Application
    {
       
        #region Constructor
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MasterPage());
        }
        #endregion

        #region Methods
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static Action HideLoginView
        {
            get
            {
                return new Action(() => App.Current.MainPage = new LoginPage());
            }
        }

        public async static Task NavigateToProfile(FacebookResponse profile)
        {
            var profileViewModel = new ProfileViewModel(profile);
            var mainViewModel = MainViewModel.GetInstance();
            mainViewModel.Profile = profileViewModel;
            App.Current.MainPage = new ProfilePage();
        }

        #endregion 

    }
}
