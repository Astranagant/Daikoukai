using System;
using System.Collections.Generic;
using System.Reflection;
using Daikoukai.Core.Exception;

namespace Daikoukai.Core
{
    public abstract class ServiceLocatorBase
    {
        bool _isInitialized = false;
        object _syncObj = new object();
        IDictionary<Type, object> _servicesDic = new Dictionary<Type, object>();
        IDictionary<Type, IServiceProvider> _providersDic = new Dictionary<Type, IServiceProvider>();

        protected ServiceLocatorBase() { }

        void Init()
        {
            var assembly = GetServiceLocatorAssembly();

            var types = assembly.GetTypes();

            foreach (var type in types)
            {
                try
                {
                    var attrs = type.GetCustomAttributes(typeof(ServiceProviderBindingAttribute), false);

                    if (attrs != null && attrs.Length > 0)
                    {
                        var provider = Activator.CreateInstance(type) as IServiceProvider;
                        _providersDic[provider.GetServiceType()] = provider;
                    }
                }
                catch { }
            }
        }

        protected abstract Assembly GetServiceLocatorAssembly();

        private void CheckInitialized()
        {
            if (!_isInitialized)
            {
                lock (_syncObj)
                {
                    if (!_isInitialized)
                    {
                        Init();
                        _isInitialized = true;
                    }
                }
            }
        }

        public T GetSvc<T>() where T : class
        {
            CheckInitialized();

            object svc = null;
            Type type = typeof(T);

            if (!_servicesDic.TryGetValue(type, out svc))
            {
                lock (_syncObj)
                {
                    if (!_servicesDic.TryGetValue(type, out svc))
                    {
                        svc = GetSvcCore<T>();
                        _servicesDic[type] = svc;
                    }
                }
            }

            return svc as T;
        }

        public T GetSvcCore<T>() where T : class
        {
            IServiceProvider provider = null;

            if (!_providersDic.TryGetValue(typeof(T), out provider))
            {
                provider = null;
            }

            if (provider != null)
            {
                return provider.GetService() as T;
            }
            else
            {
                throw new MissingServiceException(typeof(T));
            }
        }
    }
}
