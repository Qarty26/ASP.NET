using Microsoft.EntityFrameworkCore;
using Roads.Data;
using Roads.Models;

namespace Roads.Repository.UserTrackCarRelationRepository
{
    public class UserTrackCarRelationRepository : IUserTrackCarRelationRepository
    {
        protected readonly RoadsContext _roadsContext;
        protected readonly DbSet<UserTrackCarRelation> _table;

        public UserTrackCarRelationRepository(RoadsContext roadsContext)
        {
            _roadsContext = roadsContext;
            _table = _roadsContext.Set<UserTrackCarRelation>();
        }

        public async Task CreateAsync(UserTrackCarRelation relation)
        {
            await _roadsContext.AddAsync(relation);
        }

        public async Task<bool> SaveAsync()
        {
            return await _roadsContext.SaveChangesAsync() > 0;
        }
    }
}
