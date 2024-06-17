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
    public class CarrierModeEntityService : EntityService<CarrierModeDto>, ICarrierModeEntityService
    {
        public CarrierModeEntityService(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
