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
                    Xp = 20,
                    Tag = "Level difference"
                };
                var Tag2 = new Hashtag
                {
                    Xp = 10,
                    Tag = "Curvy"
                };
                var Tag3 = new Hashtag
                {
                    Xp = 40,
                    Tag = "Speedy"
                };

                _roadsContext.Hashtags.Add(Tag);
                _roadsContext.Hashtags.Add(Tag2);
                _roadsContext.Hashtags.Add(Tag3);

                _roadsContext.SaveChanges();

            }
        }

    }
}
