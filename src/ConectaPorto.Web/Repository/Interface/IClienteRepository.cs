using ConectaPorto.Models;

namespace ConectaPorto.Web.Repository.Interface
{
    public interface IClienteRepository
    {
        public Task<ApiResponse<List<Cliente>>> ObterClientes();
    }
}
