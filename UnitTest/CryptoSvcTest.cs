using System;
using Daikoukai.Core.Crypto;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Daikoukai.UnitTest
{
    [TestClass]
    public class CryptoSvcTest
    {
        ICryptoSvc CreateCryptoSvc(Action<Mock<ICryptoSvc>> action)
        {
            Mock<ICryptoSvc> mock = new Mock<ICryptoSvc>();

            if (action != null)
            {
                action(mock);
            }

            return mock.Object;
        }

        [TestMethod]
        public void DecryptTest()
        {
            ICryptoSvc mock = CreateCryptoSvc((Mock<ICryptoSvc> s) =>
            {
                s.Setup(t => t.Decrypt(It.IsAny<byte[]>(), It.IsAny<CryptoParam>()))
                    .Returns(() => { return CreateDecryptedPlain(); });
            });

            var plain = mock.Decrypt(new byte[] { 0x04 }, null);

            Assert.AreEqual(0x01, plain[0]);
        }

        private byte[] CreateDecryptedPlain()
        {
            byte[] plain = new byte[3] { 0x01, 0x02, 0x03 };

            return plain;
        }
    }
}
