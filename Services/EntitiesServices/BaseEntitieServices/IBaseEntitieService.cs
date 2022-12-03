using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.EntitiesServices.BaseEntitieServices
{
    public  interface IBaseEntitieService<TEntity>
    {
        ValueTask<List<TEntity>> GetAllAsync();
        ValueTask<TEntity> GetByIdAsync(int Id);
        ValueTask<int> InsertAsync(TEntity entity);
        ValueTask<int> UpdateAsync(TEntity entity);
        ValueTask<int> DeleteByIdAsync(int id);
        ValueTask<TEntity> GetByNameAsync(string name);
    }
}
