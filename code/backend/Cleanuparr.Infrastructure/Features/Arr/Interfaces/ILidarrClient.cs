using Cleanuparr.Domain.Entities.Arr;
using Cleanuparr.Persistence.Models.Configuration.Arr;

namespace Cleanuparr.Infrastructure.Features.Arr.Interfaces;

public interface ILidarrClient : IArrClient
{
    Task<List<SearchableArtist>> GetAllArtistsAsync(ArrInstance arrInstance);
    
    Task<List<SearchableAlbum>> GetAlbumsAsync(ArrInstance arrInstance, long artistId);

    Task<List<ArrTrackFile>> GetTrackFilesAsync(ArrInstance arrInstance, long albumId);
}