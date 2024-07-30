using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectaPorto.Models;

namespace ConectaPorto.Dto
{
    public class TransportadoraDto
    {
        public TransportadoraDto() { }
        public TransportadoraDto(Transportadora model) {
            Id = model.Id;
            Cicla = model.Cicla;
            Nome = model.Nome;
            CNPJ = model.CNPJ;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Cicla {  get; set; }
        public string Nome { get; set;}
        public long CNPJ { get; set; }
    }
}
