using ConectaPorto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Services.BizService.Interfaces
{
    public interface IIsoBizService
    {
        public Task<List<Iso>> ListarIsos();
        public Task<Iso> BuscarIso(int id);
        public Task CadastrarIso(Iso iso);
        public Task AtualizarIso(Iso iso);
        public Task RemoverIso(int id);
    }
}
