using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using Gama.RedeSocial.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace Gama.RedeSocial.Domain.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : BaseEntity
    {
        private readonly IRepositoryBase<T> _repository;
        public ServiceBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }
        public bool Delete(Guid id)
        {
            if (id == new Guid()) throw new ArgumentNullException("O Id deve ser preenchido");
            return _repository.Delete(id);

        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return _repository.Get(predicate);
        }

        public T Get(Guid id)
        {
            return _repository.Get(id);
        }

        public Guid Insert(T entity)
        {
            entity.Validate();
            return _repository.Insert(entity);
        }

        public bool Update(T entity)
        {
            return _repository.Update(entity);
        }
    }
}
