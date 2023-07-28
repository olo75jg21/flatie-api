using Flatie.Dal.Repositories.Interfaces;
using Flatie.Db;
using Flatie.Db.Entities;

namespace Flatie.Dal.Repositories
{
    public class AuthRepository : Repository<User>, IAuthRepository
    {
        public AuthRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}