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
        public int Id { get; set; }
        public string Nbr { get; set; }
        public string Proprietario { get; set; }
        public string Iso { get; set; }
        public string Categoria { get; set; }
        public string Transportadora { get; set; }
        public string Booking { get; set; }
        public string FreightKind { get; set; }
        public string TransitState { get; set; }
        public string CarrierIb { get; set; }
        public string CarrierOb { get; set; }
        public string UsuarioCriacao { get; set; }
        public string UsuarioAlteracao { get; set; }
        public string DataCriacao { get; set; }
        public string DataAlteracao { get; set; }
    }
}
