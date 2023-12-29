using Microsoft.AspNetCore.Identity;
using Roads.Data;
using Roads.Data.Enums;
using Roads.Models;

namespace Roads.Helpers.Seeders
{
    public class UserSeeder
    {
        private readonly RoadsContext _roadsContext;

        public UserSeeder(RoadsContext roadsContext)
        {
            _roadsContext = roadsContext;
        }   

        public void SeedInitialUsers()
        {
            if (!_roadsContext.Users.Any())
            {

                var hasher = new PasswordHasher<User>();

                var user1 = new User
                {
                    FirstName = "Mircea",
                    LastName = "Razvan",
                    Birthday = DateTime.Now,
                    UserName = "Qarty26",
                    NormalizedUserName = "Qarty26".ToUpper(),
                    Experience = 100,
                    Rank = 1,
                    Status = Role.Admin,
                    Email = "rzvandmir03@gmail.com",
                    PasswordHash = hasher.HashPassword(null,"razpassword"),
                    SecurityStamp = Guid.NewGuid().ToString()
                };
                var user2 = new User
                {
                    FirstName = "Mincu",
                    LastName = "Adrian",
                    Birthday = DateTime.Now,
                    UserName = "Scafa13",
                    NormalizedUserName = "Scafa13".ToUpper(),
                    Experience = 200,
                    Rank = 2,
                    Status = Role.Vip,
                    Email = "adimincu@gmail.com",
                    PasswordHash = hasher.HashPassword(null,"adipassword"),
                    SecurityStamp = Guid.NewGuid().ToString()
                };
                _roadsContext.Users.Add(user1);
                _roadsContext.Users.Add(user2);
                _roadsContext.SaveChanges();
            }
        }
    }
}
