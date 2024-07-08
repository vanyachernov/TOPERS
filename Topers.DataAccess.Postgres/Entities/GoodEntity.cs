namespace Topers.DataAccess.Postgres.Entities;

using Microsoft.AspNetCore.Http;

/// <summary>
/// Represents a good entity.
/// </summary>
public class GoodEntity
{
    /// <summary>
    /// Gets or sets a good identifier.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets a good name.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets a good description.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets a good image name file.
    /// </summary>
    public string? ImageName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets a good image.
    /// </summary>
    public IFormFile? Image { get; set; }

    /// <summary>
    /// Gets or sets a good category identifier.
    /// </summary>
    public Guid CategoryId { get; set; }

    /// <summary>
    /// Gets or sets a good category;
    /// </summary>
    public CategoryEntity Category { get; set; } = null!;

    /// <summary>
    /// Gets or sets a good scopes collection.
    /// </summary>
    public ICollection<GoodScopeEntity> Scopes { get; set; } = [];
    
    
    // public ICollection<>
}