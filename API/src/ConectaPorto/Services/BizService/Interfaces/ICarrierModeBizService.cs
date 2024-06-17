using ConectaPorto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Services.BizService.Interfaces
{
    public interface ICarrierModeBizService
    {
        public Task<List<CarrierMode>> ListarCarrierModes();
        public Task<CarrierMode> BuscarCarrierMode(int id);
        public Task CadastrarCarrierMode(CarrierMode carrierMode);
        public Task AtualizarCarrierMode(CarrierMode carrierMode);
        public Task RemoverCarrierMode(int id);
    }
}
