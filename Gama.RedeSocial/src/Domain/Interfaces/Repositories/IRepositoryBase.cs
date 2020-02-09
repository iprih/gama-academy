using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gama.RedeSocial.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<T> : IBase<T> where T : BaseEntity
    {
        void Execute(string sql, object parameters);
        IEnumerable<T> Execute<T>(string sql, object parameters);
    }
}
