using MediatR;
using Freelance.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using Mapster;
using MapsterMapper;
using System.Reflection;
using Freelance.Application.Services.Authentication;

namespace Freelance.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(typeof(DependencyInjection).Assembly);

        //mapster
        var config = TypeAdapterConfig.GlobalSettings;
        config.Scan(Assembly.GetExecutingAssembly());

        services.AddSingleton(config);
        services.AddScoped<IMapper, ServiceMapper>();

        services.AddScoped<IRegisterService, RegisterService>();


        return services;
    }
}
