using DbLayer.Tables;
using MySql.Data.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DbLayer
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class HotelPlazaContext : DbContext
    {

        public HotelPlazaContext() : base(MakeConnection(), true)
        {
            Database.SetInitializer<HotelPlazaContext>(new CreateDatabaseIfNotExists<HotelPlazaContext>());
        }

        static DbConnection MakeConnection()
        {
            var connectionString = "server=localhost;uid=client;database=HotelPlaza;Pwd=clientPassword";
            //ConfigurationManager.ConnectionStrings["HotelPlaza"].ConnectionString
            return new MySqlConnection(connectionString);
        }


        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderedRoom> OrderedRooms { get; set; }
        public DbSet<Room> Rooms { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>();
            modelBuilder.Entity<Room>();
            modelBuilder.Entity<Order>();
            modelBuilder.Entity<OrderedRoom>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
