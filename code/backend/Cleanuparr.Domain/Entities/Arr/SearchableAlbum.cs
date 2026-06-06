namespace Cleanuparr.Domain.Entities.Arr;

public sealed record SearchableAlbum
{
    public long Id { get; init; }

    public string Title { get; init; } = string.Empty;
    
    public bool Monitored { get; init; }

    public List<long> Tags { get; init; } = [];
    
    public int QualityProfileId { get; init; }
    
    public DateTime? Added { get; init; }
    
    public DateTime? ReleaseDateUtc { get; init; }
}