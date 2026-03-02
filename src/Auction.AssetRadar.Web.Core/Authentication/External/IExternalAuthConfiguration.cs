using System.Collections.Generic;

namespace Auction.AssetRadar.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
