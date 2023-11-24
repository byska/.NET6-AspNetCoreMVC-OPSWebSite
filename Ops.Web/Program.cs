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

namespace Ops.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // If you're using MVC or WebApi you'll probably have
            // a call to AddMvc() or AddControllers() already.


            // ... other configuration ...
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            builder.Services.AddControllersWithViews()
         .AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<ProductVMValidator>())
         .AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<MessageVMValidator>());


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
            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
            builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder => containerBuilder.RegisterModule(new RepoServiceModule()));

            var app = builder.Build();

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