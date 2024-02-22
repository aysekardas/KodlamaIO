using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public class EntityRepositoryBasee<TEntity, TEntityId, TContext> : IEntityRepositoryBase<TEntity, TEntityId>
         where TEntity : Entity<TEntityId>, new() where TContext :DbContext
    {
        public TEntity Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Delete(TEntity entity, bool isSoftDelete = true)
        {
            throw new NotImplementedException();
        }

        public TEntity? Get(Func<TEntity, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> GetList(Func<TEntity, bool>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
