using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTransportista.ViewModel
{
    public class MainViewModel//la reina detodas las clases
    {//oservable necesito verlo desde la vista del menu
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }

        public ObservableCollection<OrderViewModel> Orders { get; set; }
        public MainViewModel()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();
            Orders = new ObservableCollection<OrderViewModel>();
            LoadMenu();
            LoadFakeData();
        }

        private void LoadFakeData()
        {
            for (int i = 0; i < 10; i++)
            {
                Orders.Add(new OrderViewModel {
                    Title="Lorem Ipsum",
                    DeliveryDate=DateTime.Today,
                    Description="Lorem Ipsum dolor sit amet" +
                    "amet dolor sip elt,se ionjnkjnkjnjknkjnkj" +
                    "jnjnjnkjnjknkj"
                });
            }
        }

        private void LoadMenu()
        {//add los elementos del menu
            Menu.Add(
                new MenuItemViewModel {
                    Icon = "ic_action_orders.png",
                    Title="MainPage",
                    PageName="Pedidos"
                }
                );
            Menu.Add(
               new MenuItemViewModel
               {
                   Icon = "ic_action_customers.png",
                   Title = "ClientsPage",
                   PageName = "Clientes"
               }
               );
            Menu.Add(
               new MenuItemViewModel
               {
                   Icon = "ic_action_alarms.png",
                   Title = "AlarmsPage",
                   PageName = "Alarmas"
               }
               );
            Menu.Add(
               new MenuItemViewModel
               {
                   Icon = "ic_action_settings.png",
                   Title = "SettingsPage",
                   PageName = "Ajustes"
               }
               );

        }
    }
}
