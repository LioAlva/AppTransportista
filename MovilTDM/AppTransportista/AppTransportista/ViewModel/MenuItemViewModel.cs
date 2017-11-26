using AppTransportista.Pages;
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
        public string Icon { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; }

        /******la lista******Dentro del listview de menu*/
        public ICommand NavigateCommand { get { return new RelayCommand(Navigate); } }

        private void Navigate()
        {
            switch (PageName)
            {
                case "AlarmsPage":
                    App.Navigator.PushAsync(new AlarmsPage());
                    break;
                case "ClientsPage":
                    App.Navigator.PushAsync(new ClientsPage());
                    break;
                case "SettingsPage":
                    App.Navigator.PushAsync(new SettingsPage());
                    break;
                case "MainPage":
                    App.Navigator.PopToRootAsync();
                    break;
                default:
                    break;
            }
        }
    }
}
