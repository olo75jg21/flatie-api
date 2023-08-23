using Flatie.Dal.Repositories.Interfaces;
using Flatie.Db;
using Flatie.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Flatie.Dal.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AppDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<User> GetByIdWithDetailsAsync(int id)
        {
            return await _dbContext.Set<User>()
                .Include(u => u.UserAppRole)
                .Include(u => u.Notifications)
                .Include(u => u.ShoppingLists)
                .Include(u => u.QuietHours)
                .Include(u => u.Guests)
                .Include(u => u.UserTasks)
                .Include(u => u.HomeSpaces)
                .SingleAsync(u => u.Id == id);
        }

        public async Task<List<User>> GetAllWithDetailsAsync()
        {
            return await _dbContext.Set<User>()
                .Include(u => u.UserAppRole)
                .Include(u => u.Notifications)
                .Include(u => u.ShoppingLists)
                .Include(u => u.QuietHours)
                .Include(u => u.Guests)
                .Include(u => u.UserTasks)
                .Include(u => u.HomeSpaces)
                .ToListAsync();
        }

        public async Task<List<HomeSpace>> GetUserHomeSpacesAsync(int userId)
        {
            return await _dbContext.HomeSpaces
                .Where(homeSpace => homeSpace.Users.Any(user => user.Id == userId))
                .ToListAsync();
        }
    }
}