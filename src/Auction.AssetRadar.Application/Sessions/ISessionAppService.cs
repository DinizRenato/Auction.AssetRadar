using Abp.Application.Services;
using Auction.AssetRadar.Sessions.Dto;
using System.Threading.Tasks;

namespace Auction.AssetRadar.Sessions;

public interface ISessionAppService : IApplicationService
{
    Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
}
