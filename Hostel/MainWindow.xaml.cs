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
using System.Windows.Controls.Primitives;
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
			//using (var context = new HotelPlazaContext())
			//{
			//    context.Database.CreateIfNotExists();

			//    var client = new Client() {
			//        Id = 1,
			//        FirstName = "Abdula Akazov",
			//        Address = "Manhatten??",
			//        Passport = "RK93849340"
			//    };

			//    context.Clients.Add(client);
			//    var resultCode = context.SaveChanges();
			//}

			ActionTypeList.ItemsSource = new List<dynamic>()
			{
				new { Tag = "deliver", Text = "Доставка", Image = "Image/d1.png" },
				new { Tag = "food", Text = "Питание", Image = "Image/m5.png" },
				new { Tag = "cleaning", Text = "Уборка в номере", Image = "Image/u1.png" },
				new { Tag = "spa", Text = "СПА-услуги", Image = "Image/s1.png" },
				new { Tag = "transport", Text = "Транспорт", Image = "Image/t1.png" },
				new { Tag = "excursion", Text = "Экскурсии", Image = "Image/e2.png" },
			};


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
            var type = (sender as ToggleButton).Tag.ToString();

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
