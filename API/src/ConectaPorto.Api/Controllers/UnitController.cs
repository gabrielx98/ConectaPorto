using ConectaPorto.Dto;
using ConectaPorto.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConectaPorto.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        [HttpGet]
        [ApiExplorerSettings(GroupName = "Usuario")]
        public Unit Get()
        {
            return new Unit();
        }
    }
}
