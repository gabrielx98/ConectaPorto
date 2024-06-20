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
    public class PortoDto
    {
        public PortoDto() { }
        public PortoDto(Porto model)
        {
            Id = model.Id;
            Cicla = model.Cicla;
            Cidade = model.Cidade;
            Pais = model.Pais;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Cicla { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }
    }
}
