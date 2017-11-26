using AppTransportista.Pages;
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
    public class MenuItemViewModel//un item de la lista menu
    {
        #region Properties
        public NavigationService navigationService;
        #endregion

        #region Atributtes
            public string Icon { get; set; }
            public string Title { get; set; }
            public string PageName { get; set; }
        #endregion

        #region Constructor
        public MenuItemViewModel()
        {
            navigationService = new NavigationService();
        }
        #endregion
        /******la lista******Dentro del listview de menu*/
        public ICommand NavigateCommand { get { return new RelayCommand(Navigate); } }

        private void Navigate()
        {
            navigationService.Navigate(PageName);
        }
    }
}
