using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Daikoukai.Core;
using Daikoukai.Core.Crypto;

namespace Daikoukai.Shell.Manager
{
    public class CryptoManager
    {
        public static string Decrypt(string encodedCipherString, Encoding encoding)
        {
            byte[] cipher = Convert.FromBase64String(encodedCipherString);

            var param = CryptoParam.CreateRijndaelCryptoParam(Shell.Default.IV, Shell.Default.Key
                , Shell.Default.BlockSize, Shell.Default.KeySize, Shell.Default.Mode
                , Shell.Default.Padding);

            var plain = DaikoukaiSvcLocator.Instance.GetSvc<ICryptoSvc>().Decrypt(cipher, param);

            string plainString = encoding.GetString(plain);

            return plainString;
        }
    }
}
