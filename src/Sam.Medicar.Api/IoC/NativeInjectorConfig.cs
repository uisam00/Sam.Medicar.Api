using Microsoft.EntityFrameworkCore;
using Sam.Medicar.Application.Interfaces;
using Sam.Medicar.Application.Services;
using Sam.Medicar.Data.Context;
using Sam.Medicar.Data.Repositories;
using Sam.Medicar.Domain.Interfaces.Repositories;

namespace Sam.Medicar.Api.IoC
{
    public static class NativeInjectorConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            var configuration = serviceProvider.GetRequiredService<IConfiguration>();

            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Sam.MedicarConnection"))
            );
            
            services.AddScoped<IEspecialidadeRepository, EspecialidadeRepository>();
            services.AddScoped<IEspecialidadeService, EspecialidadeService>();
        }
    }
}
