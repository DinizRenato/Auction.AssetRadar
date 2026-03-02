using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Auction.AssetRadar.Controllers
{
    public abstract class AssetRadarControllerBase : AbpController
    {
        protected AssetRadarControllerBase()
        {
            LocalizationSourceName = AssetRadarConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
