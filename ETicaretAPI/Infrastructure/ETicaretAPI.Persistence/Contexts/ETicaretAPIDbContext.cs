using ETicaretAPI.Domain.Entities;
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
    }

    //public class ETicaretDbContextFactory : IDesignTimeDbContextFactory<ETicaretAPIDbContext>
    //{
    //    public ETicaretAPIDbContext CreateDbContext(string[] args)
    //    {
    //        var configuration = new ConfigurationBuilder()
    //            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "..", "ETicaretAPI.API"))
    //            .AddJsonFile("appsettings.json")
    //            .Build();

    //        var builder = new DbContextOptionsBuilder<ETicaretAPIDbContext>();
    //        var connectionString = configuration.GetConnectionString("DefaultConnection");
    //        builder.UseSqlServer(connectionString);

    //        return new ETicaretAPIDbContext(builder.Options);
    //    }
    //}
}


//Install-Package Microsoft.EntityFrameworkCore

//Install - Package Microsoft.EntityFrameworkCore.Tools

//eğer DbContext i görmüyorsa bu paketleri indir