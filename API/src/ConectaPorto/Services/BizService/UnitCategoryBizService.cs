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
    public class UnitCategoryBizService : IUnitCategoryBizService
    {
        private readonly IUnitCategoryEntityService _unitCategoryEntityService;

        public UnitCategoryBizService(IUnitCategoryEntityService unitCategoryEntityService)
        {
            _unitCategoryEntityService = unitCategoryEntityService;
        }

        public async Task<List<UnitCategory>> ListarUnitCategorys()
        {
            var units = (await _unitCategoryEntityService.GetAll()).ToList().OrderBy(x => x.Id);
            var result = new List<UnitCategory>();
            foreach (var unit in units)
            {
                result.Add(new UnitCategory(unit));
            }
            return result;
        }

        public async Task<UnitCategory> BuscarUnitCategory(int id)
        {
            var unit = await _unitCategoryEntityService.GetById(id);
            return new UnitCategory(unit);
        }

        public async Task CadastrarUnitCategory(UnitCategory unit)
        {
            await _unitCategoryEntityService.Set(new UnitCategoryDto(unit));
        }

        public async Task AtualizarUnitCategory(UnitCategory unit)
        {
            await _unitCategoryEntityService.Update(new UnitCategoryDto(unit));
        }

        public async Task RemoverUnitCategory(int id)
        {
            await _unitCategoryEntityService.Delete(id);
        }
    }
}
