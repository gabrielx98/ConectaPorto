using ConectaPorto.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            CNPJ = dto.CNPJ;
        }

        public int Id { get; set; }
        [Range(00000000000, 99999999999, ErrorMessage = "Número Máximo de 14 digitos.")]
        public long CNPJ { get; set; }
        public string Nome { get; set; }
        
    }
}
