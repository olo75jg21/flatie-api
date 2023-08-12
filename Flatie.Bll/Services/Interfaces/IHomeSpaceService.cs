using Flatie.Dto.Dto;

namespace Flatie.Bll.Services.Interfaces
{
    public interface IHomeSpaceService
    {
        Task<IEnumerable<HomeSpaceDto>> GetUserHomeSpaces(int id);
    }
}