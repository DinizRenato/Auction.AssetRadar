using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Auction.AssetRadar.Roles.Dto;
using Auction.AssetRadar.Users.Dto;
using System.Threading.Tasks;

namespace Auction.AssetRadar.Users;

public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
{
    Task DeActivate(EntityDto<long> user);
    Task Activate(EntityDto<long> user);
    Task<ListResultDto<RoleDto>> GetRoles();
    Task ChangeLanguage(ChangeUserLanguageDto input);

    Task<bool> ChangePassword(ChangePasswordDto input);
}
