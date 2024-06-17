using ConectaPorto.Dto;
using ConectaPorto.Models;
using ConectaPorto.Services.BizService;
using ConectaPorto.Services.BizService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.DirectoryServices.Protocols;
using System.Net;

namespace ConectaPorto.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteBizService _clienteBizService;
        public ClienteController(IClienteBizService clienteBizService)
        {
            _clienteBizService = clienteBizService;
        }

        [HttpGet("[action]")]
        [Produces("application/json")]
        [ApiExplorerSettings(GroupName = "Usuario")]
        [ProducesResponseType(typeof(List<Cliente>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<List<Cliente>> Clientes()
        {
            var response = await _clienteBizService.ListarClientes();
            return response;
        }

        [HttpGet("[action]")]
        [Produces("application/json")]
        [ApiExplorerSettings(GroupName = "Usuario")]
        [ProducesResponseType(typeof(Cliente), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Cliente> Cliente(int id)
        {
            return await _clienteBizService.BuscarCliente(id);
        }

        [HttpPost("[action]")]
        [Produces("application/json")]
        [ApiExplorerSettings(GroupName = "Usuario")]
        [ProducesResponseType(typeof(Cliente), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Cadastrar(Cliente cliente)
        {
            await _clienteBizService.CadastrarCliente(cliente);
            return Ok();
        }

        [HttpPost("[action]")]
        [Produces("application/json")]
        [ApiExplorerSettings(GroupName = "Usuario")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Atualizar(Cliente cliente)
        {
             await _clienteBizService.AtualizarCliente(cliente);
            return Ok();
        }

        [HttpDelete("[action]")]
        [Produces("application/json")]
        [ApiExplorerSettings(GroupName = "Usuario")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Remover(int id)
        {
            await _clienteBizService.RemoverCliente(id);
            return Ok();
        }
    }
}
