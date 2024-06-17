using ConectaPorto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Models
{
    public class FreightKind
    {
        public FreightKind() { }
        public FreightKind(FreightKindDto dto) {
            Id = dto.Id;
            Cicla = dto.Cicla;
            Descricao = dto.Descricao;
        }

        public int Id { get; set; }
        public string Cicla { get; set; }
        public string Descricao { get; set; }
    }
}
