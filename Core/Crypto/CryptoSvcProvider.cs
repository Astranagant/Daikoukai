
namespace Daikoukai.Core.Crypto
{
    [ServiceProviderBinding]
    class CryptoSvcProvider : ServiceProviderBase<ICryptoSvc>
    {
        protected override ICryptoSvc GetServiceCore()
        {
            return new CryptoSvc();
        }
    }
}
