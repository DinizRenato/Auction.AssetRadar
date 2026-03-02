using Abp.Authorization;
using Abp.Runtime.Session;
using Auction.AssetRadar.Configuration.Dto;
using System.Threading.Tasks;

namespace Auction.AssetRadar.Configuration;

[AbpAuthorize]
public class ConfigurationAppService : AssetRadarAppServiceBase, IConfigurationAppService
{
    public async Task ChangeUiTheme(ChangeUiThemeInput input)
    {
        await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
    }
}
