using Flatie.Dto.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Flatie.Api.Controllers.Interfaces
{
    public interface IUserController
    {
        Task<ActionResult<IEnumerable<UserDto>>> GetAll();
    }
}