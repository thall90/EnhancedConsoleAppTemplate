using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using EnhancedConsole.Application.Infrastructure.Constants;
using EnhancedConsole.Application.Infrastructure.Exceptions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EnhancedConsole.Application.Infrastructure.Extensions
{
    public static class ServiceProviderExtensions
    {
        public static async Task<SqlConnection> GetSqlConnectionFromConfig(
            this IServiceProvider serviceProvider,
            string connectionName)
        {
            var connectionString = serviceProvider.GetConnectionStringFromConfig(connectionName);

            return await connectionString.GetConnection();
        }

        public static string GetConnectionStringFromConfig(
            this IServiceProvider serviceProvider,
            string connectionName)
        {
            var connectionString = serviceProvider
                .GetService<IConfiguration>()
                .GetConnectionString(connectionName);

            if (connectionString == null)
            {
                throw new ConnectionNotFoundException(connectionName);
            }

            return connectionString;
        }

        public static string GetConnectionStringFromConfig(
            this IServiceProvider serviceProvider,
            Func<ConnectionStringConstants, string> connectionNameSelector)
        {
            var connectionStringConstants = new ConnectionStringConstants();

            var connectionName = connectionNameSelector?.Invoke(connectionStringConstants);

            return serviceProvider.GetConnectionStringFromConfig(connectionName);
        }
    }
}