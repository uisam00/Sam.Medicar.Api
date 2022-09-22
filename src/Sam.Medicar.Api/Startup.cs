using AutoMapper;
using Sam.Medicar.Api.IoC;
using Sam.Medicar.Application.Helpers;
using Sam.SingleSignOn.Shared.Extensions;
using Sam.SingleSignOn.Shared.Interfaces;

namespace Sam.Medicar.Api;

public class Startup : IStartupCustom
{
    public Startup(){}

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddRouting(options => options.LowercaseUrls = true);
        services.AddDistributedCache();

        services.AddVersioning();
        services.AddAuthenticationSSO();
        var mapperConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new MedicarProfile());
        });

        IMapper mapper = mapperConfig.CreateMapper();
        services.AddSingleton(mapper);
        services.AddCors();

        services.AddSwagger();
        services.RegisterServices();
    }

    public void Configure(WebApplication app, IWebHostEnvironment env)
    {
        app.UseSwaggerUI();
        app.UseHttpsRedirection();
        app.UseRouting();

        app.UseAuthentication();
        app.UseAuthorization();
        app.UseCors(x => x.AllowAnyHeader()
                  .AllowAnyMethod()
                  .AllowAnyOrigin());
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
