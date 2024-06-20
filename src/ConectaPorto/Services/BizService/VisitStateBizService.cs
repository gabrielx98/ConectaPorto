using ConectaPorto.Dto;
using ConectaPorto.Models;
using ConectaPorto.Services.BizService.Interfaces;
using ConectaPorto.Services.EntityService;
using ConectaPorto.Services.EntityService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Services.BizService
{
    public class VisitStateBizService : IVisitStateBizService
    {
        private readonly IVisitStateEntityService _visitStateEntityService;

        public VisitStateBizService(IVisitStateEntityService visitStateEntityService)
        {
            _visitStateEntityService = visitStateEntityService;
        }

        public async Task<List<VisitState>> ListarVisitStates()
        {
            var visitStates = (await _visitStateEntityService.GetAll()).ToList().OrderBy(x => x.Id);
            var result = new List<VisitState>();
            foreach (var visitState in visitStates)
            {
                result.Add(new VisitState(visitState));
            }
            return result;
        }

        public async Task<VisitState> BuscarVisitState(int id)
        {
            var visitState = await _visitStateEntityService.GetById(id);
            return new VisitState(visitState);
        }

        public async Task CadastrarVisitState(VisitState visitState)
        {
            await _visitStateEntityService.Set(new VisitStateDto(visitState));
        }
        public async Task AtualizarVisitState(VisitState visitState)
        {
            await _visitStateEntityService.Update(new VisitStateDto(visitState));
        }

        public async Task RemoverVisitState(int id)
        {
            await _visitStateEntityService.Delete(id);
        }
    }
}
