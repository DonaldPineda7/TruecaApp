using TruecaApp.Pages;

namespace TruecaApp.Services
{
    public class NavigationService
    {
        public void SetMainPage(string pageName)
        {
            switch(pageName)
            {
                case "MasterPage":
                    App.Current.MainPage = new MasterPage();
                    break;
                case "LoginPage":
                    App.Current.MainPage = new LoginPage();
                    break;
                case "LoginFacebookPage":
                    App.Current.MainPage = new LoginFacebookPage();
                    break;
                default:
                    break;
            }
        }
    }
}
