using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;

namespace EnhancedConsole.ApplicationTemplate.Infrastructure.DependencyInjection
{
    [ExcludeFromCodeCoverage]
    public static class MyRegistrationExtensions
    {
        public static IServiceCollection RegisterMyDependencies(this IServiceCollection services)
        {
            // services.AddTransient<IMyService, MyService>();

            // services.AddAssemblyTypes(typeof(ClassInAssemblyToRegister));

            // services.AddAssemblyTypes(typeof(ClassInAssemblyToRegister), lifetime: ServiceLifetime.Scoped);

            return services;
        }
    }
}