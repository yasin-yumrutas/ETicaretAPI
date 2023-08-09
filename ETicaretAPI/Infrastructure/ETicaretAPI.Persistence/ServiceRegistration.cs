using ETicaretAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services) //Extention func
        {
            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
        }
    }
}

//dotnet ef migrations add mig01 --project C:\Users\yasin\OneDrive\Masaustu\Data\Data\yedek0\Data\ETicaretCSharp\ETicaretAPI\Infrastructure\ETicaretAPI.Persistence 

//ile migration ekleyebilirsin 


//dotnet ef migrations add mig01 --project C:\Users\yasin\OneDrive\Masaüstü\ETicaretCSharp\ETicaretAPI\Infrastructure\ETicaretAPI.Persistence