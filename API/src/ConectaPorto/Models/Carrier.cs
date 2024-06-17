using ConectaPorto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Models
{
    public class Carrier
    {
        public Carrier() { }
        public Carrier(CarrierDto dto)
        {
            Id = dto.Id;
            Codigo = dto.Codigo;
            VisitState = dto.VisitState;
            DataPartida = dto.DataPartida;
            DataChegada = dto.DataChegada;
            POL = dto.POL;
            POD = dto.POD;
            CarrierMode = dto.CarrierMode;
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public VisitStateDto VisitState { get; set; }
        public DateTime DataPartida { get; set; }
        public DateTime DataChegada { get; set; }
        public PortoDto POL { get; set; }
        public PortoDto POD { get; set; }
        public CarrierModeDto CarrierMode { get; set; }
    }
}
