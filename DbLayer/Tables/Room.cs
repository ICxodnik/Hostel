using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbLayer.Tables
{
    public class Room
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string Number { get; set; }

        public decimal CostPerDay { get; set; }
    }
}
