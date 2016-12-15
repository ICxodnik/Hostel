using DbLayer;
using DbLayer.Tables;
using Hostel.Pages;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hostel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static RoutedUICommand OrderService = new RoutedUICommand(
                "Order a Service",
                "OrderService",
                typeof(MainWindow)
            );
        public static RoutedUICommand MakeOrder = new RoutedUICommand(
            "Make an order of selected service",
            "MakeOrder",
            typeof(MainWindow)
        );

        public MainWindow()
        {
            InitializeComponent();
        }

        static Dictionary<String, Func<Page>> pages = new Dictionary<string, Func<Page>> {
            { "deliver", () => new ServicePage(Service.ServiceType.Deliver) },
            { "food", () => new ServicePage(Service.ServiceType.Food) },
            { "cleaning", () => new ServicePage(Service.ServiceType.Cleaning) },
            { "spa", () => new ServicePage(Service.ServiceType.Spa) },
            { "excursion", () => new ServicePage(Service.ServiceType.Excursion) }
        };

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var type = (sender as Button).Tag.ToString();

            Func<Page> pageFactory;
            if (pages.TryGetValue(type, out pageFactory))
            {
                OrderSettings.NavigationService.Navigate(pageFactory());
            }
        }

        private void OrderAService(object sender, ExecutedRoutedEventArgs e)
        {
            var service = e.Parameter as Service;
            if (service == null)
            {
                return;
            }

            OrderPopup.DataContext = service;
            OrderPopup.IsOpen = true;
        }

        private void MakeNewOrder(object sender, ExecutedRoutedEventArgs e)
        {
            OrderPopup.DataContext = null;
            OrderPopup.IsOpen = false;
            var service = e.Parameter as Service;
            if (service == null)
            {
                return;
            }

            var order = new ServiceOrder()
            {
                ProvidedDate = DateTime.Now,
                Service = service,
                CashPaid = service.Price,
                Client = null
            };

            DbRepository.Context.Orders.Add(order);
            DbRepository.Context.SaveChanges();
        }
    }
}
