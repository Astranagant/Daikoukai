using System;

namespace Daikoukai.Core
{
    public interface IServiceProvider
    {
        Type GetServiceType();
        object GetService();
    }
}
