using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace UsingMediatR.Extensions;

public static class AppDIExtensions
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
        return services;
    }
}