using System.Security.Cryptography;
using System.Text;

namespace Daikoukai.Core.Crypto
{
    class CryptoSvc : ICryptoSvc
    {
        #region ICryptoSvc Members

        public byte[] Decrypt(byte[] cipher, CryptoParam param)
        {
            RijndaelCryptoParam rijParam = this.ExtractRealRijndaelCyptoParam(param);

            RijndaelManaged rij = new RijndaelManaged() {
                BlockSize = rijParam.BlockSize,
                KeySize = rijParam.KeySize,
                Padding = rijParam.Padding,
                Mode = rijParam.Mode,
                Key = rijParam.Key,
                IV = rijParam.IV
            };

            ICryptoTransform transform = rij.CreateDecryptor(rij.Key, rij.IV);

            byte[] plain = transform.TransformFinalBlock(cipher, 0, cipher.Length);

            return plain;
        }

        public byte[] Encrypt(byte[] plain, CryptoParam param)
        {
            RijndaelCryptoParam rijParam = this.ExtractRealRijndaelCyptoParam(param);

            RijndaelManaged rij = new RijndaelManaged()
            {
                BlockSize = rijParam.BlockSize,
                KeySize = rijParam.KeySize,
                Padding = rijParam.Padding,
                Mode = rijParam.Mode,
                Key = rijParam.Key,
                IV = rijParam.IV
            };

            ICryptoTransform transform = rij.CreateEncryptor(rijParam.Key, rijParam.IV);
            byte[] cipher = transform.TransformFinalBlock(plain, 0, plain.Length);

            return cipher;
        }

        #endregion

        private RijndaelCryptoParam ExtractRealRijndaelCyptoParam(CryptoParam param)
        {
            RijndaelCryptoParam rijParam = param as RijndaelCryptoParam;

            rijParam.Key = Encoding.UTF8.GetBytes(rijParam.KeyString);
            rijParam.IV = Encoding.UTF8.GetBytes(rijParam.IVString);

            return rijParam;
        }
    }
}
