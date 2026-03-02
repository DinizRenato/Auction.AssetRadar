using Abp.Authorization;
using Auction.AssetRadar.Authorization.Roles;
using Auction.AssetRadar.Authorization.Users;

namespace Auction.AssetRadar.Authorization;

public class PermissionChecker : PermissionChecker<Role, User>
{
    public PermissionChecker(UserManager userManager)
        : base(userManager)
    {
    }
}
