using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp;
using Abp.Domain.Entities.Auditing;

namespace Auction.AssetRadar.Core.Entities.ImportBatch;

/// <summary>
/// Represents a file import execution for a given external source.
/// </summary>
[Table("AppImportBatches")]
public class ImportBatchEntity : FullAuditedEntity<Guid>
{
    private const int MaxSourceLength = 50;
    private const int MaxFileNameLength = 255;
    private const int MaxFileHashLength = 128;

    /// <summary>
    /// Initializes a new instance of the <see cref="ImportBatchEntity"/> class.
    /// </summary>
    protected ImportBatchEntity()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ImportBatchEntity"/> class with the required import metadata.
    /// </summary>
    /// <param name="source">The external source responsible for the imported file.</param>
    /// <param name="importedAt">The date and time when the import was executed.</param>
    /// <param name="fileName">The original imported file name.</param>
    /// <param name="fileHash">The content hash used to identify the imported file.</param>
    public ImportBatchEntity(
        string source,
        DateTime importedAt,
        string fileName,
        string fileHash)
    {
        Id = Guid.NewGuid();
        Source = source;
        ImportedAt = importedAt;
        FileName = fileName;
        FileHash = fileHash;
    }

    /// <summary>
    /// Gets the external source that produced the imported file.
    /// </summary>
    [Required]
    [MaxLength(MaxSourceLength)]
    public virtual string Source { get; protected set; }

    /// <summary>
    /// Gets the date and time when the import was processed.
    /// </summary>
    [Required]
    public virtual DateTime ImportedAt { get; protected set; }

    /// <summary>
    /// Gets the generated reference date associated with the imported file.
    /// </summary>
    public virtual DateTime? GeneratedDate { get; protected set; }

    /// <summary>
    /// Gets the original name of the imported file.
    /// </summary>
    [Required]
    [MaxLength(MaxFileNameLength)]
    public virtual string FileName { get; protected set; }

    /// <summary>
    /// Gets the hash of the imported file content.
    /// </summary>
    [Required]
    [MaxLength(MaxFileHashLength)]
    public virtual string FileHash { get; protected set; }

    /// <summary>
    /// Gets the total number of rows found in the imported file.
    /// </summary>
    public virtual int RowsCount { get; protected set; }

    /// <summary>
    /// Gets the number of records inserted during the import.
    /// </summary>
    public virtual int Inserted { get; protected set; }

    /// <summary>
    /// Gets the number of records updated during the import.
    /// </summary>
    public virtual int Updated { get; protected set; }

    /// <summary>
    /// Gets the number of records skipped during the import.
    /// </summary>
    public virtual int Skipped { get; protected set; }
}
