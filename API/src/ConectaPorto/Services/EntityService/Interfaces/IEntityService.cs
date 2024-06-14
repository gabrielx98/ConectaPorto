using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Services.EntityService.Interfaces
{
    public interface IEntityService<TEntity>
    {
        public Task<IEnumerable<TEntity>> GetAll();
        public Task<TEntity> GetById(object id);
        public Task<String> Set(TEntity entity);
        public Task Update(TEntity entity);
        public Task Delete(object id);
    }
}
