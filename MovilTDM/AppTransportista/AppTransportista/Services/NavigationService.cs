using AppTransportista.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTransportista.Services
{
    public class NavigationService
    {
        public void Navigate( string PageName)
        {
            App.Master.IsPresented = false;//esto desaparece y aparece la nueva pagina
            //ocultamos nenu lateral
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
                case "NewOrderPage":
                    App.Navigator.PushAsync(new NewOrderPage()); break;
                default:
                    break;
            }
        }
    }
}
