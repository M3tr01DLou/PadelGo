using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PadelGo.Application.Interfaces.Repositories;
using PadelGo.Infraestructure.Data;
using PadelGo.Infraestructure.Implementations;

namespace PadelGo.Infraestructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfraestructure(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<DataContext>(opt => opt.UseSqlServer(connectionString));
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

        return services;
    }
}