using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Models
{
    public class Rental
    {
        public int rental_id { get; set; }

        public int car_id { get; set; }

        public int customer_id { get; set; }	

        public DateTime rental_start_date { get; set; }

        public DateTime rental_end_date { get; set; }
        
        public decimal rental_cost { get; set; }
        public Customer Customer { get; set; }
        public Car Car { get; set; }
        
    }
}