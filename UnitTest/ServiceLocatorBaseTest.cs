using System;
using System.Reflection;
using Daikoukai;
using Daikoukai.Core;
using Daikoukai.Core.Crypto;
using Daikoukai.Core.Exception;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Daikoukai.UnitTest
{
    [TestClass]
    public class ServiceLocatorBaseTest
    {
        [TestMethod]
        [ExpectedException(typeof(MissingServiceException))]
        public void TestSvcLocator()
        {
            var svc = TempSvcLocator.Instance.GetSvc<ICryptoSvc>();
        }
    }

    public sealed class TempSvcLocator : ServiceLocatorBase
    {
        public static TempSvcLocator Instance = new TempSvcLocator();

        protected override System.Reflection.Assembly GetServiceLocatorAssembly()
        {
            return Assembly.GetExecutingAssembly();
        }
    }
}
