using Roads.Data;
using Roads.Models;

namespace Roads.Helpers.Seeders
{
    public class UserSeeder
    {
        public readonly RoadsContext _roadsContext;

        public UserSeeder(RoadsContext roadsContext)
        {
            _roadsContext = roadsContext;
        }   

        public void SeedInitialUsers()
        {
            if (!_roadsContext.Users.Any())
            {
                var user1 = new User
                {
                    FirstName = "FirstUser FirstName",
                    LastName = "FirstUser LastName",
                    Birthday = DateTime.Now,
                    NickName = Guid.NewGuid().ToString(),
                    Experience = 0,
                    Rank = 0,
                    Status = "Regular"
                };

                _roadsContext.Users.Add(user1);
                _roadsContext.SaveChanges();
            }
        }
    }
}
