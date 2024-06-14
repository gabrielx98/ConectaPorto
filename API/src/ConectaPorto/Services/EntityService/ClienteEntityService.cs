using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ConectaPorto.Dto;
using ConectaPorto.Services.EntityService.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ConectaPorto.Services.EntityService
{
    public class ClienteEntityService : EntityService<ClienteDto>, IClienteEntityService
    {
        public ClienteEntityService(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
