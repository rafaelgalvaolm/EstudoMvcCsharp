using System.Reflection;
using core.Settings;
using Microsoft.EntityFrameworkCore;

namespace data
{
    public class BaseDbContext : DbContext
    {
        private readonly string _configurationFolder;
        private readonly AppSettings _appSettings;
        public BaseDbContext(AppSettings appSettings, string configurationFolder)
        {
            _appSettings = appSettings;
            _configurationFolder = configurationFolder;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_appSettings.ConnectionStrings.DefaultConnection, options =>
            {
                options.MaxBatchSize(100);
                options.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
            });

            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTrackingWithIdentityResolution);
        }

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