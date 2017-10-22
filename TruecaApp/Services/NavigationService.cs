using System.Threading.Tasks;
using TruecaApp.Pages;

namespace TruecaApp.Services
{
    public class NavigationService
    {
        public async Task Navigate(string pageName)
        {
            switch(pageName)
            {
                case "MasterPage":
                    await App.Current.MainPage.Navigation.PushAsync(new MasterPage());
                    break;
                case "LoginPage":
                    await App.Current.MainPage.Navigation.PushAsync(new LoginPage());
                    break;
                default:
                    break;
            }
        }

        public async Task Back()
        {
            await App.Current.MainPage.Navigation.PopAsync();
        }
    }
}
