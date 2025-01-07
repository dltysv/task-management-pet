using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using TaskManagement.Application.Configuration;

namespace TaskManagement.Application;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services, IApplicationConfiguration applicationConfiguration,
        Action<IApplicationConfiguration> configure)
    {
        configure(applicationConfiguration);
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
    }
}