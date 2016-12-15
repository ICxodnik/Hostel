using DbLayer;
using DbLayer.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for RentRoom.xaml
    /// </summary>
    public partial class RentRoom : Window, INotifyPropertyChanged
    {
        private Client client = new Client();
        private List<Room> availableRooms = new List<Room>();

        HotelPlazaContext context = new HotelPlazaContext();

        public Client Client {
            get { return client; }
            set {
                client = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Client)));
            }
        }

        public List<Room> AvailableRooms
        {
            get { return availableRooms; }
            set
            {
                availableRooms = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(AvailableRooms)));
            }
        }

        public RentRoom()
        {
            InitializeComponent();
            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void SetUserToRoom(Client client, string roomNumber)
        {

        }

        private void AddClient_Click(object sender, RoutedEventArgs e)
        {
            var addClientWindow = new AddClient();

            var result = addClientWindow.ShowDialog();
            if (result.HasValue && result.Value)
            {
                Client = addClientWindow.NewClient;
            }
        }

        private void FindClient_Click(object sender, RoutedEventArgs e)
        {
            var findClientWindow = new FindClient();

            var result = findClientWindow.ShowDialog();
            if (result.HasValue && result.Value)
            {
                Client = findClientWindow.SelectedClient;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AvailableRooms = context.Rooms.ToList();
        }
    }
}
