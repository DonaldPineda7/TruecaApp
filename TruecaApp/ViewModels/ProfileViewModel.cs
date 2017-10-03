using TruecaApp.Classes;

namespace TruecaApp.ViewModels
{
    public class ProfileViewModel
    {
        public string UserName
        {
            get;
            set;
        }

        public string Picture
        {
            get;
            set;
        }

        public string Cover
        {
            get;
            set;
        }

        public ProfileViewModel(FacebookResponse profile)
        {
            UserName = profile.Name;
            Picture = profile.Picture.Data.Url;
            Cover = profile.Cover.Source;
        }
    }
}
