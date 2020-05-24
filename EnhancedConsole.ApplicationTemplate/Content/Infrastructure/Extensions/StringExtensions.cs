using System;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using EnhancedConsole.ApplicationTemplate.Infrastructure.Exceptions;

namespace EnhancedConsole.ApplicationTemplate.Infrastructure.Extensions
{
    [ExcludeFromCodeCoverage]
    public static class StringExtensions
    {
        internal static Task<SqlConnection> GetConnection(this string connectionString)
        {
            var connection = new SqlConnection(connectionString);
            var connectionTask = connection.OpenAsync();
            Task.WaitAll(connectionTask);

            if (connectionTask.IsFaulted)
            {
                throw new ConnectionTaskFaultedException(connectionTask.Exception);
            }

            return Task.FromResult(connection);
        }
    }
}