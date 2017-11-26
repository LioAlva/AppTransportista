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
        public async void Navigate( string PageName)
        {
            App.Master.IsPresented = false;//esto desaparece y aparece la nueva pagina
            //ocultamos nenu lateral
            switch (PageName)
            {
                case "AlarmsPage":
                    await App.Navigator.PushAsync(new AlarmsPage());
                    break;
                case "ClientsPage":
                    await App.Navigator.PushAsync(new ClientsPage());
                    break;
                case "SettingsPage":
                    await App.Navigator.PushAsync(new SettingsPage());
                    break;
                case "MainPage":
                    await App.Navigator.PopToRootAsync();
                    break;
                case "NewOrderPage":
                    await App.Navigator.PushAsync(new NewOrderPage()); break;
                default:
                    break;
            }
        }

        internal void SetMainPage()
        {
            //para que no quede el boton de para atras
            App.Current.MainPage = new MasterPage();
        }
    }
}
