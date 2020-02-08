using Dommel;
using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : BaseEntity
    {
        public bool Delete(Guid id)
        {
            using (var cn = SqlConnectionFactory.Create())
            {
                return cn.Delete(id);
            }           
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            using (var cn = SqlConnectionFactory.Create())
            {
                return cn.Select(predicate);
            }
        }

        public T Get(Guid id)
        {
            using (var cn = SqlConnectionFactory.Create())
            {
                return cn.Get<T>(id);
            }
        }

        public Guid Insert(T entity)
        {
            using (var cn = SqlConnectionFactory.Create())
            {
               cn.Insert(entity);

                return entity.Id;
            }
        }

        public bool Update(T entity)
        {
            using (var cn = SqlConnectionFactory.Create())
            {
                return cn.Update(entity);
            }
        }
    }
}
