using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_API.Models.Sevices
{
    public interface IDBService <TEntity, in TPk> where TEntity : class
    {
        IEnumerable<TEntity> Get();
        TEntity Get(TPk id);
        TEntity Create(TEntity entity);
        TEntity Update(TPk id, TEntity entity);
        TEntity Delete(TPk id);
    }
}
