using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Auction.AssetRadar.EntityFrameworkCore;

public static class AssetRadarDbContextConfigurer
{
    public static void Configure(DbContextOptionsBuilder<AssetRadarDbContext> builder, string connectionString)
    {
        builder.UseSqlServer(connectionString);
    }

    public static void Configure(DbContextOptionsBuilder<AssetRadarDbContext> builder, DbConnection connection)
    {
        builder.UseSqlServer(connection);
    }
}
