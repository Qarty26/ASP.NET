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
                    Make = "BMW",
                    Model = "220d",
                    Year = 2015,
                    Color = "White",
                };
                var car2 = new Car
                {
                    Make = "Porsche",
                    Model = "Cayman GTS",
                    Year = 2020,
                    Color = "Green",
                };


                _roadsContext.Cars.Add(car1);
                _roadsContext.Cars.Add(car2);

                _roadsContext.SaveChanges();
            }
        }
    }
}
