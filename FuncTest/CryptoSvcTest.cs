using System;
using System.Text;
using Daikoukai.Core;
using Daikoukai.Core.Crypto;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Daikoukai.FuncTest
{
    [TestClass]
    public class CryptoSvcTest
    {
        [TestMethod]
        public void DecryptTest()
        {
            ICryptoSvc svc = DaikoukaiSvcLocator.Instance.GetSvc<ICryptoSvc>();

            var param = CryptoParam.CreateRijndaelCryptoParam("00x61CxJ4eA7TxqGHvdXx35U0294ZwSe", "00x61CxJ4eA7TxqGHvdXx35U0294ZwSe");

            string cipherString = "aTNvFD5MCZbArJd2RiCgA5AdEgAjgvybzmncr5gHo3M=";
            byte[] cipher = Convert.FromBase64String(cipherString);

            byte[] plain = svc.Decrypt(cipher, param);
            string plainString = Encoding.UTF8.GetString(plain);

            Assert.AreEqual("1qaz2wsx", plainString.Trim());
        }

        [TestMethod]
        public void EncryptTest()
        {
            ICryptoSvc svc = DaikoukaiSvcLocator.Instance.GetSvc<ICryptoSvc>();

            var param = CryptoParam.CreateRijndaelCryptoParam("00x61CxJ4eA7TxqGHvdXx35U0294ZwSe", "00x61CxJ4eA7TxqGHvdXx35U0294ZwSe");

            string plainString = "1qaz2wsx";
            byte[] plain = Encoding.UTF8.GetBytes(plainString);

            byte[] cipher = svc.Encrypt(plain, param);
            string cipherString = Encoding.UTF8.GetString(cipher);

            string encodedCipherString = Convert.ToBase64String(cipher);
            Assert.AreEqual("aTNvFD5MCZbArJd2RiCgA5AdEgAjgvybzmncr5gHo3M=", encodedCipherString);
        }
    }
}
