using ConectaPorto.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectaPorto.Formatadores;

namespace ConectaPorto.Models
{
    public class Cliente
    {
        public Cliente() { }
        public Cliente(ClienteDto dto) { 
            Id = dto.Id;
            Nome = dto.Nome;
            CNPJ = CnpjFormatador.IncluirMascara(dto.CNPJ);
        }

        public int Id { get; set; }
        [Range(000000000000, 999999999999, ErrorMessage = "Número Máximo de 18 digitos.")]
        public string CNPJ { get; set; }
        public string Nome { get; set; }
        
    }
}
