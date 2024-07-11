using ConectaPorto.Models;
using ConectaPorto.Web.ViewModel;
using System.Reflection;

namespace ConectaPorto.Web.Extensions
{
    public class ListarViewModelExtension<T>
    {
        public static ListarViewModel Converter(List<T> dados) {
            var retorno = new ListarViewModel();
            retorno.Linhas = Linhas(dados);
            retorno.Colunas = Colunas();
            retorno.TotalItens = dados.Count;
            retorno.TituloPagina = typeof(T).Name;
            return retorno;
        }
        private static List<string> Colunas()
        {
            return typeof(T).GetProperties().Select(x => x.Name).ToList();
        }

        private static List<List<string>> Linhas(List<T> lista)
        {
            var retorno = new List<List<string>>();
            foreach (var item in lista)
            {
                var itemRetorno = new List<string>();
                PropertyInfo[] properties = typeof(T).GetProperties();
                foreach (var property in properties)
                {
                    itemRetorno.Add(property.GetValue(item).ToString());
                }
                retorno.Add(itemRetorno);
            }
            return retorno;
        }
    }
}
