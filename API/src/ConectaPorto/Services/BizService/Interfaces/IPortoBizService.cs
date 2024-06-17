using ConectaPorto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Services.BizService.Interfaces
{
    public interface IPortoBizService
    {
        public Task<List<Porto>> ListarPortos();
        public Task<Porto> BuscarPorto(int id);
        public Task CadastrarPorto(Porto porto);
        public Task AtualizarPorto(Porto porto);
        public Task RemoverPorto(int id);
    }
}
