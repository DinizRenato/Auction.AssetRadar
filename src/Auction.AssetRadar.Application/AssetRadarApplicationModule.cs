using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Auction.AssetRadar.Authorization;

namespace Auction.AssetRadar;

[DependsOn(
    typeof(AssetRadarCoreModule),
    typeof(AbpAutoMapperModule))]
public class AssetRadarApplicationModule : AbpModule
{
    public override void PreInitialize()
    {
        Configuration.Authorization.Providers.Add<AssetRadarAuthorizationProvider>();
    }

    public override void Initialize()
    {
        var thisAssembly = typeof(AssetRadarApplicationModule).GetAssembly();

        IocManager.RegisterAssemblyByConvention(thisAssembly);

        Configuration.Modules.AbpAutoMapper().Configurators.Add(
            // Scan the assembly for classes which inherit from AutoMapper.Profile
            cfg => cfg.AddMaps(thisAssembly)
        );
    }
}
