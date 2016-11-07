using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbLayer.Tables
{
    public class Order
    {
        public int Id { get; set; }

        public virtual Client Client { get; set; }
        public virtual Room Room { get; set; }

        public DateTime DateOfEntry { get; set; }
        public DateTime FateOfExit { get; set; }

        public Decimal CashPaid { get; set; }
    }
}
