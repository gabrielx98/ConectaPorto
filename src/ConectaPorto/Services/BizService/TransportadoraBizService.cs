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
    public class TransportadoraBizService : ITransportadoraBizService
    {
        private readonly ITransportadoraEntityService _transportadoraEntityService;

        public TransportadoraBizService(ITransportadoraEntityService transportadoraEntityService)
        {
            _transportadoraEntityService = transportadoraEntityService;
        }


        public async Task<List<Transportadora>> ListarTransportadoras()
        {
            var transportadoras = (await _transportadoraEntityService.GetAll()).ToList().OrderBy(x => x.Id);
            var result = new List<Transportadora>();
            foreach(var transportadora in transportadoras)
            {
                result.Add(new Transportadora(transportadora));
            }
            return result;
        }

        public async Task<Transportadora> BuscarTransportadora(int id)
        {
            var transportadora = await _transportadoraEntityService.GetById(id);
            return new Transportadora(transportadora);
        }

        public async Task CadastrarTransportadora(Transportadora transportadora)
        {
            await _transportadoraEntityService.Set(new TransportadoraDto(transportadora));
        }

        public async Task AtualizarTransportadora(Transportadora transportadora)
        {
            await _transportadoraEntityService.Update(new TransportadoraDto(transportadora));
        }

        public async Task RemoverTransportadora(int id)
        {
            await _transportadoraEntityService.Delete(id);
        }
    }
}
