using ConectaPorto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Services.BizService.Interfaces
{
    public interface IVisitStateBizService
    {
        public Task<List<VisitState>> ListarVisitStates();
        public Task<VisitState> BuscarVisitState(int id);
        public Task CadastrarVisitState(VisitState visitState);
        public Task AtualizarVisitState(VisitState visitState);
        public Task RemoverVisitState(int id);
    }
}
