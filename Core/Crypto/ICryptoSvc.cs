
namespace Daikoukai.Core.Crypto
{
    public interface ICryptoSvc
    {
        byte[] Decrypt(byte[] cipher, CryptoParam param);
    }
}
