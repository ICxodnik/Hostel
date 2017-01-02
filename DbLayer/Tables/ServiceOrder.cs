using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbLayer.Tables
{
    [Table("serviceorders")]
    public class ServiceOrder
    {
        public int Id { get; set; }

        public virtual Client Client { get; set; }
        public virtual Service Service { get; set; }

        public DateTime ProvidedDate { get; set; }

        public decimal CashPaid { get; set; }
    }
}
