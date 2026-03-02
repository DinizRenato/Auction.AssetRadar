using Abp.MultiTenancy;
using Auction.AssetRadar.Authorization.Users;

namespace Auction.AssetRadar.MultiTenancy;

public class Tenant : AbpTenant<User>
{
    public Tenant()
    {
    }

    public Tenant(string tenancyName, string name)
        : base(tenancyName, name)
    {
    }
}
