using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Auction.AssetRadar.Configuration;
using Auction.AssetRadar.EntityFrameworkCore;
using Auction.AssetRadar.Migrator.DependencyInjection;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;

namespace Auction.AssetRadar.Migrator;

[DependsOn(typeof(AssetRadarEntityFrameworkModule))]
public class AssetRadarMigratorModule : AbpModule
{
    private readonly IConfigurationRoot _appConfiguration;

    public AssetRadarMigratorModule(AssetRadarEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

        _appConfiguration = AppConfigurations.Get(
            typeof(AssetRadarMigratorModule).GetAssembly().GetDirectoryPathOrNull()
        );
    }

    public override void PreInitialize()
    {
        Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
            AssetRadarConsts.ConnectionStringName
        );

        Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        Configuration.ReplaceService(
            typeof(IEventBus),
            () => IocManager.IocContainer.Register(
                Component.For<IEventBus>().Instance(NullEventBus.Instance)
            )
        );
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(AssetRadarMigratorModule).GetAssembly());
        ServiceCollectionRegistrar.Register(IocManager);
    }
}
