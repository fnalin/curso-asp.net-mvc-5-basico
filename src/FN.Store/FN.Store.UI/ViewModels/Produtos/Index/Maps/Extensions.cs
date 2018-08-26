using FN.Store.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace FN.Store.UI.ViewModels.Produtos.Index.Maps
{
    public static class Extensions
    {

        public static IEnumerable<ProdutoIndexVM> ToProdutoIndexVM(this IEnumerable<Produto> data)
        {
            return data.Select(p => new ProdutoIndexVM()
            {
                Id = p.Id,
                Nome = p.Nome,
                Preco = p.Preco,
                Tipo = p.TipoDeProduto.Nome,
                Qtde = p.Qtde,
                DataCadastro = p.DataCadastro
            });
        }
        
    }
}
