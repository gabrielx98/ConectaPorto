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
    public class CarrierController : ControllerBase
    {
        private readonly ICarrierBizService _carrierBizService;

        public CarrierController(ICarrierBizService carrierBizService)
        {
            _carrierBizService = carrierBizService;
        }

        [HttpGet("[action]")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<Carrier>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<List<Carrier>> Listar()
        {
            return await _carrierBizService.ListarCarriers();
        }

        [HttpGet("[action]/{id}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(Carrier), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Carrier> Buscar(int id)
        {
            return await _carrierBizService.BuscarCarrier(id);
        }

        [HttpPost("[action]")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(Carrier), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Cadastrar(Carrier carrier)
        {
            try
            {
                await _carrierBizService.CadastrarCarrier(carrier);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("[action]")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Atualizar(Carrier carrier)
        {
            await _carrierBizService.AtualizarCarrier(carrier);
            return Ok();
        }

        [HttpDelete("[action]/{id}")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Remover(int id)
        {
            await _carrierBizService.RemoverCarrier(id);
            return Ok();
        }
    }
}
