using ConectaPorto.Web.Extensions;
using ConectaPorto.Models;

namespace ConectaPorto.Web.ViewModel
{
    public class ClienteViewModel : PaginacaoExtension<Cliente>
    {
        public string ColunaFiltro { get; set; }
        public string ValorFiltro { get; set; }
    }
}
