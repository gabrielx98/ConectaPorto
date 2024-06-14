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

        public List<Cliente> TodosClientes()
        {
            var cliente = _clienteEntityService.GetAll().Result.ToList().OrderBy(cliente => cliente.Id);
            List<Cliente> lista = new List<Cliente>();
            foreach (var item in cliente)
            {
                lista.Add(new Cliente
                {
                    Id = item.Id,
                    Nome = item.Nome
                });
            }
            return lista;
        }

        public Cliente BuscarCliente(int id)
        {
            var cliente = _clienteEntityService.GetById(id).Result;
            return new Cliente
            {
                Id = cliente.Id,
                Nome = cliente.Nome
            };
        }

        public string CadastrarCliente(Cliente cliente)
        {
            return _clienteEntityService.Set(new ClienteDto
            {
                Nome = cliente.Nome,

            }).Result;
        }

        public async Task AtualizarCliente(Cliente cliente)
        {
            await _clienteEntityService.Update(new ClienteDto
            {
                Id = cliente.Id,
                Nome = cliente.Nome
            });
        }

        public async Task RemoverCliente(int id)
        {
            await _clienteEntityService.Delete(id);
        }
    }
}
