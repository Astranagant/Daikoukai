using System;
using System.Diagnostics.CodeAnalysis;

namespace Daikoukai.Core.Exception
{
    [ExcludeFromCodeCoverage]
    public class MissingServiceException : InvalidOperationException
    {
        public Type ServiceType
        {
            get;
            private set;
        }

        public MissingServiceException(Type serviceType)
        {
            ServiceType = serviceType;
        }
    }
}
