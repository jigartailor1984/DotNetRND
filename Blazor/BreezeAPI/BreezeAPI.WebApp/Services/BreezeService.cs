using Breeze;

namespace BreezeAPI.WebApp.Services
{
    public class BreezeService:IBreezeService
    {
        private BreezeConnect breezeConnect;
        private string appKey;
        private string appSecret;
        private string apiSession;
        public BreezeService(IConfiguration configuration)
        {
            if (configuration == null) { ArgumentNullException.ThrowIfNull(configuration); }
            appKey = configuration.GetValue<string>("BREEZE_APPKEY")??string.Empty;
            appSecret = configuration.GetValue<string>("BREEZE_SECRETKEY") ?? string.Empty;
            apiSession = configuration.GetValue<string>("BREEZE_SESSION") ?? string.Empty;
        }

        public BreezeConnect GetBreezeInstance()
        {
            if (breezeConnect is null)
            {
                breezeConnect = new BreezeConnect(appKey);
                breezeConnect.generateSessionAsPerVersion(appSecret, apiSession);
            }
            return breezeConnect;
        }
    }
}
