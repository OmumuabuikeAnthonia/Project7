using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using BamBoomhr.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BamBoomhr.Data.Interfaces;
using BamBoomhr.Data.Mocks;

namespace BamBoomhr
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
            services.AddTransient<IJobTitlesRepository, MockJobTitlesRepository>();
            services.AddTransient<IPayGradesRepository, MockPayGradesRepository>();
            services.AddTransient<IEmploymentStatusRepository, MockEmploymentStatusRepository>();
            services.AddTransient<IJobCategoriesRepository, MockJobCategoriesRepository>();
            services.AddTransient<ICurrenciesRepository, MockCurrenciesRepository>();
            services.AddTransient<ICompanyInformationRepository, MockCompanyInformationRepository>();
            services.AddTransient<ICompanyBranchRepository, MockCompanyBranchRepository>();
            services.AddTransient<IDepartmentRepository, MockDepartmentRepository>();
            services.AddTransient<ISkillsRepository, MockSkillsRepository>();
            services.AddTransient<IEducationRepository, MockEducationRepository>();
            services.AddTransient<ILicensesRepository, MockLicensesRepository>();
            services.AddTransient<ILanguagesRepository, MockLanguagesRepository>();
            services.AddTransient<IMembershipsRepository, MockMembershipsRepository>();
            services.AddTransient<INationalitiesRepository, MockNationalitesRepository>();
            services.AddTransient<IEmployeeRepository, MockEmployeeRepository>();
            services.AddTransient<IEmployeeContactDetailsRepository, MockEmployeeContactDetailsRepository>();
            services.AddTransient<IEmployeeEmergencyContactRepository, MockEmployeeEmergencyContactRepository>();
            services.AddTransient<IEmployeeDependantRepository, MockEmployeeDependantRepository>();
            services.AddTransient<IEmployeeImmigrationRepository, MockEmployeeImmigrationRepository>();
            services.AddTransient<IEmployeeJobRepository, MockEmployeeJobRepository>();
            services.AddTransient<IEmployeeSalaryRepository, MockEmployeeSalaryRepository>();
            services.AddTransient<IEmployeeMembershipsRepository, MockEmployeeMembershipsRepository>();
            services.AddTransient<IEmployeeSupervisorsRepository, MockEmployeeSupervisorsRepository>();
            services.AddTransient<IEmployeeSubordinatesRepository, MockEmployeeSubordinatesRepository>();



            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
