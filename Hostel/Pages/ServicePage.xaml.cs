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
    /// Interaction logic for ServicePage.xaml
    /// </summary>
    public partial class ServicePage : Page
    {
        public ServicePage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            listView.ItemsSource = new[] {
                new { Type = "Красное вино", Price = "2$", SourseImg = "\\Image\\Dos\\1.jpg", Time = "9:00"},
                new { Type = "Белое вино", Price = "3$", SourseImg = "\\Image\\Dos\\2.jpg", Time = "13:30" },
                new { Type = "Десерты", Price = "1$", SourseImg = "\\Image\\Dos\\3.jpg", Time = "20:00" },
                new { Type = "Сырная закуска", Price = "2$", SourseImg = "\\Image\\Dos\\4.jpg", Time = "9:00"},
                new { Type = "Паста с креветками", Price = "3$", SourseImg = "\\Image\\Dos\\5.jpg", Time = "13:30" },
                new { Type = "Лазанья", Price = "4$", SourseImg = "\\Image\\Dos\\6.jpg", Time = "20:00" },
                new { Type = "Запеченная рыба", Price = "2$", SourseImg = "\\Image\\Dos\\7.jpg", Time = "9:00"},
                new { Type = "Мясо в соусе", Price = "3$", SourseImg = "\\Image\\Dos\\8.jpg", Time = "13:30" },
                new { Type = "Греческий салат", Price = "4$", SourseImg = "\\Image\\Dos\\9.jpg", Time = "20:00" },
            };
        }
    }
}
