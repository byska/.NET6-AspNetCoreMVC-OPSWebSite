using Autofac.Extensions.DependencyInjection;
using Autofac;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Ops.Core.Repositories;
using Ops.Core.Services;
using Ops.Core.UnitOfWorks;
using Ops.Repository;
using Ops.Repository.Repositories;
using Ops.Repository.UnitOfWorks;
using Ops.Service.Mapping;
using Ops.Service.Services;
using Ops.Service.Validation;
using Ops.Web.Modules;
using System.Reflection;
using FluentValidation;
using Ops.Core.Entities;
using System;
using Ops.Core.VMs.Create;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;


namespace Ops.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {

            // If you're using MVC or WebApi you'll probably have
            // a call to AddMvc() or AddControllers() already.

            // ... other configuration ...
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession(
                options=>
                {
                    options.IdleTimeout = TimeSpan.FromMinutes(30);
                    options.Cookie.IsEssential = true;
                });
            builder.Services.AddHttpContextAccessor();
            // Add services to the container.
            builder.Services.AddIdentity<AppUser, AppRole>(_ =>
            {
                _.Password.RequiredLength = 5;
                _.Password.RequireNonAlphanumeric = true;
                _.Password.RequireLowercase = true;
                _.Password.RequireUppercase = true;
                _.Password.RequireDigit = true;

                _.User.RequireUniqueEmail = true;
                _.User.AllowedUserNameCharacters = " abcçdefghiýjklmnoöpqrsþtuüvwxyzABCÇDEFGHIÝJKLMNOÖPQRSÞTUÜVWXYZ0123456789-._@+";
            }).AddPasswordValidator<CustomPasswordValidation>()
            .AddUserValidator<AppUserVMValidator>()
            .AddErrorDescriber<CustomIdentityErrorDescriber>()
            .AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            builder.Services.ConfigureApplicationCookie(_ =>
            {
                _.LoginPath = new PathString("/User/Login");
                _.LogoutPath = new PathString("/User/LogOut");
                _.Cookie = new CookieBuilder
                {
                    Name = "OpsCookie",
                    HttpOnly = false,
                    SameSite = SameSiteMode.Lax,
                    SecurePolicy = CookieSecurePolicy.Always
                };
                _.SlidingExpiration = true;
                _.ExpireTimeSpan = TimeSpan.FromMinutes(15);
            });

            builder.Services.Configure<DataProtectionTokenProviderOptions>(
                _ =>
                {
                    _.TokenLifespan = TimeSpan.FromHours(3);
                });

            builder.Services.AddControllersWithViews()
         .AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<AppUserVMValidator>());


            builder.Services.AddAutoMapper(typeof(MapProfile));

            builder.Services.AddScoped<IValidator<MessageCreateVM>, MessageVMValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<MessageVMValidator>();

            builder.Services.AddDbContext<AppDbContext>(x =>
            {
                x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), options =>
                {
                    options.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
                });
            });

            builder.Services.AddAuthentication(opt =>
            {
                opt.DefaultScheme=CookieAuthenticationDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = GoogleDefaults.AuthenticationScheme;
            }).AddCookie().AddFacebook(x =>
            {
                x.AppId = builder.Configuration["FacebookAppId"];
                x.AppSecret = builder.Configuration["FacebookAppSecret"];
                x.CallbackPath = new PathString("/User/Hata");
            }).AddGoogle(x=>
            {
                x.ClientId = builder.Configuration["GoogleClientId"];
                x.ClientSecret = builder.Configuration["GoogleClientSecret"];
            });
            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
            builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder => containerBuilder.RegisterModule(new RepoServiceModule()));

            var app = builder.Build();
            //using (var scope = app.Services.CreateScope())
            //{
            //    var services = scope.ServiceProvider;
            //    try
            //    {
            //        var userManager = services.GetRequiredService<UserManager<AppUser>>();
            //        var roleManager = services.GetRequiredService<RoleManager<AppRole>>();
            //        await IdentityDataInitializer.SeedDataAsync(userManager, roleManager);
            //    }
            //    catch (Exception ex)
            //    {
            //        var logger = services.GetRequiredService<ILogger<Program>>();
            //        logger.LogError(ex, "Seed data yüklenirken bir hata meydana geldi.");
            //    }
            //}

            app.UseSession();
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
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

                endpoints.MapAreaControllerRoute(
                name: "Customer",
                areaName: "Customer",
                pattern: "{area=Customer}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapAreaControllerRoute(
                    name: "Admin",
                    areaName: "Admin",
                    pattern: "{area=Admin}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Account}/{action=SignIn}/{id?}");

            });

            app.Run();
        }
    }
}