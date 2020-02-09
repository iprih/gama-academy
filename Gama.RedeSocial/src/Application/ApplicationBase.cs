using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Applications;
using Gama.RedeSocial.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Application
{
    public class ApplicationBase<T> : IApplicationBase<T> where T : BaseEntity
    {
        private readonly IServiceBase<T> _service;
        public ApplicationBase(IServiceBase<T> service)
        {
            _service = service;
        }
        public bool Delete(Guid id)
        {
            return _service.Delete(id);
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return _service.Get(predicate);
        }

        public T Get(Guid id)
        {
            return _service.Get(id);

        }

        public Guid Insert(T entity)
        {
            return _service.Insert(entity);
        }

        public bool Update(T entity)
        {
            return _service.Update(entity);
        }
    }
}
