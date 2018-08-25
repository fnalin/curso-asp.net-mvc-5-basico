using FN.Store.Domain.Entities;
using System.Collections.Generic;

namespace FN.Store.Domain.Contracts.Repositories
{
    public interface IProdutoRepository: IRepository<Produto>
    {
        IEnumerable<Produto> GetByNameContains(string contains);
    }
}
