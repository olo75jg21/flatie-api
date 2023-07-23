using Flatie.Dal.Repositories.Interfaces;
using Flatie.Db;
using Flatie.Db.Entities;

namespace Flatie.Dal.Repositories
{
    public class UserAppRoleRepository : Repository<UserAppRole>, IUserAppRoleRepository
    {
        public UserAppRoleRepository(AppDbContext dbContext) : base(dbContext) { }
    }
}