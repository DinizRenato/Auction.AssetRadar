using Abp.Modules;
using Abp.Reflection.Extensions;
using Auction.AssetRadar.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Auction.AssetRadar.Web.Host.Startup
{
    [DependsOn(
       typeof(AssetRadarWebCoreModule))]
    public class AssetRadarWebHostModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AssetRadarWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AssetRadarWebHostModule).GetAssembly());
        }
    }
}
