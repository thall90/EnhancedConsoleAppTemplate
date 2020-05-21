using System;

namespace EnhancedConsole.Application.Infrastructure.Exceptions
{
    public class ConnectionNotFoundException : Exception
    {
        public ConnectionNotFoundException(string connectionName)
            : base($"Could not find a connection string whose name matches \"{connectionName}\"")
        {
        }
    }
}