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
                Icon = "icons8-Male User-100.png",
                PageName = "LoginPage",
                Title = "Conectate"
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon ="icons8-Info-100.png",
                PageName="AboutPage",
                Title = "Acerca de Trueca"
            });

			Menu.Add(new MenuItemViewModel
			{
				Icon = "icons8-Help-100.png",
				PageName = "HelpPage",
				Title = "Ayuda"
			});

			Menu.Add(new MenuItemViewModel
			{
				Icon = "icons8-Quote-100.png",
				PageName = "AdvicePage",
				Title = "Consejos de seguridad"
			});

			Menu.Add(new MenuItemViewModel
			{
				Icon = "icons8-Rules-100.png",
				PageName = "RulesPage",
				Title = "Normas de la comunidad"
			});

			Menu.Add(new MenuItemViewModel
			{
				Icon = "icons8-Term-100.png",
				PageName = "TermsPage",
				Title = "Terminos y Condiciones"
			});
			
        }
        #endregion

    }
}
