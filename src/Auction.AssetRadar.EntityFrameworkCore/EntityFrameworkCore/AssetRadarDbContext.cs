using Abp.Zero.EntityFrameworkCore;
using Auction.AssetRadar.Authorization.Roles;
using Auction.AssetRadar.Authorization.Users;
using Auction.AssetRadar.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace Auction.AssetRadar.EntityFrameworkCore;

public class AssetRadarDbContext : AbpZeroDbContext<Tenant, Role, User, AssetRadarDbContext>
{
    /* Define a DbSet for each entity of the application */

    public AssetRadarDbContext(DbContextOptions<AssetRadarDbContext> options)
        : base(options)
    {
    }
}
