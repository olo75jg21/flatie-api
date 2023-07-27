using Flatie.Db;
using Flatie.Db.Entities;

namespace Flatie.Dal.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetByIdWithDetailsAsync(int id);
        Task<List<User>> GetAllWithDetailsAsync();
    }
}