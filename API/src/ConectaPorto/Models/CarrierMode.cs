using ConectaPorto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Models
{
    public class CarrierMode
    {
        public CarrierMode() { }
        public CarrierMode(CarrierModeDto dto) {
            Id = dto.Id;
            Veiculo = dto.Veiculo;
        }

        public int Id { get; set; }
        public string Veiculo { get; set; }
    }
}
