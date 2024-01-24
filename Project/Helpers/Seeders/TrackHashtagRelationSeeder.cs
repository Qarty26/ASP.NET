using Roads.Data;
using Roads.Models;

namespace Roads.Helpers.Seeders
{
    public class TrackHashtagRelationSeeder
    {
        public readonly RoadsContext _roadsContext;

        public TrackHashtagRelationSeeder(RoadsContext roadsContext)
        {
            _roadsContext = roadsContext;
        }

        public void SeedInitialTrackHashtags()
        {
            if (!_roadsContext.TrackHashtagRelations.Any())
            {
                var relation = new TrackHashtagRelation()
                {
                    IdTrack = new Guid("a79932c0-e311-4a28-aa71-2ec7ef39071d"),
                    IdHashtag = new Guid("5c380a3d-7f67-4d1b-8987-362ca2cdd5de")
                };

                _roadsContext.TrackHashtagRelations.Add(relation);
                _roadsContext.SaveChanges();
            }


        }
    }
}
