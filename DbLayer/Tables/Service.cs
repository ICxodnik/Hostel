using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbLayer.Tables
{
    [Table("services")]
    public class Service
    {
        public int Id { get; set; }
        public ServiceType Type { get; set; }
        public string Title { get; set; }
        public string Time { get; set; }
        public decimal Price { get; set; }
        public string SourceImage { get; set; }


        public enum ServiceType
        {
            Deliver = 1,
            Food = 2,
            Spa = 3,
            Excursion = 4,
            Cleaning = 5
        }
    }
}
