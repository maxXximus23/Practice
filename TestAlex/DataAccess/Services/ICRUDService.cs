using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestAlex.DataAccess.Services
{
    public interface ICRUDService <TEntity>
        where TEntity : class
    {
        public Task Create(TEntity entity);
        public Task<IEnumerable<TEntity>> GetAll();
        public Task<TEntity> Get(int id);
        public Task Delete(int id);
        public Task Update(TEntity entity);
    }
}
