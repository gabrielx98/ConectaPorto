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
    public class UnitCategoryController : ControllerBase
    {
        private readonly IUnitCategoryBizService _unitCategoryBizService;

        public UnitCategoryController(IUnitCategoryBizService unitCategoryBizService)
        {
            _unitCategoryBizService = unitCategoryBizService;
        }

        [HttpGet("[action]")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<UnitCategory>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<List<UnitCategory>> Listar()
        {
            return await _unitCategoryBizService.ListarUnitCategorys();
        }

        [HttpGet("[action]/{id}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(UnitCategory), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<UnitCategory> Buscar(int id)
        {
            return await _unitCategoryBizService.BuscarUnitCategory(id);
        }

        [HttpPost("[action]")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(UnitCategory), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Cadastrar(UnitCategory unitCategory)
        {
            await _unitCategoryBizService.AtualizarUnitCategory(unitCategory);
            return Ok();
        }

        [HttpPost("[action]")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Atualizar(UnitCategory unitCategory)
        {
            await _unitCategoryBizService.AtualizarUnitCategory(unitCategory);
            return Ok();
        }

        [HttpDelete("[action]/{id}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Remover(int id)
        {
            await _unitCategoryBizService.RemoverUnitCategory(id);
            return Ok();
        }
    }
}
