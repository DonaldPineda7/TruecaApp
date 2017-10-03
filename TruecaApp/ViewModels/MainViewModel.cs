using System;
using System.Collections.ObjectModel;

namespace TruecaApp.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        public LoginViewModel Login
        {
            get;
            set;
        }

        public ObservableCollection<MenuItemViewModel> Menu
        {
            get;
            set;
        }

        public ProfileViewModel Profile
        {
            get;
            set;
        }
        #endregion

        #region Constructor
        public MainViewModel()
        {
            LoadMenu();
            Login = new LoginViewModel();
        }
        #endregion

        #region Methods
        private void LoadMenu()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();

			Menu.Add(new MenuItemViewModel
			{
				Icon = "",
				PageName = "LoginPage",
				Title = "Login"
			});

            Menu.Add(new MenuItemViewModel
            {
                Icon ="icons8-Info-100.png",
                PageName="",
                Title = "Acerca de Trueca"
            });

			Menu.Add(new MenuItemViewModel
			{
				Icon = "",
				PageName = "",
				Title = "Ayuda"
			});

			Menu.Add(new MenuItemViewModel
			{
				Icon = "",
				PageName = "",
				Title = "Consejos de seguridad"
			});

			Menu.Add(new MenuItemViewModel
			{
				Icon = "",
				PageName = "",
				Title = "Normas de la comunidad"
			});

			Menu.Add(new MenuItemViewModel
			{
				Icon = "",
				PageName = "",
				Title = "Terminos y Condiciones"
			});

			Menu.Add(new MenuItemViewModel
			{
				Icon = "",
				PageName = "LoginPage",
				Title = "Logout"
			});
        }
        #endregion

    }
}
