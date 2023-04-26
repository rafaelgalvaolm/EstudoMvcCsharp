using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Models
{
    public class Rental
    {
        public int Id { get; set; }

        public int car_id { get; set; }

        public int user_id { get; set; }	

        public DateTime RentalStartDate { get; set; }

        public DateTime RentalEndDate { get; set; }
        
        public decimal RentalCost { get; set; }
        public User User { get; set; }
        public Car Car { get; set; }
        
    }
}