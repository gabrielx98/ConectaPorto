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
    public class UnitBizService : IUnitBizService
    {
        private readonly IUnitEntityService _unitEntityService;

        public UnitBizService(IUnitEntityService unitEntityService)
        {
            _unitEntityService = unitEntityService;
        }

        public async Task<List<Unit>> ListarUnits()
        {
            var units = (await _unitEntityService.GetAll()).ToList().OrderBy(x => x.Id);
            var result = new List<Unit>();
            foreach (var unit in units)
            {
                result.Add(new Unit(unit));
            }
            return result;
        }

        public async Task<Unit> BuscarUnit(int id)
        {
            var unit = await _unitEntityService.GetById(id);
            return new Unit(unit);
        }

        public async Task CadastrarUnit(Unit unit)
        {
            await _unitEntityService.Set(new UnitDto(unit));
        }
        public async Task AtualizarUnit(Unit unit)
        {
            await _unitEntityService.Update(new UnitDto(unit));
        }

        public async Task RemoverUnit(int id)
        {
            await _unitEntityService.Delete(id);
        }
    }
}
