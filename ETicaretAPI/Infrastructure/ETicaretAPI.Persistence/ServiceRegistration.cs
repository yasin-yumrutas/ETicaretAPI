using ETicaretAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Persistence.Repositories;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services) //Extention func
        {
            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString),ServiceLifetime.Singleton);

            services.AddSingleton<ICustomerReadRepository,CustomerReadRepository>();
            services.AddSingleton<ICustomerWriteRepository,CustomerWriteRepository>();
            services.AddSingleton<IOrderReadRepository,OrderReadRepository>();
            services.AddSingleton<IOrderWriteRepository,OrderWriteRepository>();
            services.AddSingleton<IProductReadRepository,ProductReadRepository>();
            services.AddSingleton<IProductWriteRepository,ProductWriteRepository>();
        }
    }
}

//dotnet ef migrations add mig01 --project C:\Users\yasin\OneDrive\Masaustu\Data\Data\yedek0\Data\ETicaretCSharp\ETicaretAPI\Infrastructure\ETicaretAPI.Persistence 

//ile migration ekleyebilirsin 


//dotnet ef migrations add mig01 --project C:\Users\yasin\OneDrive\Masaüstü\ETicaretCSharp\ETicaretAPI\Infrastructure\ETicaretAPI.Persistence