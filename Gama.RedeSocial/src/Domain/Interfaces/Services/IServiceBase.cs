using Gama.RedeSocial.Domain.Entities;


namespace Gama.RedeSocial.Domain.Interfaces.Services
{
    public interface IServiceBase<T> : IBase<T> where T : BaseEntity
    {
    }
}
