using ConectaPorto.Dto;
using ConectaPorto.Models;
using ConectaPorto.Services.BizService;
using ConectaPorto.Services.BizService.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConectaPorto.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "Usuario")]
    public class UnitController : ControllerBase
    {
        private readonly IUnitBizService _unitBizService;

        public UnitController(IUnitBizService unitBizService)
        {
            _unitBizService = unitBizService;
        }

        [HttpGet("[action]")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<Unit>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<List<Unit>> Listar()
        {
            return await _unitBizService.ListarUnits();
        }

        [HttpGet("[action]/{id}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(Unit), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Unit> Buscar(int id)
        {
            return await _unitBizService.BuscarUnit(id);
        }

        [HttpPost("[action]")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(Unit), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Cadastrar(Unit unit)
        {
            await _unitBizService.CadastrarUnit(unit);
            return Ok();
        }

        [HttpPost("[action]")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Atualizar(Unit unit)
        {
            await _unitBizService.AtualizarUnit(unit);
            return Ok();
        }

        [HttpDelete("[action]/{id}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Remover(int id)
        {
            await _unitBizService.RemoverUnit(id);
            return Ok();
        }
    }
}
