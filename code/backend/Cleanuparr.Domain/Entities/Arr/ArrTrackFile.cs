namespace Cleanuparr.Domain.Entities.Arr;

public sealed record ArrTrackFile
{
    public long Id { get; init; }
    
    public bool QualityCutoffNotMet { get; init; }
    
    public int CustomFormatScore { get; init; }
    
    public bool HasFile { get; init; }
    
    public int TrackFileId { get; init; }
}