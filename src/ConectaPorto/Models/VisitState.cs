using ConectaPorto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Models
{
    public class VisitState
    {
        public VisitState() { }
        public VisitState(VisitStateDto dto) {
            Id = dto.Id;
            Situacao = dto.Situacao;
        }
        public int Id { get; set; }
        public string Situacao { get; set; }
    }
}
