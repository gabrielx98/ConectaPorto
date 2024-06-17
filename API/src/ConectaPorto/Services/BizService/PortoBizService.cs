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
    public class PortoBizService : IPortoBizService
    {
        private readonly IPortoEntityService _portoEntityService;

        public PortoBizService(IPortoEntityService portoEntityService)
        {
            _portoEntityService = portoEntityService;
        }

        public async Task<List<Porto>> ListarPortos()
        {
            var portos = (await _portoEntityService.GetAll()).ToList().OrderBy(x => x.Id);
            var result = new List<Porto>();
            foreach(var porto in portos)
            {
                result.Add(new Porto(porto));
            }
            return result;
        }

        public async Task<Porto> BuscarPorto(int id)
        {
            var porto = await _portoEntityService.GetById(id);
            return new Porto(porto);
        }

        public async Task CadastrarPorto(Porto porto)
        {
            await _portoEntityService.Set(new PortoDto(porto));
        }

        public async Task AtualizarPorto(Porto porto)
        {
            await _portoEntityService.Update(new PortoDto(porto));
        }

        public async Task RemoverPorto(int id)
        {
            await _portoEntityService.Delete(id);
        }
    }
}
