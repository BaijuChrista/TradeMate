using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SC.Data;
using SC.Repository;
using SC.Service;
using SC.Service.Concrete;
using SC.Service.Interface;

namespace SC.Web
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
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
                
            });
            //services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            //{
            //    builder.WithOrigins("http://example.com")
            //           .AllowAnyMethod()
            //           .AllowAnyHeader();
            //}));
            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("en-GB");
                options.SupportedCultures = new List<CultureInfo> { new CultureInfo("en-GB") };
                options.RequestCultureProviders.Clear();
            });
            services.Configure<AppSettings>(appSettingsSection);
            services.AddMvc();
            services.AddAutoMapper();
            services.AddDistributedMemoryCache(); // Adds a default in-memory implementation of IDistributedCache
            services.AddSession(options =>
            {
                // Set a short timeout for easy testing.
                options.IdleTimeout = TimeSpan.FromMinutes(60);
                options.Cookie.HttpOnly = true;
                // Make the session cookie essential
                options.Cookie.IsEssential = true;
            });

            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IApplicationUserService, ApplicationUserService>();           
            services.AddTransient<IItemCategory, Service.Concrete.ItemCategory>();
            services.AddTransient<ICityService, CityService>();
            services.AddTransient<ICountryService, CountryService>();
            services.AddTransient<IFinancialYearService, FinancialYearService>();          
            services.AddTransient<IItemService, ItemsService>();            
            services.AddTransient<IMotherCompanyService, MotherCompanyService>();
            services.AddTransient<IStateService, StateService>();            
            services.AddTransient<ICompanyService, CompanyService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<ITaxMasterService, TaxMasterService>();
            services.AddTransient<IUserTypeService, UserTypeService>();                        
            services.AddTransient<IUserTypeService, UserTypeService>();
            services.AddTransient<ICurrencyService, CurrencyService>();            
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IStoreService,StoreService>();
            services.AddTransient<ISalesService, SalesService>();
            services.AddTransient<ISupplierService, SupplierService>();
            services.AddTransient<IAssetService, AssetService>();
            services.AddTransient<IBranchService, BranchService>();
            services.AddTransient<IPurchaseService, PurchaseService>();
            services.AddTransient<IDepartmentService, DepartmentService>();
            services.AddTransient<IDesignationService, DesignationService>();
            services.AddTransient<ICreditCardService, CreditCardService>();
            services.AddTransient<IBankService, BankService>();
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<ICOAService, COAService>();
            services.AddTransient<IServiceService, ServiceService>();
            services.AddTransient<IPurchaseReturnService, PurchaseReturnService>();
            services.AddTransient<ISaleReturnService, SaleReturnService>();
            services.AddSingleton<Microsoft.AspNetCore.Http.IHttpContextAccessor, Microsoft.AspNetCore.Http.HttpContextAccessor>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseSession();
            app.UseCookiePolicy();
            app.UseCors(options => options.AllowAnyOrigin().AllowAnyHeader().AllowCredentials().AllowAnyMethod());
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
               // app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseRequestLocalization();
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Login}/{action=Index}/{id?}");
            });
        }
    }
}
