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
    public class TransitStateController : ControllerBase
    {
        private readonly ITransitStateBizService _transitStateBizService;

        public TransitStateController(ITransitStateBizService transitStateBizService)
        {
            _transitStateBizService = transitStateBizService;
        }
        [HttpGet("[action]")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<TransitState>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<List<TransitState>> Listar()
        {
            return await _transitStateBizService.ListarTransitStates();
        }

        [HttpGet("[action]/{id}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(TransitState), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<TransitState> Buscar(int id)
        {
            return await _transitStateBizService.BuscarTransitState(id);
        }

        [HttpPost("[action]")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(TransitState), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Cadastrar(TransitState transitState)
        {
            await _transitStateBizService.AtualizarTransitState(transitState);
            return Ok();
        }

        [HttpPost("[action]")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Atualizar(TransitState transitState)
        {
            await _transitStateBizService.AtualizarTransitState(transitState);
            return Ok();
        }

        [HttpDelete("[action]/{id}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Remover(int id)
        {
            await _transitStateBizService.RemoverTransitState(id);
            return Ok();
        }
    }
}
