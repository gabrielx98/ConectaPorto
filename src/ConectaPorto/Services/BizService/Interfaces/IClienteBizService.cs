using ConectaPorto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Services.BizService.Interfaces
{
    public interface IClienteBizService
    {
        public Task<List<Cliente>> ListarClientes();
        public Task<Cliente> BuscarCliente(int id);
        public Task<ApiResponse<Cliente>> CadastrarCliente(Cliente cliente);
        public Task AtualizarCliente(Cliente cliente);
        public Task<ApiResponse<Cliente>> RemoverCliente(int id);
    }
}
