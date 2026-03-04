using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp;
using Abp.Domain.Entities.Auditing;
using Auction.AssetRadar;

namespace Auction.AssetRadar.Core.Entities.Properties;

/// <summary>
/// Represents a property imported from an external source.
/// </summary>
[Table("AppProperties")]
public class PropertyEntity : FullAuditedEntity<Guid>
{
    /// <summary>
    /// Maximum allowed length for the property source identifier.
    /// </summary>
    public const int MaxSourceLength = 32;

    /// <summary>
    /// Maximum allowed length for the external property code.
    /// </summary>
    public const int MaxExternalCodeLength = 64;

    /// <summary>
    /// Maximum allowed length for the state value.
    /// </summary>
    public const int MaxStateLength = 64;

    /// <summary>
    /// Maximum allowed length for the city value.
    /// </summary>
    public const int MaxCityLength = 128;

    /// <summary>
    /// Maximum allowed length for the neighborhood value.
    /// </summary>
    public const int MaxNeighborhoodLength = 128;

    /// <summary>
    /// Maximum allowed length for the address line.
    /// </summary>
    public const int MaxAddressLineLength = 256;

    /// <summary>
    /// Maximum allowed length for the raw description.
    /// </summary>
    public const int MaxDescriptionRawLength = 4000;

    /// <summary>
    /// Initializes a new instance of the <see cref="PropertyEntity"/> class.
    /// </summary>
    protected PropertyEntity()
    {
    }

    public PropertyEntity(
        string source,
        string externalCode,
        PropertyType propertyType)
    {
        Id = Guid.NewGuid();
        Source = source;
        ExternalCode = externalCode;
        PropertyType = propertyType;
    }


    /// <summary>
    /// Gets the external source identifier, such as CAIXA.
    /// </summary>
    [Required]
    [MaxLength(MaxSourceLength)]
    public virtual string Source { get; protected set; }

    /// <summary>
    /// Gets the unique identifier assigned by the external source.
    /// </summary>
    [Required]
    [MaxLength(MaxExternalCodeLength)]
    public virtual string ExternalCode { get; protected set; }

    /// <summary>
    /// Gets the classified property type.
    /// </summary>
    [Required]
    public virtual PropertyType PropertyType { get; protected set; }

    /// <summary>
    /// Gets the state where the property is located.
    /// </summary>
    [MaxLength(MaxStateLength)]
    public virtual string State { get; protected set; }

    /// <summary>
    /// Gets the city where the property is located.
    /// </summary>
    [MaxLength(MaxCityLength)]
    public virtual string City { get; protected set; }

    /// <summary>
    /// Gets the neighborhood where the property is located.
    /// </summary>
    [MaxLength(MaxNeighborhoodLength)]
    public virtual string Neighborhood { get; protected set; }

    /// <summary>
    /// Gets the street-level address information.
    /// </summary>
    [MaxLength(MaxAddressLineLength)]
    public virtual string AddressLine { get; protected set; }

    /// <summary>
    /// Gets the raw description as received from the external source.
    /// </summary>
    [MaxLength(MaxDescriptionRawLength)]
    public virtual string DescriptionRaw { get; protected set; }
}
