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
    public class ClienteDto
    {
        public ClienteDto() { }
        public ClienteDto(Cliente model) {
            Id = model.Id;
            Nome = model.Nome;
            CNPJ = model.CNPJ;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CNPJ { get; set; }
        public string Nome { get; set; }
    }
}
