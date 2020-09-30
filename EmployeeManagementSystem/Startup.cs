using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AspNetCore.RouteAnalyzer;
using EmployeeManagementSystem.Middlewares;
using EmployeeManagementSystem.Areas.Admin.Repository.Interface;
using EmployeeManagementSystem.Areas.Admin.Repository.Implementation;
using EmployeeManagementSystem.Areas.Public.Repository.Implementation;
using EmployeeManagementSystem.Areas.Public.Repository.Interface;

namespace EmployeeManagementSystem
{
    public class Startup
    {
        private IConfiguration _config;
        public Startup (IConfiguration config)
        {
            this._config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(_config.GetConnectionString("databaseConnection")));
            services.AddMvc();
            services.AddTransient<ILoginRepository, SQLLoginRepository>();
            services.AddTransient<IUserRepository, SQLUserRepository>();
            services.AddTransient<IDepartmentRepository, SQLDepartmentRepository>();
            services.AddTransient<IDesignationRepository, SQLDesignationRepository>();
            services.AddTransient<IVacancyRepository, SQLVacancyRepository>();
            services.AddTransient<ISalaryRepository, SQLSalaryRepository>();
            services.AddTransient<ILeaveRepository, SQLLeaveRepository>();
            services.AddSession();
            services.AddRouteAnalyzer();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSession();
            app.UseMiddleware<AuthenticationMiddleware>();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvc();
            
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}");
                routes.MapRouteAnalyzer("/routes");
            });
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Login}/{action=Index}");
                routes.MapRoute("dashboard", "{area=Admin}/{controller=Dashboard}/{action=Index}");
            });
            app.UseMvc(routes =>
            {
                routes.MapRoute("register", "{controller=Register}/{action=Add}");
            });
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Login}/{action=Index}");
                routes.MapRoute("vacancyEdit", "{area=Admin}/{controller=Vacancy}/{action=Edit}/{id}");
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
