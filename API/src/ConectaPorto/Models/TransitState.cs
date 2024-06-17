using ConectaPorto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Models
{
    public class TransitState
    {
        public TransitState() { }
        public TransitState(TransitStateDto dto) {
            Id = dto.Id;
            Descricao = dto.Descricao;
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
