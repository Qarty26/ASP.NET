using Microsoft.EntityFrameworkCore;
using Roads.Data;
using Roads.Models;

namespace Roads.Helpers.Seeders
{
    public class UserTrackCarSeeder
    {
        public readonly RoadsContext _roadsContext;

        public UserTrackCarSeeder(RoadsContext roadsContext)
        {
            _roadsContext = roadsContext;
        }

        public void SeedInitialUTC()
        {
            if (!_roadsContext.UserTrackCarRelations.Any())
            {
                var relation = new UserTrackCarRelation()
                {
                    IdUser = new Guid("49f42890-0eef-417f-aa55-3fede394be8d"),
                    IdTrack = new Guid("a79932c0-e311-4a28-aa71-2ec7ef39071d"),
                    IdCar = new Guid("9490ed34-1e94-439a-b647-85ee4bdfed71")
                    
                };

                _roadsContext.UserTrackCarRelations.Add(relation);
                _roadsContext.SaveChanges();
            }


        }
    }
}
