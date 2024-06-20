using ConectaPorto.Dto;
using ConectaPorto.Models;
using ConectaPorto.Services.BizService.Interfaces;
using ConectaPorto.Services.EntityService.Interfaces;
using System;
using System.Collections.Generic;
using System.DirectoryServices.Protocols;
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

        public async Task<ApiResponse<Cliente>> CadastrarCliente(Cliente cliente)
        {
            var apiResponse = new ApiResponse<Cliente>();
            var verificaId = await _clienteEntityService.GetById(cliente.Id);
            var verificaCnpj = await _clienteEntityService.GetByCNPJ(cliente.CNPJ);
            if(verificaId != null)
            {
                apiResponse.Errors.Add("id", "Identificador já cadastrado");
            }
            if(verificaCnpj.Any()) {
                apiResponse.Errors.Add("cnpj", "CNPJ já cadastrado");
            }
            if(!apiResponse.Errors.Any())
            {
                await _clienteEntityService.Set(new ClienteDto(cliente));
            }
            apiResponse.Data = cliente;
            return apiResponse;
        }

        public async Task AtualizarCliente(Cliente cliente)
        {
            await _clienteEntityService.Update(new ClienteDto(cliente));
        }

        public async Task<ApiResponse<Cliente>> RemoverCliente(int id)
        {
            var apiResponse = new ApiResponse<Cliente>();
            var verificaId = await _clienteEntityService.GetById(id);
            if(verificaId == null)
            {
                apiResponse.Errors.Add("id", "Identificador não existe");
            }
            if (!apiResponse.Errors.Any())
            {
                await _clienteEntityService.Delete(id);
                apiResponse.Data = new Cliente(verificaId);
            }
            return apiResponse;
        }
    }
}
