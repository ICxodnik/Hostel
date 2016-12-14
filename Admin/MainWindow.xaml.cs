using DbLayer;
using DbLayer.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Admin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RentRoom rentRoomWindow = new RentRoom();


        public MainWindow()
        {
            InitializeComponent();
            using (var context = new HotelPlazaContext())
            {

            }
        }

        private void newClient_Click(object sender, RoutedEventArgs e)
        {
            rentRoomWindow.ShowDialog();
        }
    }
}
