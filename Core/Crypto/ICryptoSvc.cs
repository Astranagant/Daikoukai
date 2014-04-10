
namespace Daikoukai.Core.Crypto
{
    public interface ICryptoSvc
    {
        byte[] Decrypt(byte[] cipher, CryptoParam param);

        byte[] Encrypt(byte[] plain, CryptoParam param);
    }
}
