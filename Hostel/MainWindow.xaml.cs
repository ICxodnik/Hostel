using DbLayer;
using DbLayer.Tables;
using System;
using System.Collections.Generic;
using System.Data.Common;
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

namespace Hostel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            using (var context = new HotelPlazaContext())
            {
                context.Database.CreateIfNotExists();

                var client = new Client() {
                    Id = 1,
                    FirstName = "Abdula Akazov",
                    Address = "Manhatten??",
                    Passport = "RK93849340"
                };

                context.Clients.Add(client);
                var resultCode = context.SaveChanges();
            }

        }
    }
}
