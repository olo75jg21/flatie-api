using Flatie.Dal.Repositories.Interfaces;
using Flatie.Db;
using Flatie.Db.Entities;

namespace Flatie.Dal.Repositories
{
    public class InvitationRepository : Repository<Invitation>, IInvitationRepository
    {
        public InvitationRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}