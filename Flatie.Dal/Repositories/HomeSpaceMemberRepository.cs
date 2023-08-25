using Flatie.Dal.Repositories.Interfaces;
using Flatie.Db;
using Flatie.Db.Entities;

namespace Flatie.Dal.Repositories
{
    public class HomeSpaceMemberRepository : Repository<HomeSpaceMember>, IHomeSpaceMemberRepository
    {
        public HomeSpaceMemberRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}