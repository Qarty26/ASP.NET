using Roads.Data;
using Roads.Models;

namespace Roads.Helpers.Seeders
{
    public class MapSeeder
    {
        public readonly RoadsContext _roadsContext;

        public MapSeeder(RoadsContext roadsContext)
        {
            _roadsContext = roadsContext;
        }

        public void SeedInitialMaps()
        {
            if (!_roadsContext.Maps.Any())
            {
                var map1 = new Map
                {
                    Id = new Guid("ddec615f-f49a-4e94-a1bf-17f312d2d7a3"),
                    StartLatitude = 45.38,
                    StartLongitude = 25.35,
                    EndLatitude = 45.35,
                    EndLongitude = 25.33

                };

                _roadsContext.Maps.Add(map1);
                _roadsContext.SaveChanges();
            }

        }
    }
}
