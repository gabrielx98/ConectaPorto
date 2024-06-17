using ConectaPorto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Services.BizService.Interfaces
{
    public interface ITransitStateBizService
    {
        public Task<List<TransitState>> ListarTransitStates();
        public Task<TransitState> BuscarTransitState(int id);
        public Task CadastrarTransitState(TransitState transitState);
        public Task AtualizarTransitState(TransitState transitState);
        public Task RemoverTransitState(int id);
    }
}
