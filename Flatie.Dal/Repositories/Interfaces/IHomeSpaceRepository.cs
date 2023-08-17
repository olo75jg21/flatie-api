using Flatie.Db;
using Flatie.Db.Entities;

namespace Flatie.Dal.Repositories.Interfaces
{
    public interface IHomeSpaceRepository : IRepository<HomeSpace>
    {
        Task<IEnumerable<User>> GetAllHomeSpaceMembers(int homeSpaceId);
    }
}