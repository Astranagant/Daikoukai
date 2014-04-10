
using System.Security.Cryptography;
namespace Daikoukai.Core.Crypto
{
    public abstract class CryptoParam
    {
        public static RijndaelCryptoParam CreateRijndaelCryptoParam(string IVString, string keyString)
        {
            RijndaelCryptoParam param = new RijndaelCryptoParam()
            {
                BlockSize = 256,
                IVString = IVString,
                KeySize = 256,
                KeyString = keyString,
                Mode = System.Security.Cryptography.CipherMode.CBC,
                Padding = System.Security.Cryptography.PaddingMode.Zeros
            };

            return param;
        }

        public static RijndaelCryptoParam CreateRijndaelCryptoParam(string IVString, string keyString
            , int blockSize, int keySize, CipherMode mode, PaddingMode padding)
        {
            RijndaelCryptoParam param = new RijndaelCryptoParam()
            {
                BlockSize = blockSize,
                IVString = IVString,
                KeySize = keySize,
                KeyString = keyString,
                Mode = mode,
                Padding = padding
            };

            return param;
        }
    }
}
