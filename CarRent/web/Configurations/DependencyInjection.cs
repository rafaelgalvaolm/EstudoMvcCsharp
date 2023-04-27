namespace web.configurations
{
    public static class DependencyInjection
    {
        public static void AddDependencies(this IServiceCollection services, 
            AppSettings appSettings)
            
        {
            services.AddSingleton(appSettings);

            services.AddControllersWithViews();

            services.AddScoped<ApplicationDbContext>();

            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}