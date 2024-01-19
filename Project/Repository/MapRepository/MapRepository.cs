using Roads.Data;
using Roads.Models;
using Roads.Repository.GenericRepository;

namespace Roads.Repository.MapRepository
{
    public class MapRepository : GenericRepository<Map>, IMapRepository
    {
        public MapRepository(RoadsContext roadsContext) : base(roadsContext)
        {
        }
    }
}
