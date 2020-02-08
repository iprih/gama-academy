using Gama.RedeSocial.Domain.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;


namespace Gama.RedeSocial.Domain.Interfaces 
{
    public interface IBase<T> where T : BaseEntity// utilizada tanto para serviço quanto para repositorio
    {
        IQueryable<T> Get(Expression<Func<T, bool>> predicate); 
        T Get(Guid id); // GetById
        Guid Insert(T entity); // Post
        bool Update(T entity);
        bool Delete(Guid id);
    }
}
