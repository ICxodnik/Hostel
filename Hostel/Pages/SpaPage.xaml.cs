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
    public partial class SpaPage : Page
    {
        public SpaPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            listView.ItemsSource = new[] {
                new { Type = "Массаж и аромотерапия", Price = "5$", SourseImg = "\\Image\\Spa\\1.jpg", Time = "11/11/16 9:00" },
                new { Type = "Кофейный львов", Price = "8$", SourseImg = "\\Image\\Spa\\2.jpg", Time = "12/11/16 13:30" },
                new { Type = "Басейн", Price = "10$", SourseImg = "\\Image\\Spa\\3.jpg", Time = "13/11/16 20:00" },
                new { Type = "Обертывания", Price = "12$", SourseImg = "\\Image\\Spa\\4.jpg", Time = "14/11/16 20:00" },
                new { Type = "Биорепарация", Price = "12$", SourseImg = "\\Image\\Spa\\5.jpg", Time = "15/11/16 20:00" },
                new { Type = "Романтический Львов", Price = "15$", SourseImg = "\\Image\\Spa\\6.jpg", Time = "16/11/16 20:00" },
           };
        }
    }
}
