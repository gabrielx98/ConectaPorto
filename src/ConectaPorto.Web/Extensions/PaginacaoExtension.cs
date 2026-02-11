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

        public PaginacaoExtension<T> Paginar(List<T> values, int pagina, int qtdItens, string colunaFiltro, string valorFiltro) {
            this.TotalItens = values.Count;
            this.PaginaAtual = pagina;
            this.ItensPorPagina = qtdItens;
            this.TotalPaginas = (int)Math.Ceiling(this.TotalItens / (double)this.ItensPorPagina);

            if(colunaFiltro != null && valorFiltro != null)
            {
                var query = values.AsQueryable();

                query = AplicarFiltro(query, colunaFiltro, valorFiltro);

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
            var propertyType = property.Type;
            var containsMethod = typeof(string).GetMethod("Contains", new[] { typeof(string) });
            Expression filter;

            if (propertyType == typeof(string))
            {
                filter = Expression.Call(property, containsMethod, Expression.Constant(value, typeof(string)));
            }
            else if (propertyType == typeof(int) && int.TryParse(value, out int intValue))
            {
                filter = Expression.Equal(property, Expression.Constant(intValue));
            }
            else if (propertyType == typeof(long) && long.TryParse(value, out long longValue))
            {
                filter = Expression.Equal(property, Expression.Constant(longValue));
            }
            else if (propertyType == typeof(DateTime) && DateTime.TryParse(value, out DateTime dateValue))
            {
                filter = Expression.Equal(property, Expression.Constant(dateValue));
            }
            else
            {
                throw new NotSupportedException($"Tipo de propriedade '{propertyType}' não suportado.");
            }

            var lambda = Expression.Lambda<Func<T, bool>>(filter, parameter);

            return source.Where(lambda);
        }
    }
}
