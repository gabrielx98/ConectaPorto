using ConectaPorto.Models;
using RestSharp;
using ConectaPorto.Web.Repository.Interface;

namespace ConectaPorto.Web.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly RestClient client;
        private readonly string origin;

        public ClienteRepository(IConfiguration configuration, IHttpContextAccessor httpContext)
        {
            origin = $"{httpContext?.HttpContext?.Request?.Scheme}://{httpContext?.HttpContext?.Request?.Host}";
            client = new RestClient(configuration["UriApi"]);
        }

        public async Task<ApiResponse<List<Cliente>>> ObterClientes()
        {
            var rest = "/api/Cliente/Listar";
            var request = new RestRequest(rest, Method.Get);
            request.AddHeader("Origin",origin);
            var response = await client.ExecuteAsync(request);
            return ApiResponse<List<Cliente>>.Create(response);
        }

        public async Task<ApiResponse<Cliente>> BuscarCliente(int id)
        {
            var rest = $"/api/Cliente/Buscar/{id}";
            var request = new RestRequest(rest, Method.Post);
            request.AddHeader("Origin", origin);
            var response = await client.ExecuteAsync(request);
            return ApiResponse<Cliente>.Create(response);
        }

        public async Task<ApiResponse<Cliente>> CadastrarCliente(Cliente cliente)
        {
            var rest = $"/api/Cliente/Cadastrar";
            var request = new RestRequest(rest, Method.Post);
            request.AddHeader("Origin", origin);
            request.AddBody(cliente);
            var response = await client.ExecuteAsync(request);
            return ApiResponse<Cliente>.Create(response);
        }

        public async Task<ApiResponse<Cliente>> AtualizarCliente(Cliente cliente)
        {
            var rest = $"/api/Cliente/Atualizar";
            var request = new RestRequest(rest, Method.Post);
            request.AddHeader("Origin", origin);
            request.AddBody(cliente);
            var response = await client.ExecuteAsync(request);
            return ApiResponse<Cliente>.Create(response);
        }

        public async Task<ApiResponse<Cliente>> RemoverCliente(int id)
        {
            var rest = $"/api/Cliente/Remover/{id}";
            var request = new RestRequest(rest, Method.Delete);
            request.AddHeader("Origin", origin);
            var response = await client.ExecuteAsync(request);
            return ApiResponse<Cliente>.Create(response);
        }
    }
}
