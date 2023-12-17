using Microsoft.AspNetCore.Mvc;
using Roads.Data;
using Roads.Models;
using Roads.Repository.GenericRepository;

namespace Roads.Repository.UserRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(RoadsContext roadsContext) : base(roadsContext){ }
        public List<User> OrderByXp()
        {
            return _table.OrderBy(x => x.Experience).ToList();   
        }
    }
}
