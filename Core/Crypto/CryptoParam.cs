
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


    }
}
