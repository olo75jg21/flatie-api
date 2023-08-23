using Flatie.Dto.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Flatie.Api.Controllers.Interfaces
{
    public interface IUserController
    {
        Task<ActionResult<UserDto>> GetSingle(int id);
        Task<ActionResult<UserDetailDto>> GetSingleWithDetails(int id);
        Task<ActionResult<IEnumerable<UserDto>>> GetAll();
        Task<ActionResult<IEnumerable<UserDetailDto>>> GetAllWithDetails();
        Task<ActionResult<IEnumerable<HomeSpaceDto>>> GetUserHomeSpaces(int userId);
    }
}