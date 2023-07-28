using Flatie.Dto.Fvo;
using Microsoft.AspNetCore.Mvc;

namespace Flatie.Api.Controllers.Interfaces
{
    public interface IAuthController
    {
        Task<ActionResult<int>> Register(UserRegisterFvo userRegisterFvo);
    }
}