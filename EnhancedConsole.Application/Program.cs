using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using EnhancedConsole.Application.Infrastructure.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EnhancedConsole.Application
{
    [ExcludeFromCodeCoverage]
    public class Program
    {
        private static IConfigurationRoot Configuration { get; set; }

        private static IServiceProvider ServiceProvider { get; set; }

        public static async Task Main(string[] args)
        {
            const string consoleAppOperation = "What the console app does (ex: Data Uploader)";
            var watch = Stopwatch.StartNew();
            var exitCode = 0;

            ConsoleExtensions.PrintStartMessage(consoleAppOperation);

            Configuration = ConsoleStartup.SetupConfiguration();
            ServiceProvider = ConsoleStartup.SetupDependencyInjection(Configuration);

            try
            {
                using (var scope = ServiceProvider.CreateScope())
                {
                    // Do console app stuff here!
                }
            }
            catch (Exception e)
            {
                ConsoleExtensions.PrintError($"\n {e} \n");
                exitCode = -1;
            }
            finally
            {
                watch.Stop();

                ConsoleExtensions.PrintExitMessage(consoleAppOperation, exitCode, watch);
            }
        }
    }
}