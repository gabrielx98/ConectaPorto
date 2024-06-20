using ConectaPorto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Services.BizService.Interfaces
{
    public interface ICarrierBizService
    {
        public Task<List<Carrier>> ListarCarriers();
        public Task<Carrier> BuscarCarrier(int id);
        public Task CadastrarCarrier(Carrier carrier);
        public Task AtualizarCarrier(Carrier carrier);
        public Task RemoverCarrier(int id);
    }
}
