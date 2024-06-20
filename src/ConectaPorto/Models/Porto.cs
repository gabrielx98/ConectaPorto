using ConectaPorto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Models
{
    public class Porto
    {
        public Porto() { }
        public Porto(PortoDto dto) {
            Id = dto.Id;
            Cicla = dto.Cicla;
            Cidade = dto.Cidade;
            Pais = dto.Pais;
        }

        public int Id { get; set; }
        public string Cicla { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }
    }
}
