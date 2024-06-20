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
    public class CarrierModeDto
    {
        public CarrierModeDto() { }
        public CarrierModeDto(CarrierMode model) { 
            Id = model.Id;
            Veiculo = model.Veiculo;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Veiculo { get; set; }
    }
}
