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
                    Id = new Guid("49f42890-0eef-417f-aa55-3fede394be8d"),
                    FirstName = "Mircea",
                    LastName = "Razvan",
                    Birthday = DateTime.Now,
                    UserName = "Qarty26",
                    NormalizedUserName = "Qarty26".ToUpper(),
                    Experience = 100,
                    Rank = 1,
                    Email = "rzvandmir03@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null,"razpassword"),
                    SecurityStamp = Guid.NewGuid().ToString()
                };
                var user2 = new User
                {
                    Id = new Guid("bd9de8d9-1609-44ff-b95a-bce8e2d0edf0"),
                    FirstName = "Mincu",
                    LastName = "Adrian",
                    Birthday = DateTime.Now,
                    UserName = "Scafa13",
                    NormalizedUserName = "Scafa13".ToUpper(),
                    Experience = 200,
                    Rank = 2,
                    Email = "adimincu@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null,"adipassword"),
                    SecurityStamp = Guid.NewGuid().ToString()
                };

                var user3 = new User
                {
                    Id = new Guid("65006866-8d62-42d8-8d32-3494b5860b99"),
                    FirstName = "Dogaru",
                    LastName = "Mihai",
                    Birthday = DateTime.Now,
                    UserName = "Matoka26",
                    NormalizedUserName = "Matoka26".ToUpper(),
                    Experience = 0,
                    Rank = 0,
                    Email = "migai26@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "mihaipassword"),
                    SecurityStamp = Guid.NewGuid().ToString()
                };
                _roadsContext.Users.Add(user1);
                _roadsContext.Users.Add(user2);
                _roadsContext.Users.Add(user3);
                _roadsContext.SaveChanges();
            }
        }
    }
}
