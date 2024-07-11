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
    }
}
