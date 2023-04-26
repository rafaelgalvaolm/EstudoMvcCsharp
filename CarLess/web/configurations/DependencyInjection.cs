using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Settings;
using data;

namespace web.configurations
{
    public static class DependencyInjection
    {
        public static void AddDependencies(this IServiceCollection services, AppSettings appSettings)
        {
            services.AddSingleton(appSettings);

            services.AddControllersWithViews();

            services.AddScoped<ApplicationDbContext>();
        }
    }
}