using Abp.Application.Services;
using Auction.AssetRadar.Authorization.Accounts.Dto;
using System.Threading.Tasks;

namespace Auction.AssetRadar.Authorization.Accounts;

public interface IAccountAppService : IApplicationService
{
    Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

    Task<RegisterOutput> Register(RegisterInput input);
}
