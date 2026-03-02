using Auction.AssetRadar.Debugging;

namespace Auction.AssetRadar;

public class AssetRadarConsts
{
    public const string LocalizationSourceName = "AssetRadar";

    public const string ConnectionStringName = "Default";

    public const bool MultiTenancyEnabled = false;


    /// <summary>
    /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
    /// </summary>
    public static readonly string DefaultPassPhrase =
        DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "a1aec5b9ab9f4cfbb77361bd62c56949";
}
