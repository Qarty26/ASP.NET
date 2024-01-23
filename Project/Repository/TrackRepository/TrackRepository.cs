using Microsoft.EntityFrameworkCore;
using Roads.Data;
using Roads.Models;
using Roads.Models.DTOs;
using Roads.Repository.GenericRepository;

namespace Roads.Repository.TrackRepository
{
    public class TrackRepository : GenericRepository<Track>, ITrackRepository
    {
        public TrackRepository(RoadsContext roadsContext) : base(roadsContext)
        {
        }

        public List<Track> GetAllConfirmed()
        {
            return _table.Include(t => t.Map).AsNoTracking().Where(x => x.Confirmed).ToList();
        }

        public List<Track> GetAllPending()
        {
            return _table.Include(t => t.Map).AsNoTracking().Where(x => !x.Confirmed).ToList();
        }

        public List<Track> OrderByHighestXp()
        {
            return _table.Include(t => t.Map).OrderByDescending(x => x.Xp).ToList();
        }

        public List<Track> OrderByNewest()
        {
            return _table.Include(t => t.Map).OrderByDescending(x => x.FirstCreated).ToList();
        }

        public List<Track> GetAllTracksWithMap()
        {
            return _table.AsNoTracking()
                .Include(t => t.Map)
                .ToList();
        }

        public List<Track> GetAllWithTags()
        {
            return _table.AsNoTracking()
                .Include(h => h.TrackHashtagRelations)
                .ToList();
        }
    }
}
