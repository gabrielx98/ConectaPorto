using ConectaPorto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Services.BizService.Interfaces
{
    public interface IUnitBizService
    {
        public Task<List<Unit>> ListarUnits();
        public Task<Unit> BuscarUnit(int id);
        public Task CadastrarUnit(Unit unit);
        public Task AtualizarUnit(Unit unit);
        public Task RemoverUnit(int id);
    }
}
