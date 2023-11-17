using Lab3_2.Data;
using Lab3_2.Models;

namespace Lab3_2.Helpers.Seeders
{
    public class UserSeeder
    {
        public readonly Lab4Context _lab4Context;

        public UserSeeder(Lab4Context lab4Context)
        {
            lab4Context = lab4Context;
        }   

        public void SeedInitialUsers()
        {
            if (!_lab4Context.Users.Any())
            {
                var user1 = new User
                {
                    FirstName = "FirstName User1",
                    LastName = "LastName User1",
                    IsDeleted = false,
                    Email = "user1@fmi.ro",
                    Username = "Test",
                };

                var user2 = new User
                {
                    FirstName = "FirstName User2",
                    LastName = "LastName User2",
                    IsDeleted = false,
                    Email = "user2@fmi.ro",
                    Username = "Test2",
                };

                _lab4Context.Users.Add(user1);
                _lab4Context.Users.Add(user2);
                _lab4Context.SaveChanges();


            }
        }
    }
}
