using Microsoft.EntityFrameworkCore;
using Roads.Data;
using Roads.Models;
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
            return _table.AsNoTracking().Where(x => x.Confirmed).ToList();
        }

        public List<Track> GetAllPending()
        {
            return _table.AsNoTracking().Where(x => !x.Confirmed).ToList();
        }

        public List<Track> OrderByHighestXp()
        {
            return _table.OrderByDescending(x => x.Xp).ToList();
        }
    }
}
