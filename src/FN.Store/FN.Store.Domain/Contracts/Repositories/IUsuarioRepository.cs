using FN.Store.Domain.Entities;

namespace FN.Store.Domain.Contracts.Repositories
{
    public interface IUsuarioRepository: IRepository<Usuario>
    {
        Usuario Get(string email);
    }
}
