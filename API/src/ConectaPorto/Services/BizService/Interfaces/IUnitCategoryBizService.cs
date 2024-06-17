using ConectaPorto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Services.BizService.Interfaces
{
    public interface IUnitCategoryBizService
    {
        public Task<List<UnitCategory>> ListarUnitCategorys();
        public Task<UnitCategory> BuscarUnitCategory(int id);
        public Task CadastrarUnitCategory(UnitCategory unitCategory);
        public Task AtualizarUnitCategory(UnitCategory unitCategory);
        public Task RemoverUnitCategory(int id);
    }
}
