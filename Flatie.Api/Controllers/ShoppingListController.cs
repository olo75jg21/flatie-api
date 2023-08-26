using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flatie.Api.Controllers.Interfaces;
using Flatie.Dto.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Flatie.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShoppingListController : ControllerBase, IShoppingListController
    {
    }
}