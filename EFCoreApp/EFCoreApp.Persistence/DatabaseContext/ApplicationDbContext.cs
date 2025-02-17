using EfCoreApp.Models;
using EFCoreApp.Persistence.FluentApis;
using Microsoft.EntityFrameworkCore;

namespace EFCoreApp.DatabaseContext
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                modelBuilder.Entity(entity.ClrType).ToTable(entity.ClrType.Name);
            }

            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries().Where(_ => _.State == EntityState.Added || _.State == EntityState.Modified);
            foreach (var entry in entries) 
            {
                entry.Property("UpdatedDate").CurrentValue = DateTime.UtcNow;

                if(entry.State == EntityState.Added)
                {
                    entry.Property("CreatedDate").CurrentValue = DateTime.UtcNow;
                }
            }

            return base.SaveChanges();
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
