using ConectaPorto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Models
{
    public class Transportadora
    {
        public Transportadora() { }
        public Transportadora(TransportadoraDto dto) {
            Id = dto.Id;
            Cicla = dto.Cicla;
            Nome = dto.Nome;
            CNPJ = dto.CNPJ;
        }

        public int Id { get; set; }
        public string Cicla { get; set; }
        public string Nome { get; set; }
        public int CNPJ { get; set; }
    }
}
