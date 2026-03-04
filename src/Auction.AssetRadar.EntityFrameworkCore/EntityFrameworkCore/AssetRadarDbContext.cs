using Abp.Zero.EntityFrameworkCore;
using Auction.AssetRadar.Authorization.Roles;
using Auction.AssetRadar.Authorization.Users;
using Auction.AssetRadar.Core.Entities.ImportBatch;
using Auction.AssetRadar.Core.Entities.PropertyListing;
using Auction.AssetRadar.Core.Entities.Properties;
using Auction.AssetRadar.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace Auction.AssetRadar.EntityFrameworkCore;

public class AssetRadarDbContext : AbpZeroDbContext<Tenant, Role, User, AssetRadarDbContext>
{
    /* Define a DbSet for each entity of the application */

    public virtual DbSet<ImportBatchEntity> ImportBatches { get; set; }
    public virtual DbSet<PropertyListingEntity> PropertyListings { get; set; }
    public virtual DbSet<PropertyEntity> Properties { get; set; }

    public AssetRadarDbContext(DbContextOptions<AssetRadarDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<PropertyEntity>(property =>
        {
            property.HasIndex(x => new { x.Source, x.ExternalCode }).IsUnique();
        });

        modelBuilder.Entity<ImportBatchEntity>(importBatch =>
        {
            importBatch.ToTable("AppImportBatches");

            importBatch.Property(x => x.Source)
                .IsRequired()
                .HasMaxLength(50);

            importBatch.Property(x => x.ImportedAt)
                .IsRequired();

            importBatch.Property(x => x.FileName)
                .IsRequired()
                .HasMaxLength(255);

            importBatch.Property(x => x.FileHash)
                .IsRequired()
                .HasMaxLength(128);
        });

        modelBuilder.Entity<PropertyListingEntity>(propertyListing =>
        {
            propertyListing.ToTable("AppPropertyListings");

            propertyListing.Property(x => x.PropertyId)
                .IsRequired();

            propertyListing.Property(x => x.ImportBatchId)
                .IsRequired();

            propertyListing.Property(x => x.SaleModality)
                .IsRequired();

            propertyListing.Property(x => x.Price)
                .IsRequired();

            propertyListing.Property(x => x.Url)
                .IsRequired()
                .HasMaxLength(PropertyListingEntity.MaxUrlLength);

            propertyListing.Property(x => x.CapturedAt)
                .IsRequired();

            propertyListing.Property(x => x.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            propertyListing.HasOne(x => x.Property)
                .WithMany()
                .HasForeignKey(x => x.PropertyId)
                .OnDelete(DeleteBehavior.Restrict);

            propertyListing.HasOne(x => x.ImportBatch)
                .WithMany()
                .HasForeignKey(x => x.ImportBatchId)
                .OnDelete(DeleteBehavior.Restrict);
        });
    }
}
