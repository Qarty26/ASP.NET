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
                    StartPoint = "Brasov",
                    EndPoint = "Poiana Brasov",
                    Xp = 100,
                    Confirmed = true
                };

                _roadsContext.Tracks.Add(track1);
                _roadsContext.SaveChanges();
            }

        }
    }
}
