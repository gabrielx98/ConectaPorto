using ConectaPorto.Dto;
using ConectaPorto.Models;
using ConectaPorto.Services.BizService.Interfaces;
using ConectaPorto.Services.EntityService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Services.BizService
{
    public class ClienteBizService : IClienteBizService
    {
        private readonly IClienteEntityService _clienteEntityService;
        public ClienteBizService(IClienteEntityService clienteEntityService)
        {
            _clienteEntityService = clienteEntityService;
        }

        public async Task<List<Cliente>> ListarClientes()
        {
            var clientes = (await _clienteEntityService.GetAll()).ToList().OrderBy(x => x.Id);
            var result = new List<Cliente>();
            foreach (var item in clientes)
            {
                result.Add(new Cliente(item));
            }
            return result;
        }

        public async Task<Cliente> BuscarCliente(int id)
        {
            var cliente = await _clienteEntityService.GetById(id);
            return new Cliente(cliente);
        }

        public async Task CadastrarCliente(Cliente cliente)
        {
            await _clienteEntityService.Set(new ClienteDto(cliente));
        }

        public async Task AtualizarCliente(Cliente cliente)
        {
            await _clienteEntityService.Update(new ClienteDto(cliente));
        }

        public async Task RemoverCliente(int id)
        {
            await _clienteEntityService.Delete(id);
        }
    }
}
