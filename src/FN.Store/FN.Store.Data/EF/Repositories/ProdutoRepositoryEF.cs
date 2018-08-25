using FN.Store.Domain.Contracts.Repositories;
using FN.Store.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace FN.Store.Data.EF.Repositories
{
    public class ProdutoRepositoryEF : RepositoryEF<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> GetByNameContains(string contains)
        {
            return
                    //from p in _ctx.Produtos
                    //where p.Nome.Contains(contains)
                    //select p;

                    _ctx.Produtos.Where(p => p.Nome.Contains(contains));
        }
    }
}
