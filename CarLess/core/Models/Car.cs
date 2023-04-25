using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Models
{
    public class Car
    {
        public int car_id { get; set; }

        public string make  { get; set; }

        public string model { get; set; }	

        public string year { get; set; }

        public int price_per_day { get; set; }

        public IEnumerable<Rental> Rentals { get; set; }
    }
}