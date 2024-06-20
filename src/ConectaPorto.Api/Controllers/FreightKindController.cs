using ConectaPorto.Models;
using ConectaPorto.Services.BizService;
using ConectaPorto.Services.BizService.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConectaPorto.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "Administrador")]
    public class FreightKindController : ControllerBase
    {
        private readonly IFreightKindBizService _freightKindBizService;

        public FreightKindController(IFreightKindBizService freightKindBizService)
        {
            _freightKindBizService = freightKindBizService;
        }

        [HttpGet("[action]")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<FreightKind>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<List<FreightKind>> Listar()
        {
            return await _freightKindBizService.ListarFreightKinds();
        }

        [HttpGet("[action]/{id}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(FreightKind), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<FreightKind> Buscar(int id)
        {
            return await _freightKindBizService.BuscarFreightKind(id);
        }

        [HttpPost("[action]")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(FreightKind), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Cadastrar(FreightKind freightKind)
        {
            await _freightKindBizService.AtualizarFreightKind(freightKind);
            return Ok();
        }

        [HttpPost("[action]")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Atualizar(FreightKind freightKind)
        {
            await _freightKindBizService.AtualizarFreightKind(freightKind);
            return Ok();
        }

        [HttpDelete("[action]/{id}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Remover(int id)
        {
            await _freightKindBizService.RemoverFreightKind(id);
            return Ok();
        }
    }
}
