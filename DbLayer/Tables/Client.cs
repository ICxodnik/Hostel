using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbLayer.Tables
{
    [Table("clients")]
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string Address { get; set; }

        public string Passport { get; set; }


    }
}
