using ConectaPorto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Services.BizService.Interfaces
{
    public interface IUsuarioBizService
    {
        public Task<List<Usuario>> ListarUsuario();
        public Task<Usuario> BuscarUsuario(int id);
        public Task CadastrarUsuario(Usuario usuario);
        public Task AtualizarUsuario(Usuario usuario);
        public Task RemoverUsuario(int id);
    }
}
