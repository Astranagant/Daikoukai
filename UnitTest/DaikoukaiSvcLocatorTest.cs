using System;
using Daikoukai;
using Daikoukai.Core;
using Daikoukai.Core.Crypto;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Daikoukai.UnitTest
{
    [TestClass]
    public class DaikoukaiSvcLocatorTest
    {
        [TestMethod]
        public void GetSvc_ICryptoSvc()
        {
            var svc1 = DaikoukaiSvcLocator.Instance.GetSvc<ICryptoSvc>();
            var svc2 = DaikoukaiSvcLocator.Instance.GetSvc<ICryptoSvc>();

            Assert.IsNotNull(svc1);
            Assert.IsNotNull(svc2);

            Assert.IsTrue(Assert.ReferenceEquals(svc1, svc2));
        }
    }
}
