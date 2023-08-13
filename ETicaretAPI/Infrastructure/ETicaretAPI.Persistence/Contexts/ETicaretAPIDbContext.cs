using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ETicaretAPI.Persistence.Contexts
{
    public class ETicaretAPIDbContext : DbContext
    {
        public ETicaretAPIDbContext(DbContextOptions<ETicaretAPIDbContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        public override async  Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //ChangeTracker : Entityler üzerinden yapılan değişiklerin yada yeni eklenen verinin yakalanmasını sağlayan propertydir. Update operasyonlarında Track edilen verileri yakalayıp elde etmemizi sağlar.

            var datas = ChangeTracker
                .Entries<BaseEntity>();

            foreach(var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreateDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdateDate = DateTime.UtcNow
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}


//Install-Package Microsoft.EntityFrameworkCore

//Install - Package Microsoft.EntityFrameworkCore.Tools

//eğer DbContext i görmüyorsa bu paketleri indir