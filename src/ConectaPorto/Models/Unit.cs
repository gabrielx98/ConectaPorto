using ConectaPorto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Models
{
    public class Unit
    {
        public Unit() { }
        public Unit(UnitDto dto) {
            Id = dto.Id;
            Nbr = dto.Nbr;
            Proprietario = dto.Proprietario;
            Iso = dto.Iso;
            Categoria = dto.Categoria;
            Transportadora = dto.Transportadora;
            Booking = dto.Booking;
            FreightKind = dto.FreightKind;
            TransitState = dto.TransitState;
            CarrierIb = dto.CarrierIb;
            CarrierOb = dto.CarrierOb;
        }

        public int Id { get; set; }
        public string Nbr { get; set; }
        public ClienteDto Proprietario { get; set; }
        public IsoDto Iso { get; set; }
        public UnitCategoryDto Categoria { get; set; }
        public TransportadoraDto Transportadora { get; set; }
        public string Booking { get; set; }
        public FreightKindDto FreightKind { get; set; }
        public TransportadoraDto TransitState { get; set; }
        public CarrierDto CarrierIb { get; set; }
        public CarrierDto CarrierOb { get; set; }
        /*public string UsuarioCriacao { get; set; }
        public string UsuarioAlteracao { get; set; }
        public string DataCriacao { get; set; }
        public string DataAlteracao { get; set; }*/
    }
}
