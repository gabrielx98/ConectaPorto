﻿using ConectaPorto.Dto;
using ConectaPorto.Services.EntityService.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Services.EntityService
{
    public class CarrierEntityService : EntityService<CarrierDto>, ICarrierEntityService
    {
        public CarrierEntityService(DbContext dbContext) : base(dbContext) { }
    }
}