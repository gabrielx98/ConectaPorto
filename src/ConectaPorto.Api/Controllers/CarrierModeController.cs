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
    public class CarrierModeController : ControllerBase
    {
        private readonly ICarrierModeBizService _carrierModeBizService;

        public CarrierModeController(ICarrierModeBizService carrierModeBizService)
        {
            _carrierModeBizService = carrierModeBizService;
        }

        [HttpGet("[action]")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<CarrierMode>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<List<CarrierMode>> Listar()
        {
            return await _carrierModeBizService.ListarCarrierModes();
        }

        [HttpGet("[action]/{id}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(CarrierMode), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<CarrierMode> Buscar(int id)
        {
            return await _carrierModeBizService.BuscarCarrierMode(id);
        }

        [HttpPost("[action]")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(CarrierMode), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Cadastrar(CarrierMode carrierMode)
        {
            await _carrierModeBizService.AtualizarCarrierMode(carrierMode);
            return Ok();
        }

        [HttpPost("[action]")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Atualizar(CarrierMode carrierMode)
        {
            await _carrierModeBizService.AtualizarCarrierMode(carrierMode);
            return Ok();
        }

        [HttpDelete("[action]/{id}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Remover(int id)
        {
            await _carrierModeBizService.RemoverCarrierMode(id);
            return Ok();
        }
    }
}
