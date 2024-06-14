using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Dto
{
    public class UnitDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nbr { get; set; }
        public ClienteDto Proprietario { get; set; }
        public IsoDto Iso { get; set; }
        public UnitCategoryDto Categoria { get; set; }
        public TransportadoraDto Transportadora { get; set; }
        public string Booking {  get; set; }
        public FreightKindDto FreightKind { get; set; }
        public TransportadoraDto TransitState {  get; set; }
        public CarrierDto CarrierIb {  get; set; }
        public CarrierDto CarrierOb { get; set; }
    }
}
