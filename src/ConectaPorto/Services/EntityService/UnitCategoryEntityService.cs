using ConectaPorto.Dto;
using ConectaPorto.Services.EntityService.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Services.EntityService
{
    public class UnitCategoryEntityService : EntityService<UnitCategoryDto>, IUnitCategoryEntityService
    {
        public UnitCategoryEntityService(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
