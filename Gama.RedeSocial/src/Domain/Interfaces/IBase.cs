using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Gama.RedeSocial.Domain.Interfaces 
{
    public interface IBase<T> where T : BaseEntity// utilizada tanto para serviço quanto para repositorio
    {
        IQueryable<T> Get(Expression<Func<bool, T>> predicate); 
        T Get(Guid id); // GetById
        bool Insert(T entity); // Post
        bool Update(T entity);
        bool Delete(Guid id);
    }
}
