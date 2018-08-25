using FN.Store.Domain.Contracts.Repositories;
using FN.Store.Domain.Entities;
using System.Linq;

namespace FN.Store.Data.EF.Repositories
{
    public class UsuarioRepositoryEF : RepositoryEF<Usuario>, IUsuarioRepository
    {
        public Usuario Get(string email)
        {
            return _ctx.Usuarios.FirstOrDefault(u=> u.Email.ToLower() == email.ToLower());
        }
    }
}
