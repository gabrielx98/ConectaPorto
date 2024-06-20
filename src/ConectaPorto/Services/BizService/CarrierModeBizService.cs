using ConectaPorto.Dto;
using ConectaPorto.Models;
using ConectaPorto.Services.BizService.Interfaces;
using ConectaPorto.Services.EntityService;
using ConectaPorto.Services.EntityService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConectaPorto.Services.BizService
{
    public class CarrierModeBizService : ICarrierModeBizService
    {
        private readonly ICarrierModeEntityService _carrierModeEntityService;

        public CarrierModeBizService(ICarrierModeEntityService carrierModeEntityService)
        {
            _carrierModeEntityService = carrierModeEntityService;
        }

        public async Task<List<CarrierMode>> ListarCarrierModes()
        {
            var carrierModes = (await _carrierModeEntityService.GetAll()).ToList().OrderBy(x => x.Id);
            var result = new List<CarrierMode>();
            foreach (var carrierMode in carrierModes)
            {
                result.Add(new CarrierMode(carrierMode));
            }
            return result;
        }

        public async Task<CarrierMode> BuscarCarrierMode(int id)
        {
            var carrierMode = await _carrierModeEntityService.GetById(id);
            return new CarrierMode(carrierMode);
        }

        public async Task CadastrarCarrierMode(CarrierMode carrierMode)
        {
            await _carrierModeEntityService.Set(new CarrierModeDto(carrierMode));
        }

        public async Task AtualizarCarrierMode(CarrierMode carrierMode)
        {
            await _carrierModeEntityService.Update(new CarrierModeDto(carrierMode));
        }

        public async Task RemoverCarrierMode(int id)
        {
            await _carrierModeEntityService.Delete(id);
        }
    }
}
