using System.Linq.Expressions;

namespace ConectaPorto.Web.Extensions
{
    public class PaginacaoExtension<T>
    {
        public int TotalItens { get; set; }
        public int TotalPaginas { get; set; }
        public int PaginaAtual {  get; set; }
        public int ItensPorPagina { get; set; }
        public List<T> Values { get; set; }

        public PaginacaoExtension<T> Paginar(List<T> values, int pagina, int qtdItens, string filtroCampo, string filtroValor) {
            this.TotalItens = values.Count;
            this.PaginaAtual = pagina;
            this.ItensPorPagina = qtdItens;
            this.TotalPaginas = (int)Math.Ceiling(this.TotalItens / (double)this.ItensPorPagina);

            //this.Values = values.Skip((this.PaginaAtual - 1) * this.ItensPorPagina).Take(this.ItensPorPagina).ToList();
            if(filtroCampo != null)
            {
                var query = values.AsQueryable();

                query = AplicarFiltro(query, filtroCampo, filtroValor);

                this.Values = query.Skip((this.PaginaAtual - 1) * this.ItensPorPagina).Take(this.ItensPorPagina).ToList();
            }
            else
            {
                this.Values = values.Skip((this.PaginaAtual - 1) * this.ItensPorPagina).Take(this.ItensPorPagina).ToList();
            }
            

            return this;
        }
        private IQueryable<T> AplicarFiltro(IQueryable<T> source, string propertyName, string value)
        {
            var parameter = Expression.Parameter(typeof(T), "x");
            var property = Expression.Property(parameter, propertyName);
            var containsMethod = typeof(string).GetMethod("Contains", new[] { typeof(string) });
            var filter = Expression.Call(property, containsMethod, Expression.Constant(value, typeof(string)));
            var lambda = Expression.Lambda<Func<T, bool>>(filter, parameter);

            return source.Where(lambda);
        }
    }
}
