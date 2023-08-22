using Flatie.Dal.Repositories.Interfaces;
using Flatie.Db;
using Flatie.Db.Entities;
using Microsoft.EntityFrameworkCore;

namespace Flatie.Dal.Repositories
{
    public class InvitationRepository : Repository<Invitation>, IInvitationRepository
    {
        public InvitationRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Invitation>> FindByRecipientUserIdAsync(int recipientUserId)
        {
            var invitations = await _dbContext.Invitations
                .Include(i => i.SenderUser)
                .Include(i => i.RecipientUser)
                .Include(i => i.HomeSpace)
                .Where(i => i.RecipientUserId == recipientUserId)
                .ToListAsync();

            return invitations;
        }
    }
}