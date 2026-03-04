using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp;
using Abp.Domain.Entities.Auditing;
using Auction.AssetRadar.Core.Entities.ImportBatch;
using Auction.AssetRadar.Core.Entities.Properties;

namespace Auction.AssetRadar.Core.Entities.PropertyListing;

/// <summary>
/// Represents a captured property listing associated with an import batch.
/// </summary>
[Table("AppPropertyListings")]
public class PropertyListingEntity : FullAuditedEntity<Guid>
{
    /// <summary>
    /// Maximum allowed length for the listing URL.
    /// </summary>
    public const int MaxUrlLength = 1000;

    /// <summary>
    /// Initializes a new instance of the <see cref="PropertyListingEntity"/> class.
    /// </summary>
    protected PropertyListingEntity()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="PropertyListingEntity"/> class with required listing data.
    /// </summary>
    /// <param name="propertyId">The associated property identifier.</param>
    /// <param name="importBatchId">The import batch identifier that captured the listing.</param>
    /// <param name="saleModality">The sale modality associated with the listing.</param>
    /// <param name="price">The listing price.</param>
    /// <param name="url">The listing source URL.</param>
    /// <param name="capturedAt">The date and time when the listing was captured.</param>
    public PropertyListingEntity(
        Guid propertyId,
        Guid importBatchId,
        SaleModality saleModality,
        decimal price,
        string url,
        DateTime capturedAt)
    {
        Id = Guid.NewGuid();
        PropertyId = propertyId;
        ImportBatchId = importBatchId;
        SaleModality = saleModality;
        Price = price;
        Url = url;
        CapturedAt = capturedAt;
        IsActive = true;
    }

    /// <summary>
    /// Gets the related property identifier.
    /// </summary>
    [Required]
    public virtual Guid PropertyId { get; protected set; }

    /// <summary>
    /// Gets the related import batch identifier.
    /// </summary>
    [Required]
    public virtual Guid ImportBatchId { get; protected set; }

    /// <summary>
    /// Gets the sale modality captured for the listing.
    /// </summary>
    [Required]
    public virtual SaleModality SaleModality { get; protected set; }

    /// <summary>
    /// Gets the listing price.
    /// </summary>
    [Required]
    public virtual decimal Price { get; protected set; }

    /// <summary>
    /// Gets the appraisal value associated with the listing.
    /// </summary>
    public virtual decimal? AppraisalValue { get; protected set; }

    /// <summary>
    /// Gets the discount percentage associated with the listing.
    /// </summary>
    public virtual decimal? DiscountPercent { get; protected set; }

    /// <summary>
    /// Gets the source URL for the listing.
    /// </summary>
    [Required]
    [MaxLength(MaxUrlLength)]
    public virtual string Url { get; protected set; }

    /// <summary>
    /// Gets the date and time when the listing was captured.
    /// </summary>
    [Required]
    public virtual DateTime CapturedAt { get; protected set; }

    /// <summary>
    /// Gets a value indicating whether the listing is currently active.
    /// </summary>
    [Required]
    public virtual bool IsActive { get; protected set; }

    /// <summary>
    /// Gets the related property aggregate.
    /// </summary>
    public virtual PropertyEntity Property { get; protected set; }

    /// <summary>
    /// Gets the related import batch aggregate.
    /// </summary>
    public virtual ImportBatchEntity ImportBatch { get; protected set; }
}
