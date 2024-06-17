using ConectaPorto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Dto
{
    public class UsuarioDto
    {
        public UsuarioDto() { }
        public UsuarioDto(Usuario model) {
            Id = model.Id;
            Nome = model.Nome;
            Login = model.Login;
            Password = model.Password;
            PasswordHash = model.PasswordHash;
            Email = model.Email;
            Telefone = model.Telefone;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
