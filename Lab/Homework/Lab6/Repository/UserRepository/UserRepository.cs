using Lab3_2.Data;
using Lab3_2.Helpers.Extensions;
using Lab3_2.Models;
using Lab3_2.Repository.GenericRepository;

namespace Lab3_2.Repository.UserRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(Lab4Context lab4context) : base(lab4context)
        {
        }

        public User FindByUsername(string username)
        {
            return _table.FirstOrDefault(u => u.Username.Equals(username));
        }

        public List<User> FindAllActive()
        {
            return _table.GetActiveUsers().ToList();
        }
    }

}
