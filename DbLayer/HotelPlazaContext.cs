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
        }

        static DbConnection MakeConnection()
        {
            var connectionString = "server=localhost;uid=client;database=HotelPlaza;Pwd=clientPassword";
            //ConfigurationManager.ConnectionStrings["HotelPlaza"].ConnectionString
            return new MySqlConnection(connectionString);
        }


        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Room> Rooms { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Client>().MapToStoredProcedures();
            //modelBuilder.Entity<Order>().MapToStoredProcedures();
            //modelBuilder.Entity<Room>().MapToStoredProcedures();
        }
    }
}
