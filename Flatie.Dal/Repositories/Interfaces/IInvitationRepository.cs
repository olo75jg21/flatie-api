using Flatie.Db;
using Flatie.Db.Entities;

namespace Flatie.Dal.Repositories.Interfaces
{
    public interface IInvitationRepository : IRepository<Invitation>
    {
        Task<IEnumerable<Invitation>> FindByRecipientUserIdAsync(int recipientUserId);
    }
}