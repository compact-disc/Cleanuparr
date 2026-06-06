using Cleanuparr.Domain.Enums;

namespace Cleanuparr.Domain.Entities.Arr;

public sealed class ArtistSearchItem : SearchItem
{
    public long ArtistId { get; set; }
    
    public ArtistSearchType SearchType { get; set; }

    public override bool Equals(object? obj)
    {
        if (obj is not ArtistSearchItem other)
        {
            return false;
        }
        
        return Id == other.Id && ArtistId == other.ArtistId;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, ArtistId);
    }
}