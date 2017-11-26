using AppTransportista.Pages;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppTransportista.ViewModel
{
    public class MainViewModel//la reina detodas las clases
    {//oservable necesito verlo desde la vista del menu
        #region Properties
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }

        public ObservableCollection<OrderViewModel> Orders { get; set; }
        #endregion
        #region Constructors
        public MainViewModel()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();
            Orders = new ObservableCollection<OrderViewModel>();
            LoadMenu();
            LoadFakeData();
        }
        #endregion
        #region Methods

        private void LoadFakeData()
        {
            for (int i = 0; i < 10; i++)
            {
                Orders.Add(new OrderViewModel
                {
                    Title = "Lorem Ipsum",
                    DeliveryDate = DateTime.Today,
                    Description = "Lorem Ipsum dolor sit amet" +
                    "amet dolor sip elt,se ionjnkjnkjnjknkjnkj" +
                    "jnjnjnkjnjknkj"
                });
            }
        }

        private void LoadMenu()
        {//add los elementos del menu
            Menu.Add(
                new MenuItemViewModel
                {
                    Icon = "ic_action_orders.png",
                    PageName = "MainPage",
                     Title = "Pedidos"
                }
                );
            Menu.Add(
               new MenuItemViewModel
               {
                   Icon = "ic_action_customers.png",
                   PageName = "ClientsPage",
                   Title = "Clientes"
               }
               );
            Menu.Add(
               new MenuItemViewModel
               {
                   Icon = "ic_action_alarms.png",
                   PageName = "AlarmsPage",
                    Title = "Alarmas"
               }
               );
            Menu.Add(
               new MenuItemViewModel
               {
                   Icon = "ic_action_settings.png",
                   PageName = "SettingsPage",
                    Title = "Ajustes"
               }
               );

        }
        #endregion

        #region Commands
        public ICommand GotoCommand { get { return new RelayCommand<string>(Goto); } }

        private void Goto(string pageName)
        {
            switch (pageName)
            {
                case "NewOrderPage":
                    App.Navigator.PushAsync(new NewOrderPage());break;
                default:;break;
            }
        }
        #endregion
    }
}
