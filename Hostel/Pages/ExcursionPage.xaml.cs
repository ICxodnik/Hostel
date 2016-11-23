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
    public partial class ExcursionPage : Page
    {
        public ExcursionPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            listView.ItemsSource = new[] {
                new { Type = "Храмы Львова", Price = "5$", SourseImg = "\\Image\\Exc\\exc1.jpg", Time = "11/11/16 9:00"},
                new { Type = "Кофейный львов", Price = "8$", SourseImg = "\\Image\\Exc\\exc2.jpg", Time = "12/11/16 13:30" },
                new { Type = "Жемчужина Европы", Price = "10$", SourseImg = "\\Image\\Exc\\exc3.jpg", Time = "13/11/16 20:00" },
                new { Type = "Семь чудес Львова", Price = "12$", SourseImg = "\\Image\\Exc\\exc4.jpg", Time = "14/11/16 20:00" },
                new { Type = "Средневековый Львов", Price = "12$", SourseImg = "\\Image\\Exc\\exc5.jpg", Time = "15/11/16 20:00" },
                new { Type = "Романтический Львов", Price = "15$", SourseImg = "\\Image\\Exc\\exc6.jpg", Time = "16/11/16 20:00" },
            };
        }
    }
}
