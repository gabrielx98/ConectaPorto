using ConectaPorto.Dto;
using ConectaPorto.Models;
using ConectaPorto.Services.BizService.Interfaces;
using ConectaPorto.Services.EntityService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Services.BizService
{
    public class UsuarioBizService : IUsuarioBizService
    {
        private readonly IUsuarioEntityService _usuarioEntityService;

        public UsuarioBizService(IUsuarioEntityService usuarioEntityService)
        {
            _usuarioEntityService = usuarioEntityService;
        }

        public async Task<List<Usuario>> ListarUsuario()
        {
            var usuarios = (await _usuarioEntityService.GetAll()).ToList().OrderBy(x => x.Id);
            var result = new List<Usuario>();
            foreach(var usuario in usuarios)
            {
                result.Add(new Usuario(usuario));
            }
            return result;
        }

        public async Task<Usuario> BuscarUsuario(int id)
        {
            var usuario = await _usuarioEntityService.GetById(id);
            return new Usuario(usuario);
        }

        public async Task CadastrarUsuario(Usuario usuario)
        {
            await _usuarioEntityService.Set(new UsuarioDto(usuario));
        }
        public async Task AtualizarUsuario(Usuario usuario)
        {
            await _usuarioEntityService.Update(new UsuarioDto(usuario));
        }

        public async Task RemoverUsuario(int id)
        {
            await _usuarioEntityService.Delete(id);
        }
    }
}
