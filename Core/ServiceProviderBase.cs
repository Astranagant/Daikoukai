using System;

namespace Daikoukai.Core
{
    public abstract class ServiceProviderBase<T> : IServiceProvider
    {
        public Type GetServiceType()
        {
            return typeof(T);
        }

        public object GetService()
        {
            return GetServiceCore();
        }

        protected abstract T GetServiceCore();
    }
}
