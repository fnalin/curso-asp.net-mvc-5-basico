using FN.Store.UI.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace FN.Store.UI.Data
{
    internal class DbInitializer : CreateDatabaseIfNotExists<FNStoreDataContext>
    {

        protected override void Seed(FNStoreDataContext context)
        {
            var produtos = new List<Produto>() {
                new Produto() { Nome = "Picanha", Preco = 70.5M, Qtde= 150, Tipo = "Alimento"},
                new Produto() { Nome = "Pasta de dente", Preco = 9.5M, Qtde= 250, Tipo = "Higiene"},
                new Produto() { Nome = "Desinfetante", Preco = 8.99M, Qtde= 520, Tipo = "Limpeza"},
                new Produto() { Nome = "Telefone sem fio", Preco = 125.15M, Qtde= 85, Tipo = "Eletronico"},
            };

            context.Produtos.AddRange(produtos);
            context.SaveChanges();

        }


    }
}