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
    public partial class BookedPage : Page
    {
        public BookedPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            listView.ItemsSource = new[] {
                new { Type = "Завтрак", Price = "1$", SourseImg = "\\Image\\Food\\zavtrak.jpg", Time = "9:00"},
                new { Type = "Храмы Львова", Price = "5$", SourseImg = "\\Image\\Exc\\exc1.jpg", Time = "11/11/16 9:00"},
                new { Type = "Кофейный львов", Price = "8$", SourseImg = "\\Image\\Exc\\exc2.jpg", Time = "12/11/16 13:30" },
                new { Type = "Романтический Львов", Price = "15$", SourseImg = "\\Image\\Exc\\exc6.jpg", Time = "16/11/16 20:00" },
                new { Type = "Ужин", Price = "5$", SourseImg = "\\Image\\Food\\yzunf.jpg", Time = "20:00" }
            };
        }
    }
}
