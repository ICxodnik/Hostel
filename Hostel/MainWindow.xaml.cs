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
        public MainWindow()
        {
            InitializeComponent();


            // when db will be ready
            // 
            using (var context = new HotelPlazaContext())
            {
                var client = new Client()
                {
                    Id = 1,
                    FirstName = "Abdula Akazov",
                    Address = "Manhatten??",
                    Passport = "RK93849340"
                };

                context.Clients.Add(client);
                var resultCode = context.SaveChanges();
            }

        }

        static Dictionary<String, Func<Page>> pages = new Dictionary<string, Func<Page>> {
            { "deliver", () => new DeliverPage() },
            { "food", () => new FoodPage() },
            { "cleaning", () => new CleaningPage() },
            { "spa", () => new SpaPage() },
            { "transport", () => new TransportPage() },
            { "excursion", () => new ExcursionPage() }
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
