using Roads.Data;
using Roads.Data.Enums;
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
                    Experience = 2,
                    Rank = 0,
                    Status = Role.Regular
                };
                var user2 = new User
                {
                    FirstName = "SecondUser FirstName",
                    LastName = "SecondUser LastName",
                    Birthday = DateTime.Now,
                    NickName = Guid.NewGuid().ToString(),
                    Experience = 3,
                    Rank = 0,
                    Status = Role.Regular
                };
                _roadsContext.Users.Add(user1);
                _roadsContext.Users.Add(user2);
                _roadsContext.SaveChanges();
            }
        }
    }
}
