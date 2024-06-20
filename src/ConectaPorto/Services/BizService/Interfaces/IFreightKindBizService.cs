using ConectaPorto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Services.BizService.Interfaces
{
    public interface IFreightKindBizService
    {
        public Task<List<FreightKind>> ListarFreightKinds();
        public Task<FreightKind> BuscarFreightKind(int id);
        public Task CadastrarFreightKind(FreightKind freightKind);
        public Task AtualizarFreightKind(FreightKind freightKind);
        public Task RemoverFreightKind(int id);
    }
}
