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
    public class IsoBizService : IIsoBizService
    {
        private readonly IIsoEntityService _isoEntityService;

        public IsoBizService(IIsoEntityService isoEntityService)
        {
            _isoEntityService = isoEntityService;
        }
        public async Task<List<Iso>> ListarIsos()
        {
            var Isos = (await _isoEntityService.GetAll()).ToList().OrderBy(x => x.Id);
            var result = new List<Iso>();
            foreach (var iso in Isos)
            {
                result.Add(new Iso(iso));
            }
            return result;
        }

        public async Task<Iso> BuscarIso(int id)
        {
            var iso = await _isoEntityService.GetById(id);
            return new Iso(iso);
        }

        public async Task CadastrarIso(Iso iso)
        {
            await _isoEntityService.Set(new IsoDto(iso));
        }

        public async Task AtualizarIso(Iso iso)
        {
            await _isoEntityService.Update(new IsoDto(iso));
        }

        public async Task RemoverIso(int id)
        {
            await _isoEntityService.Delete(id);
        }
    }
}
