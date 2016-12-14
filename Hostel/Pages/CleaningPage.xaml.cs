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
    public partial class CleaningPage : Page
    {
        public CleaningPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            listView.ItemsSource = new[] {
                new { Type = "Прачечная", Price = "1$", SourseImg = "\\Image\\Clear\\1.jpg", Time = "9:00"},
                new { Type = "Уборка комнаты", Price = "2$", SourseImg = "\\Image\\Clear\\2.jpg", Time = "13:30" },
                new { Type = "Влажная уборка", Price = "1$", SourseImg = "\\Image\\Clear\\3.jpg", Time = "20:00" },
                new { Type = "Замена белья", Price = "2$", SourseImg = "\\Image\\Clear\\4.jpg", Time = "9:00"}
            };
        }
    }
}
