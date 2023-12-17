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

        public void SeedInitialUsers()
        {
            if(!_roadsContext.Tracks.Any()) 
            {
                var track1 = new Track
                {
                    Name = "Unknown name",
                    StartPoint = "Unknown SP",
                    EndPoint = "Unknown EP",
                    Xp = 0,
                    Confirmed = false
                };

                _roadsContext.Tracks.Add(track1);
                _roadsContext.SaveChanges();
            }

        }
    }
}
