using Abp.MultiTenancy;
using Auction.AssetRadar.Editions;
using Auction.AssetRadar.MultiTenancy;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Auction.AssetRadar.EntityFrameworkCore.Seed.Tenants;

public class DefaultTenantBuilder
{
    private readonly AssetRadarDbContext _context;

    public DefaultTenantBuilder(AssetRadarDbContext context)
    {
        _context = context;
    }

    public void Create()
    {
        CreateDefaultTenant();
    }

    private void CreateDefaultTenant()
    {
        // Default tenant

        var defaultTenant = _context.Tenants.IgnoreQueryFilters().FirstOrDefault(t => t.TenancyName == AbpTenantBase.DefaultTenantName);
        if (defaultTenant == null)
        {
            defaultTenant = new Tenant(AbpTenantBase.DefaultTenantName, AbpTenantBase.DefaultTenantName);

            var defaultEdition = _context.Editions.IgnoreQueryFilters().FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
            if (defaultEdition != null)
            {
                defaultTenant.EditionId = defaultEdition.Id;
            }

            _context.Tenants.Add(defaultTenant);
            _context.SaveChanges();
        }
    }
}
