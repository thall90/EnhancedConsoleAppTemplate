using System;
using System.Diagnostics.CodeAnalysis;
using EnhancedConsole.Application.Infrastructure.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EnhancedConsole.Application
{
    [ExcludeFromCodeCoverage]
    public static class ConsoleStartup
    {
        public static IServiceProvider SetupDependencyInjection(IConfigurationRoot configuration)
        {
            return new ServiceCollection() // Invoke static configuration methods containing your registrations here
                .RegisterConfigurationOptions(configuration)
                .RegisterMyDependencies()
                .BuildServiceProvider(false);
        }

        public static IConfigurationRoot SetupConfiguration()
        {
            var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            var b = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .AddJsonFile($"appsettings.{environmentName}.json", optional: true, reloadOnChange: true)
                    .AddEnvironmentVariables();

            return b.Build();
        }
    }
}