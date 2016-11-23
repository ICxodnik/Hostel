using System;
using System.Collections.Generic;
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

namespace Hostel.Pages
{
    /// <summary>
    /// Interaction logic for ExcursionPage.xaml
    /// </summary>
    public partial class FoodPage : Page
    {
        public FoodPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
            listView.ItemsSource = new[] {
                new { Type = "Завтрак", Price = "5$", SourseImg = "\\Image\\Food\\zavtrak.jpg", Time = "9:00"},
                new { Type = "Обед", Price = "8$", SourseImg = "\\Image\\Food\\obed.jpg", Time = "13:30" },
                new { Type = "Ужин", Price = "10$", SourseImg = "\\Image\\Food\\yzunf.jpg", Time = "20:00" }
            };
        }
    }
}
