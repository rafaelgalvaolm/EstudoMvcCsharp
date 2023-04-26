using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string Make  { get; set; }

        public string Model { get; set; }	

        public string Year { get; set; }

        public int PricePerDay { get; set; }

        public IEnumerable<Rental> Rentals { get; set; }
    }
}