using ConectaPorto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Models
{
    public class Iso
    {
        public Iso() { }
        public Iso(IsoDto dto) {
            Id = dto.Id;
            Codigo = dto.Codigo;
            Descricao = dto.Descricao;
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
    }
}
