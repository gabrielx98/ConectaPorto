using ConectaPorto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Services.BizService.Interfaces
{
    public interface ITransportadoraBizService
    {
        public Task<List<Transportadora>> ListarTransportadoras();
        public Task<Transportadora> BuscarTransportadora(int id);
        public Task CadastrarTransportadora(Transportadora transportadora);
        public Task AtualizarTransportadora(Transportadora transportadora);
        public Task RemoverTransportadora(int id);
    }
}
