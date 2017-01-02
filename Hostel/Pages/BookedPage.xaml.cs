using DbLayer;
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
using System.ComponentModel.DataAnnotations.Schema;

namespace Hostel.Pages
{
    /// <summary>
    /// Interaction logic for ExcursionPage.xaml
    /// </summary>
    [Table("bookedpages")]
    public partial class BookedPage : Page
    {
        public BookedPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var orders = DbRepository.Context.Orders.ToList();
            var total = orders.Sum(order => order.CashPaid);

            listView.ItemsSource = orders;
            textBlock.Text = "Итог - " + new PriceConverter().ConvertValueRaw(total);
        }
    }
}
