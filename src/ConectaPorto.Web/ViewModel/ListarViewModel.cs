using ConectaPorto.Models;
using System.Reflection;

namespace ConectaPorto.Web.ViewModel
{
    public class ListarViewModel
    {
        public string TituloPagina { get; set; }
        public List<string> Colunas { get; set; }
        public List<List<string>> Linhas { get; set; }
        public int TotalItens { get; set; }
    }
}
