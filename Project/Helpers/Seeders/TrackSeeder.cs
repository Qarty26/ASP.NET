using Roads.Data;
using Roads.Models;

namespace Roads.Helpers.Seeders
{
    public class TrackSeeder
    {
        public readonly RoadsContext _roadsContext;

        public TrackSeeder(RoadsContext roadsContext)
        {
            _roadsContext = roadsContext;
        }

        public void SeedInitialTracks()
        {
            if(!_roadsContext.Tracks.Any()) 
            {
                var track1 = new Track
                {
                    Name = "Poiana",
                    Xp = 100,
                    Confirmed = true,
                    Map = _roadsContext.Maps.FirstOrDefault(m => m.Id == new Guid("ddec615f-f49a-4e94-a1bf-17f312d2d7a3"))
                };

                _roadsContext.Tracks.Add(track1);
                _roadsContext.SaveChanges();
            }

        }
    }
}
