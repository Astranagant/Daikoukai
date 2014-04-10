using System.Security.Cryptography;
using System.Text;

namespace Daikoukai.Core.Crypto
{
    public class RijndaelCryptoParam : CryptoParam
    {
        public int KeySize = 256;
        public int BlockSize = 256;
        public PaddingMode Padding = PaddingMode.Zeros;
        public CipherMode Mode = CipherMode.CBC;
        public byte[] Key = new byte[] { };
        public byte[] IV = new byte[] { };

        public string KeyString = "";
        public string IVString = "";
    }
}
