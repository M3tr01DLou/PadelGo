using Microsoft.Extensions.DependencyInjection;
using PadelGo.Application.Implementations;
using PadelGo.Application.Interfaces.UnitsOfWork;

namespace PadelGo.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped(typeof(IGenericUnitOfWork<>), typeof(GenericUnitOfWork<>));

        return services;
    }
}