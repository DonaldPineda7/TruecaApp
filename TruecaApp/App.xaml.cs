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
        private static NavigationService navigationService;

        #endregion

        #region properties
        public static NavigationPage Navigator
        {
            get;
            set;
        }

        #endregion
        public static Action HideLoginView
        {
            get
            {
                return new Action(() => App.Current.MainPage = new LoginPage());
            }
        }

        public async static Task NavigateToProfile(FacebookResponse profile)
        {
            //var response = await apiService.LoginFacebook("", "/api", "/Users", profile);
            var mainViewModel = MainViewModel.GetInstance();
            mainViewModel.CurrentUser = new User
            {
                FirstName = profile.FirstName,
                LastName = profile.LastName,
                BirthDate = profile.BirthDate,
                Email = profile.Email,
                ProfilePicture = profile.Picture.Data.Url,
            };
            navigationService.SetMainPage("MasterPage");
        }

        #region Constructor
        public App()
        {
            InitializeComponent();

            apiService = new ApiService();
            navigationService = new NavigationService();
            MainPage = new LoginPage();
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
