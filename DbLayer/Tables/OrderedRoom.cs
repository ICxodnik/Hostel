using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DbLayer.Tables
{
    public class OrderedRoom
    {
        public int Id { get; set; }

        public decimal TotalCost { get; set; }

        public virtual Client Client { get; set; }
        public virtual Room Room { get; set; }
        public DateTime InDate { get; set; }
        public DateTime OutDate { get; set; }

        public virtual DbSet<ServiceOrder> ServicesOrdered { get; set; }
    }
}
