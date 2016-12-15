using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbLayer.Tables
{
    public class ServiceOrder
    {
        public int Id { get; set; }

        public virtual Client Client { get; set; }
        public virtual Service Service { get; set; }

        public DateTime ProvidedDate { get; set; }

        public decimal CashPaid { get; set; }
    }
}
