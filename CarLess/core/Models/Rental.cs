using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Models
{
    public class Rental
    {
        public int Id { get; set; }

        public int CarId { get; set; }

        public int UserId { get; set; }	

        public DateTime RentalStartDate { get; set; }

        public DateTime RentalEndDate { get; set; }
        
        public decimal RentalCost { get; set; }
        public Usuario User { get; set; }
        public Car Car { get; set; }
        
    }
}