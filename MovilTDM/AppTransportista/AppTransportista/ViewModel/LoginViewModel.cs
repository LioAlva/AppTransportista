using AppTransportista.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppTransportista.ViewModel
{
    public class LoginViewModel
    {
        #region Attributes
        private NavigationService navigationService;

        #endregion

        #region Properties
        public string User { get; set; }
        public string Password { get; set; }
        public string IsRemembered { get; set; }
        #endregion

        #region Constructor
        public LoginViewModel()
        {
            navigationService = new NavigationService();

        }
        #endregion

        #region Commands
        public ICommand LoginCommand { get{return new RelayCommand(Login); } }

        private void Login()
        {

        }
        #endregion
    }
}
