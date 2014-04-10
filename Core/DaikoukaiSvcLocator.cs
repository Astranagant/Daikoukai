using System.Reflection;

namespace Daikoukai.Core
{
    public sealed class DaikoukaiSvcLocator : ServiceLocatorBase
    {
        public static DaikoukaiSvcLocator Instance = new DaikoukaiSvcLocator();

        protected override System.Reflection.Assembly GetServiceLocatorAssembly()
        {
            return Assembly.GetExecutingAssembly();
        }
    }
}
