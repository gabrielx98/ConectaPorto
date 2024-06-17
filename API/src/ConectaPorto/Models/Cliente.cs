using ConectaPorto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Models
{
    public class Cliente
    {
        public Cliente() { }
        public Cliente(ClienteDto dto) { 
            Id = dto.Id;
            Nome = dto.Nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        
    }
}
