using System.ComponentModel;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using TruecaApp.Services;

namespace TruecaApp.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private NavigationService navigationService;

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Attributes
        private bool _isEnable;
        #endregion

        #region Properties
        public bool IsEnable
        {
            get
            {
                return _isEnable;
            }
            set
            {
                if(_isEnable != value){
                    _isEnable = value;
                    PropertyChanged?.Invoke(
                        this, 
                        new PropertyChangedEventArgs("IsEnable"));
                }
            }
        }

        #endregion
        #region Constructor
        public LoginViewModel()
        {
            IsEnable = true;
            navigationService = new NavigationService();
        }
        #endregion

        #region Commands
        public ICommand LoginFacebookCommand
        {
            get
            {
                return new RelayCommand(LoginFacebook);
            }
        }

        private async void LoginFacebook()
        {
            await navigationService.Navigate("LoginFacebookPage");
        }
        #endregion


    }
}
