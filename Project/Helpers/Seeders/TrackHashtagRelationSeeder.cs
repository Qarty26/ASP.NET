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
            if(!_roadsContext.TrackHashtagRelations.Any())
            {
                var relation = new TrackHashtagRelation()
                {
                    IdTrack = new Guid("2dfb54fe-fb83-41e9-87d8-653be3e6bbe4"),
                    IdHashtag = new Guid("5f499341-0678-4f87-be90-1fb31fe0aff0")
                };

                _roadsContext.TrackHashtagRelations.Add(relation);
                _roadsContext.SaveChanges();
            }


        }
    }
}
