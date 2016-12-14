using DbLayer;
using DbLayer.Tables;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for FindClient.xaml
    /// </summary>
    public partial class FindClient : Window
    {
        HotelPlazaContext context = new HotelPlazaContext();

        public Client SelectedClient { get; set; }

        public FindClient()
        {
            InitializeComponent();
        }

        private void NameFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filter = (sender as TextBox).Text;
            FoundClientList.ItemsSource = context.Clients.Where(client => client.FirstName.Contains(filter)).ToList();
        }

        private void SelectClient_Click(object sender, RoutedEventArgs e)
        {
            var client = FoundClientList.SelectedItem as Client;
            if (client != null)
            {
                DialogResult = true;
                SelectedClient = client;
                Close();
            }
        }
    }
}
