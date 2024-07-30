using ConectaPorto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Models
{
    public class Usuario
    {
        public Usuario() { }
        public Usuario(UsuarioDto dto) {
            Id = dto.Id;
            Nome = dto.Nome;
            Login = dto.Login;
            Password = dto.Password;
            PasswordHash = dto.PasswordHash;
            Email = dto.Email;
            Telefone = dto.Telefone;
            CPF = dto.CPF;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public long CPF { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
