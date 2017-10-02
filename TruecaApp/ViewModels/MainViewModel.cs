using System;
using System.Collections.ObjectModel;

namespace TruecaApp.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<MenuItemViewModel> Menu
        {
            get;
            set;
        }

        public MainViewModel()
        {
            LoadMenu();
        }

        #region Methods
        private void LoadMenu()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();
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
				PageName = "",
				Title = "Politica de privacidad"
			});
        }
        #endregion

    }
}
