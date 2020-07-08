namespace MasGlobalApp
{
    using Entity.Configuration;
    using MasGlobal.Business;
    using MasGlobal.Business.Interface;
    using MasGlobal.DataAccess;
    using MasGlobal.DataAccess.Interface;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    public class Startup
    {
        /// <summary>
        /// Instance of IConfiguration.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Contructor.
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Initialize configuration.
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            Configuration.Bind("AppSettings", AppSettings.Instance);
            services.Configure<AppSettings>(options => Configuration.GetSection("AppSettings").Bind(options));
            DependencyDataAccess(services);
            DependencyBusiness(services);
        }

        /// <summary>
        /// Suscribe DataAccess clases.
        /// </summary>
        private static void DependencyDataAccess(IServiceCollection services)
        {
            services.AddTransient<IEmployeeDataAccess, EmployeeDataAccess>();
        }

        /// <summary>
        /// Suscribe Business clases.
        /// </summary>
        private static void DependencyBusiness(IServiceCollection services)
        {
            services.AddTransient<IEmployeeBusiness, EmployeeBusiness>();
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
