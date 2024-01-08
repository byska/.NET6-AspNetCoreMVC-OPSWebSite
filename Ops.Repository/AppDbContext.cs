using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ops.Core.Entities;
using Ops.Core.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Repository
{
    public class AppDbContext : IdentityDbContext<AppUser,AppRole,int>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<District> Counties { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<HomeSlider> HomeSlider { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Message> Messages { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var item in ChangeTracker.Entries())
            {
                if (item.Entity is IEntity entityReference)
                {
                    switch (item.State)
                    {
                        case EntityState.Added:
                            {
                                entityReference.CreatedDate = DateTime.Now;
                                entityReference.Status = Core.Enums.Status.Added;
                                break;
                            }
                        case EntityState.Modified:
                            {
                                Entry(entityReference).Property(x => x.CreatedDate).IsModified = false;
                                entityReference.ModifiedDate = DateTime.Now;
                                entityReference.Status = Core.Enums.Status.Modified;
                                break;
                            }
                        case EntityState.Deleted:
                            {
                                Entry(entityReference).Property(x => x.CreatedDate).IsModified = false;
                                Entry(entityReference).Property(x => x.ModifiedDate).IsModified = false;
                                entityReference.DeletedDate = DateTime.Now;
                                entityReference.Status = Core.Enums.Status.Deleted;
                                break;
                            }
                    }
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
        public override int SaveChanges()
        {
            foreach (var item in ChangeTracker.Entries())
            {
                if (item.Entity is IEntity entityReference)
                {
                    switch (item.State)
                    {
                        case EntityState.Added:
                            {
                                entityReference.CreatedDate = DateTime.Now;
                                entityReference.Status = Core.Enums.Status.Added;
                                break;
                            }
                        case EntityState.Modified:
                            {
                                Entry(entityReference).Property(x => x.CreatedDate).IsModified = false;
                                entityReference.ModifiedDate = DateTime.Now;
                                entityReference.Status = Core.Enums.Status.Modified;
                                break;
                            }
                        case EntityState.Deleted:
                            {
                                Entry(entityReference).Property(x => x.CreatedDate).IsModified = false;
                                Entry(entityReference).Property(x => x.ModifiedDate).IsModified = false;
                                entityReference.DeletedDate = DateTime.Now;
                                entityReference.Status = Core.Enums.Status.Deleted;
                                break;
                            }
                    }
                }
            }
            return base.SaveChanges();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
