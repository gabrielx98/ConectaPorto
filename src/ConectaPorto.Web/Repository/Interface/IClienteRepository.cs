using ConectaPorto.Models;

namespace ConectaPorto.Web.Repository.Interface
{
    public interface IClienteRepository
    {
        public Task<ApiResponse<List<Cliente>>> ObterClientes();
        public Task<ApiResponse<Cliente>> BuscarCliente(int id);
        public Task<ApiResponse<Cliente>> CadastrarCliente(Cliente cliente);
        public Task<ApiResponse<Cliente>> AtualizarCliente(Cliente cliente);
        public Task<ApiResponse<Cliente>> RemoverCliente(int id);
    }
}
