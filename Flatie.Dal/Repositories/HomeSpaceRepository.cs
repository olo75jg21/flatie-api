using Flatie.Dal.Repositories.Interfaces;
using Flatie.Db;
using Flatie.Db.Entities;

namespace Flatie.Dal.Repositories
{
    public class HomeSpaceRepository : Repository<HomeSpace>, IHomeSpaceRepository
    {
        public HomeSpaceRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}