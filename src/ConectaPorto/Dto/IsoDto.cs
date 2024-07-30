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
    public class IsoDto
    {
        public IsoDto() { }
        public IsoDto(Iso model) {
            Id = model.Id;
            Codigo = model.Codigo;
            Descricao = model.Descricao;
            Tamanho = model.Tamanho;
            Tipo = model.Tipo;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Codigo { get; set; }
        public int Tamanho { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
    }
}
