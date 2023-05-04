using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;



namespace MainWeb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddSession(options => { options.IdleTimeout = TimeSpan.FromMinutes(30); });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<DropDown.ICommon, DropDown.Common>();


            //Database 
            services.AddSingleton<DBAccess.IDBAccess>(new DBAccess.MSSQLDataAccess(AppData.GetMSSQLDBCon()));

            //Account
            services.AddTransient<HRIS.Account.Repository.IUserData, HRIS.Account.Repository.UserData>();

            //Sample
            services.AddTransient<DropDown.ISampleDDL, DropDown.SampleDDL>();
            services.AddTransient<HRIS.Sample.Repository.ISampleCategoryData, HRIS.Sample.Repository.SampleCategoryData>();
            services.AddTransient<HRIS.Sample.Repository.ISampleDataData, HRIS.Sample.Repository.SampleDataData>();
            services.AddTransient<HRIS.Sample.Repository.IV_Number_TempData, HRIS.Sample.Repository.V_Number_TempData>();
            services.AddTransient<HRIS.Sample.Repository.ICustomerData, HRIS.Sample.Repository.CustomerData>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "MyArea",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
