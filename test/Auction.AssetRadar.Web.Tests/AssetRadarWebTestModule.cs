using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Auction.AssetRadar.EntityFrameworkCore;
using Auction.AssetRadar.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Auction.AssetRadar.Web.Tests;

[DependsOn(
    typeof(AssetRadarWebMvcModule),
    typeof(AbpAspNetCoreTestBaseModule)
)]
public class AssetRadarWebTestModule : AbpModule
{
    public AssetRadarWebTestModule(AssetRadarEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
    }

    public override void PreInitialize()
    {
        Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(AssetRadarWebTestModule).GetAssembly());
    }

    public override void PostInitialize()
    {
        IocManager.Resolve<ApplicationPartManager>()
            .AddApplicationPartsIfNotAddedBefore(typeof(AssetRadarWebMvcModule).Assembly);
    }
}