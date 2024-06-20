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
    public class FreightKindBizService : IFreightKindBizService
    {
        private readonly IFreightKindEntityService _freightKindEntityService;

        public FreightKindBizService(IFreightKindEntityService freightKindEntityService)
        {
            _freightKindEntityService = freightKindEntityService;
        }

        public async Task<List<FreightKind>> ListarFreightKinds()
        {
            var freightKinds = (await _freightKindEntityService.GetAll()).ToList().OrderBy(x => x.Id);
            var result = new List<FreightKind>();
            foreach (var freightKind in freightKinds)
            {
                result.Add(new FreightKind(freightKind));
            }
            return result;
        }

        public async Task<FreightKind> BuscarFreightKind(int id)
        {
            var freightKind = await _freightKindEntityService.GetById(id);
            return new FreightKind(freightKind);
        }

        public async Task CadastrarFreightKind(FreightKind freightKind)
        {
            await _freightKindEntityService.Set(new FreightKindDto(freightKind));
        }

        public async Task AtualizarFreightKind(FreightKind freightKind)
        {
            await _freightKindEntityService.Update(new FreightKindDto(freightKind));
        }

        public async Task RemoverFreightKind(int id)
        {
            await _freightKindEntityService.Delete(id);
        }
    }
}
