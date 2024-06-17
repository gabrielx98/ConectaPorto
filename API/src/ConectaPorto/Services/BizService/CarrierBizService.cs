using ConectaPorto.Dto;
using ConectaPorto.Models;
using ConectaPorto.Services.BizService.Interfaces;
using ConectaPorto.Services.EntityService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Services.BizService
{
    public class CarrierBizService : ICarrierBizService
    {
        private readonly ICarrierEntityService _carrierEntityService;

        public CarrierBizService(ICarrierEntityService carrierEntityService)
        {
            _carrierEntityService = carrierEntityService;
        }

        public async Task<List<Carrier>> ListarCarriers() { 
            var carriers = (await _carrierEntityService.GetAll()).ToList().OrderBy(x => x.Id);
            var result = new List<Carrier>();
            foreach (var carrier in carriers)
            {
                result.Add(new Carrier(carrier));
            }
            return result;
        }

        public async Task<Carrier> BuscarCarrier(int id)
        {
            var carrier = await _carrierEntityService.GetById(id);
            return new Carrier(carrier);
            
        }

        public async Task CadastrarCarrier(Carrier carrier)
        {
            await _carrierEntityService.Set(new CarrierDto(carrier));
        }

        public async Task AtualizarCarrier(Carrier carrier)
        {
            await _carrierEntityService.Update(new CarrierDto(carrier));
        }

        public async Task RemoverCarrier(int id)
        {
            await _carrierEntityService.Delete(id);
        }

    }
}
