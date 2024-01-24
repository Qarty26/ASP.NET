using Microsoft.EntityFrameworkCore;
using Roads.Data;
using Roads.Models;
using Roads.Repository.GenericRepository;

namespace Roads.Repository.TrackHashtagRepository
{
    public class TrackHashtagRepository : ITrackHashtagRepository
    {
        protected readonly RoadsContext _roadsContext;
        protected readonly DbSet<TrackHashtagRelation> _table;
        public TrackHashtagRepository(RoadsContext roadsContext)
        {
            _roadsContext = roadsContext;
            _table = _roadsContext.Set<TrackHashtagRelation>();
        }

        public async Task CreateAsync(TrackHashtagRelation relation)
        {
            await _roadsContext.AddAsync(relation);
        }

        public async Task<bool> SaveAsync()
        {
            return await _roadsContext.SaveChangesAsync() > 0;
        }

    }
}