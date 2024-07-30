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
            Tamanho = dto.Tamanho;
            Tipo = dto.Tipo;
        }

        public int Id { get; set; }
        public int Codigo { get; set; }
        public int Tamanho { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
    }
}
