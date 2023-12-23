using Roads.Data;
using Roads.Models;

namespace Roads.Helpers.Seeders
{
    public class HashtagSeeder
    {
        public readonly RoadsContext _roadsContext;

        public HashtagSeeder(RoadsContext roadsContext)
        {
            _roadsContext = roadsContext;
        }

        public void SeedInitialHashtags()
        {
            if(!_roadsContext.Hashtags.Any())
            {
                var Tag = new Hashtag
                { 
                    Xp = 0,
                    Tag = "Unknown tag"
                };

                _roadsContext.Hashtags.Add(Tag);
                _roadsContext.SaveChanges();

            }
        }

    }
}
