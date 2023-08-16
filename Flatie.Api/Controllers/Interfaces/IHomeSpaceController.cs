using Flatie.Dto.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Flatie.Api.Controllers.Interfaces
{
    public interface IHomeSpaceController
    {
        Task<ActionResult<IEnumerable<HomeSpaceDto>>> GetUserHomeSpaces(int id);
        Task<ActionResult<IEnumerable<UserDto>>> GetAllHomeSpaceMembers(int id);
    }
}