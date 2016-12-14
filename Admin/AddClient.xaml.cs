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
using System.Windows.Shapes;

namespace Admin
{
    /// <summary>
    /// Interaction logic for AddClient.xaml
    /// </summary>
    public partial class AddClient : Window
    {
        public Client NewClient { get; set; } = new Client();

        public AddClient()
        {
            InitializeComponent();
            DataContext = NewClient;
        }

        private void AddClient_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new HotelPlazaContext())
            {
                context.Clients.Add(NewClient);
                context.SaveChanges();
            }
            DialogResult = true;
            Close();
        }
    }
}
