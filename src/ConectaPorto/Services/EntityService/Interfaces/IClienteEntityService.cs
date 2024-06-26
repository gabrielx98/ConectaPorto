﻿using ConectaPorto.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Services.EntityService.Interfaces
{
    public interface IClienteEntityService : IEntityService<ClienteDto>
    {
        public Task<IEnumerable<ClienteDto>> GetByCNPJ(int cnpj);
    }
}
