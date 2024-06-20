using ConectaPorto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Dto
{
    public class VisitStateDto
    {
        public VisitStateDto() { }
        public VisitStateDto(VisitState model) {
            Id = model.Id;
            Situacao = model.Situacao;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Situacao { get; set; }
    }
}
