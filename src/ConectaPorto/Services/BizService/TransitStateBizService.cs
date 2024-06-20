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
    public class TransitStateBizService : ITransitStateBizService
    {
        private readonly ITransitStateEntityService _transitStateEntityService;

        public TransitStateBizService(ITransitStateEntityService transitStateEntityService)
        {
            _transitStateEntityService = transitStateEntityService;
        }

        public async Task<List<TransitState>> ListarTransitStates()
        {
            var states = (await _transitStateEntityService.GetAll()).ToList().OrderBy(x => x.Id);
            var result = new List<TransitState>();
            foreach (var state in states)
            {
                result.Add(new TransitState(state));
            }
            return result;
        }
        public async Task<TransitState> BuscarTransitState(int id)
        {
            var state = await _transitStateEntityService.GetById(id);
            return new TransitState(state);
        }

        public async Task CadastrarTransitState(TransitState transitState)
        {
            await _transitStateEntityService.Set(new TransitStateDto(transitState));
        }
        public async Task AtualizarTransitState(TransitState transitState)
        {
            await _transitStateEntityService.Update(new TransitStateDto(transitState));
        }

        public async Task RemoverTransitState(int id)
        {
            await _transitStateEntityService.Delete(id);
        }
    }
}
