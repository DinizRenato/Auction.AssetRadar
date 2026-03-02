using Abp.Application.Services;
using Auction.AssetRadar.MultiTenancy.Dto;

namespace Auction.AssetRadar.MultiTenancy;

public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
{
}

