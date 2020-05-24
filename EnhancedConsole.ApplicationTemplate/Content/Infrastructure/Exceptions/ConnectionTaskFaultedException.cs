using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace EnhancedConsole.ApplicationTemplate.Infrastructure.Exceptions
{
    [ExcludeFromCodeCoverage]
    public class ConnectionTaskFaultedException : Exception
    {
        public ConnectionTaskFaultedException(Exception exception)
            : base($"Connection to the SQL database failed upon opening. See exception: \n\n{exception}")
        {
        }
    }
}