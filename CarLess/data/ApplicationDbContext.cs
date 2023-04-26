using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Models;
using core.Settings;
using Microsoft.EntityFrameworkCore;

namespace data
{
    public class ApplicationDbContext : BaseDbContext
    {
        public ApplicationDbContext(AppSettings appSettings) : base(appSettings, "Application")
        {

        }

        public DbSet<User> users { get; set; }

        public DbSet<Car> cars { get; set; }

        public DbSet<Rental> rentals { get; set; }
    }
}