using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepositoryBase<TEntity, TEntityId>
    {
        public IList<TEntity> GetList(Func<TEntity, bool>? predicate = null);
        public TEntity? Get(Func<TEntity, bool> predicate);
        public TEntity Add(TEntity entity);
        public TEntity Update(TEntity entity);
        public TEntity Delete(TEntity entity, bool isSoftDelete = true);
    }
}
