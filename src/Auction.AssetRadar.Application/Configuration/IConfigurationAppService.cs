using Auction.AssetRadar.Configuration.Dto;
using System.Threading.Tasks;

namespace Auction.AssetRadar.Configuration;

public interface IConfigurationAppService
{
    Task ChangeUiTheme(ChangeUiThemeInput input);
}
