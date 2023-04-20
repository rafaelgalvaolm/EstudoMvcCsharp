using System.Reflection;
using CarRentModKrita.core.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRentModKrita.data
{
    public class BaseDbContext : DbContext
    {
        string _configurationFolder = "Application";
        public BaseDbContext(DbContextOptions<BaseDbContext> options)
            : base(options)
        {
        }

        public DbSet<Carro> Carros { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relationship.DeleteBehavior = DeleteBehavior.NoAction;

            var executingAssembly = Assembly.GetExecutingAssembly();
            var filter = $"{executingAssembly.GetName().Name}.Configurations.{_configurationFolder}";

            modelBuilder.ApplyConfigurationsFromAssembly(
                executingAssembly,
                x => x.Namespace.Equals(filter)
            );
        }
    }
}