using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Auction.AssetRadar.Localization;

public static class AssetRadarLocalizationConfigurer
{
    public static void Configure(ILocalizationConfiguration localizationConfiguration)
    {
        localizationConfiguration.Sources.Add(
            new DictionaryBasedLocalizationSource(AssetRadarConsts.LocalizationSourceName,
                new XmlEmbeddedFileLocalizationDictionaryProvider(
                    typeof(AssetRadarLocalizationConfigurer).GetAssembly(),
                    "Auction.AssetRadar.Localization.SourceFiles"
                )
            )
        );
    }
}
