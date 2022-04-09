using AJWManagementPortal.Data;
using AJWManagementPortal.Extensions.IRepository;
using AJWManagementPortal.Extensions.Repository;
using AJWManagementPortal.Models;
using AJWManagementPortal.Models.Services;
using AspNetCoreHero.ToastNotification;
using AspNetCoreHero.ToastNotification.Extensions;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace AJWManagementPortal
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
        {//for PDf Downloading in POroduction repository
            services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));
            services.AddControllers();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddDefaultTokenProviders()
                .AddDefaultUI()

                .AddEntityFrameworkStores<ApplicationDbContext>();

            //services.AddScoped<IDbInitializer, DbInitializer>();
            //here we add for emailsender if login error occure if not then ignor it
            //services.AddScoped<IDbInitializer, DbInitializer>();
            //services.Configure<StripeSettings>(Configuration.GetSection("Stripe"));
            services.AddSingleton<IEmailSender, EmailSender>();
            //services.Configure<EmailOptions>(Configuration);

            //This Code use for Monthly + Yearly General Ledger Report By :Yousaf Rakib :Start:
            services.AddScoped<IMonthlyGeneralLedgerBookRepository, MonthlyGeneralLedgerBookRepository>();
            services.AddScoped<IYearlyGeneralLedgerBookRepository, YearlyGeneralLedgerBookRepository>();
            services.AddScoped<IMonthlyMainBankLedgerBookRepository, MonthlyMainBankLedgerBookRepository>();
            services.AddScoped<IYearlyMainBankLedgerBookRepository, YearlyMainBankLedgerBookRepository>();
            services.AddScoped<IMonthlyInternalLedgerRepository, MonthlyInternalLedgerRepository>();
            services.AddScoped<IYearlyInternalLedgerRepository, YearlyInternalLedgerRepository>();
            services.AddScoped<IMonthlyIndustrySupplierLedgerRepository, MonthlyIndustrySupplierLedgerRepository>();
            services.AddScoped<IYearlyIndustrySupplierLedgerRepository, YearlyIndustrySupplierLedgerRepository>();
            services.AddScoped<IMonthlyIncomeExpenseInternalAccountReportRepository, MonthlyIncomeExpenseInternalAccountReportRepository>();
            services.AddScoped<ITrialBalanceAccountOfficeRepository, TrialBalanceAccountOfficeRepository>();
            //This Code use for Monthly + Yearly General Ledger Report By :Yousaf Rakib :End:
            // sessiON
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(5);//You can set Time   
            });

            services.AddControllersWithViews();
            services.AddRazorPages().AddRazorRuntimeCompilation();
            //here we add for language translation add code-------------------------------
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddMvc()
                .AddViewLocalization(Microsoft.AspNetCore.Mvc.Razor.LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization();

            services.AddNotyf(config => { config.DurationInSeconds = 10; config.IsDismissable = true; config.Position = NotyfPosition.TopCenter; });

            services.Configure<RequestLocalizationOptions>(options =>
            {
                //Startup here localization
                var cultures = new List<CultureInfo> {
                new CultureInfo("en"),
                new CultureInfo("ur")
    };
                options.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("en");
                options.SupportedCultures = cultures;
                options.SupportedUICultures = cultures;
            });
        }

        //here we add for language translation add code-------------------


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

            app.UseSession();

            app.UseRouting();

            //Startup here localization---------------
            app.UseRequestLocalization(app.ApplicationServices.GetRequiredService<IOptions<RequestLocalizationOptions>>().Value);
            //Startup here localization---------------

            app.UseNotyf();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{area=Home}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

            //Latest Version 00.00.01 Of :: AJW Management Portal ::------------
        }
    }
}