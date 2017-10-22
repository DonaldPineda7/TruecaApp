using System;
using System.Threading.Tasks;
using TruecaApp.Classes;
using TruecaApp.Pages;
using TruecaApp.Services;
using TruecaApp.ViewModels;
using TruecaApp.Views;
using Xamarin.Forms;

namespace TruecaApp
{
    public partial class App : Application
    {

        #region attributes
        private ApiService apiService;

        #endregion


        public static Action HideLoginView
        {
            get
            {
                return new Action(() => App.Current.MainPage = new LoginPage());
            }
        }

        public async void NavigateToProfile(FacebookResponse profile)
        {
            var response = await apiService.LoginFacebook("", "/api", "/Users", profile);
        }

        #region Constructor
        public App()
        {
            InitializeComponent();

            apiService = new ApiService();
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

        #endregion 

    }
}
