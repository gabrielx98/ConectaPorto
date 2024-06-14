using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Dto
{
    public class CarrierDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Codigo { get; set; }
        public VisitStateDto VisitState { get; set; }
        public DateTime DataPartida {  get; set; }
        public DateTime DataChegada { get; set; }
        public PortoDto POL {  get; set; }
        public PortoDto POD { get; set; }
        public CarrierModeDto CarrierMode { get; set; }

    }
}
