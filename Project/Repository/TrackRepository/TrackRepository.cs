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
    }
}
