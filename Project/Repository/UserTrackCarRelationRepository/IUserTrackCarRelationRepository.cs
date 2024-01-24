using Roads.Models;

namespace Roads.Repository.UserTrackCarRelationRepository
{
    public interface IUserTrackCarRelationRepository
    {
        Task CreateAsync(UserTrackCarRelation relation);
        Task<bool> SaveAsync();
    }
}
