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

        [HttpGet("Clientes")]
        [Produces("application/json")]
        [ApiExplorerSettings(GroupName = "Administrador")]
        [ProducesResponseType(typeof(List<Cliente>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Cliente> Clientes()
        {
            var response = _clienteBizService.TodosClientes();
            return response;
        }

        [HttpGet("Cliente")]
        [Produces("application/json")]
        [ApiExplorerSettings(GroupName = "Administrador")]
        [ProducesResponseType(typeof(Cliente), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Cliente Cliente(int id)
        {
            return _clienteBizService.BuscarCliente(id);
        }

        [HttpPost("Cadastrar")]
        [Produces("application/json")]
        [ApiExplorerSettings(GroupName = "Administrador")]
        [ProducesResponseType(typeof(Cliente), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public string Cadastrar(Cliente cliente)
        {
            var response = _clienteBizService.CadastrarCliente(cliente);
            return response;
        }

        [HttpPost("Atualizar")]
        [Produces("application/json")]
        [ApiExplorerSettings(GroupName = "Administrador")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Atualizar(Cliente cliente)
        {
             await _clienteBizService.AtualizarCliente(cliente);
            return Ok();
        }

        [HttpDelete("Remover")]
        [Produces("application/json")]
        [ApiExplorerSettings(GroupName = "Administrador")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Remover(int id)
        {
            await _clienteBizService.RemoverCliente(id);
            return Ok();
        }
    }
}
