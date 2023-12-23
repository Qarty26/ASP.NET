using Microsoft.VisualBasic;
using Roads.Data;
using Roads.Models;
using System.Drawing;

namespace Roads.Helpers.Seeders
{
    public class CarSeeder
    {
        public readonly RoadsContext _roadsContext;
        
        public CarSeeder (RoadsContext roadsContext)
        {
            _roadsContext = roadsContext;
        }

        public void SeedInitialCars()
        {
            if(!_roadsContext.Cars.Any())
            {
                var car1 = new Car
                {
                    Make = "Unknown Brand",
                    Model = "Unknown Model",
                    Year = 0,
                    Color = "Unknown color",

                };

                _roadsContext.Cars.Add(car1);
                _roadsContext.SaveChanges();
            }
        }
    }
}
