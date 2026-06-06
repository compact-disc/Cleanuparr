namespace Cleanuparr.Domain.Entities.Arr;

public sealed record ArtistStatistics
{
    public int TrackFileCount {get; init;}
    
    public int TrackCount {get; init;}
}