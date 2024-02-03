using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Roads.Data;
using Roads.Models;
using Roads.Repository.GenericRepository;
using System.ComponentModel;

namespace Roads.Repository.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<User> _userManager;
        public UserRepository(UserManager<User> userMananger)
        {
            _userManager = userMananger;
        }

        public async Task CreateAsync(User user)
        {
            var result = await _userManager.CreateAsync(user);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Regular");
                return;
            }

            throw new Exception(result.Errors.First().Description);
        }

        public async Task<User> GetUserById(Guid id)
        {
            return await _userManager.FindByIdAsync(id.ToString());
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _userManager.Users.ToListAsync();
        }

        public async Task<List<User>> GetUsersWIthCarsAndTracksAsync()
        {
            var obj = await _userManager.Users
                .Include(c => c.Cars)
                .Include(t => t.UserTrackCarRelations)
                    .ThenInclude(t => t.Track)
                .Include(t => t.UserTrackCarRelations)
                    .ThenInclude(t => t.Car)
                .AsNoTracking().ToListAsync();
            return obj;
        }

        public async Task<List<User>> OrderByXp()
        {
            return await _userManager.Users.OrderByDescending(x => x.Experience).ToListAsync();
        }

        public async Task Delete(Guid userId)
        {
            var existingUser = await GetUserById(userId);

            if (existingUser == null)
            {
                throw new Exception("User not found");
            }

            if ((await _userManager.DeleteAsync(existingUser)).Succeeded == false)
                throw new Exception("User delete failed");
        }

        public async Task Update(User user)
        {
            user.SecurityStamp = Guid.NewGuid().ToString();
            if ((await _userManager.UpdateAsync(user)).Succeeded == false)
                throw new Exception("User update failed");
        }

    }
}
