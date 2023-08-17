using Flatie.Dal.Repositories.Interfaces;
using Flatie.Db;
using Flatie.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Flatie.Dal.Repositories
{
    public class HomeSpaceRepository : Repository<HomeSpace>, IHomeSpaceRepository
    {
        public HomeSpaceRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<User>> GetAllHomeSpaceMembers(int homeSpaceId)
        {
            var homeSpaceMemebers = await _dbContext.HomeSpaceMembers
                .Where(homeSpaceMember => homeSpaceMember.HomeSpaceId == homeSpaceId)
                .Select(homeSpaceMember => homeSpaceMember.User)
                .ToListAsync();

            return homeSpaceMemebers!;
        }
    }
}