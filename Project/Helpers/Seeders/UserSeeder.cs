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
                    FirstName = "Mircea",
                    LastName = "Razvan",
                    Birthday = DateTime.Now,
                    NickName = Guid.NewGuid().ToString(),
                    Experience = 100,
                    Rank = 1,
                    Status = Role.Admin,
                    Email = "rzvandmir03@gmail.com",
                    Password = "razpassword",
                };
                var user2 = new User
                {
                    FirstName = "Mincu",
                    LastName = "Adrian",
                    Birthday = DateTime.Now,
                    NickName = Guid.NewGuid().ToString(),
                    Experience = 200,
                    Rank = 2,
                    Status = Role.Vip,
                    Email = "adimincu@gmail.com",
                    Password = "adipassword"
                };
                _roadsContext.Users.Add(user1);
                _roadsContext.Users.Add(user2);
                _roadsContext.SaveChanges();
            }
        }
    }
}
