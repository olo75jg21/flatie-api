using Flatie.Db;
using Flatie.Db.Entities;

namespace Flatie.Dal.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<List<User>> GetAllWithDetailsAsync();
    }
}