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
    public class IsoController : ControllerBase
    {
        private readonly IIsoBizService _isoBizService;

        public IsoController(IIsoBizService isoBizService)
        {
            _isoBizService = isoBizService;
        }

        [HttpGet("[action]")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<Iso>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<List<Iso>> Listar()
        {
            return await _isoBizService.ListarIsos();
        }

        [HttpGet("[action]/{id}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(Iso), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Iso> Buscar(int id)
        {
            return await _isoBizService.BuscarIso(id);
        }

        [HttpPost("[action]")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(Iso), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Cadastrar(Iso iso)
        {
            await _isoBizService.AtualizarIso(iso);
            return Ok();
        }

        [HttpPost("[action]")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Atualizar(Iso iso)
        {
            await _isoBizService.AtualizarIso(iso);
            return Ok();
        }

        [HttpDelete("[action]/{id}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Remover(int id)
        {
            await _isoBizService.RemoverIso(id);
            return Ok();
        }
    }
}
