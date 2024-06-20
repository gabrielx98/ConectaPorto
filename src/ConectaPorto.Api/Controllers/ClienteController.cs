using ConectaPorto.Dto;
using ConectaPorto.Models;
using ConectaPorto.Services.BizService;
using ConectaPorto.Services.BizService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.DirectoryServices.Protocols;
using System.Net;
using System.Threading;

namespace ConectaPorto.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "Usuario")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteBizService _clienteBizService;
        public ClienteController(IClienteBizService clienteBizService)
        {
            _clienteBizService = clienteBizService;
        }

        [HttpGet("[action]")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<Cliente>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<List<Cliente>> Listar()
        {
            return await _clienteBizService.ListarClientes();
        }

        [HttpGet("[action]/{id}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(Cliente), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Cliente> Buscar(int id)
        {
            return await _clienteBizService.BuscarCliente(id);
        }

        [HttpPost("[action]")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(ApiResponse<Cliente>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<Cliente>), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse<Cliente>>> Cadastrar(Cliente cliente)
        {
            var response = await _clienteBizService.CadastrarCliente(cliente);
            if (response.HasErrors)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost("[action]")]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Atualizar(Cliente cliente)
        {
             await _clienteBizService.AtualizarCliente(cliente);
            return Ok();
        }

        [HttpDelete("[action]/{id}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(ApiResponse<Cliente>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse<Cliente>), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse<Cliente>>> Remover(int id)
        {
            var response = await _clienteBizService.RemoverCliente(id);
            if (response.HasErrors)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}
