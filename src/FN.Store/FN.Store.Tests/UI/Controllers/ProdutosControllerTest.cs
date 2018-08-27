using FN.Store.Domain.Contracts.Repositories;
using FN.Store.Domain.Entities;
using FN.Store.UI.Controllers;
using FN.Store.UI.ViewModels.Produtos.Index;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FN.Store.Tests.UI.Controllers
{
    [TestClass, TestCategory("Controller/ProdutosController")]
    public class ProdutosControllerTest
    {

        //dado um ProdutosController

        [TestMethod]
        public void MetodoIndexDevaraRetornarAViewComOModeloCorreto()
        {
            //arrange
            var produtosController = 
                new ProdutosController(new ProdutoRepositoryFake(), new TipoDeProdutoRepositoryFake());

            //act
            var result = produtosController.Index();
            var model = result.Model as IEnumerable<ProdutoIndexVM>;

            //assert
            Assert.AreEqual(typeof(ViewResult), result.GetType());
            Assert.AreEqual(3, model.Count());
            Assert.IsNotNull(model);
        }


    }

    public class ProdutoRepositoryFake : IProdutoRepository
    {
        public void Add(Produto entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Produto entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Edit(Produto entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produto> Get()
        {
            var tipo1 = new TipoDeProduto() { Id = 1, Nome = "Tipo 1" };
            var tipo2 = new TipoDeProduto() { Id = 2, Nome = "Tipo 2" };
            return new List<Produto>() {
                new Produto(){ Id= 1, Nome = "Produto 1", Preco = 1, Qtde = 10, TipoDeProdutoId = tipo1.Id, TipoDeProduto = tipo1  },
                new Produto(){ Id= 2, Nome = "Produto 2", Preco = 2, Qtde = 20, TipoDeProdutoId = tipo2.Id, TipoDeProduto = tipo2  },
                new Produto(){ Id= 3, Nome = "Produto 3", Preco = 3, Qtde = 30, TipoDeProdutoId = tipo1.Id, TipoDeProduto = tipo1  },
            };
        }

        public Produto Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produto> GetByNameContains(string contains)
        {
            throw new NotImplementedException();
        }
    }
    public class TipoDeProdutoRepositoryFake : ITipoDeProdutoRepository
    {
        public void Add(TipoDeProduto entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TipoDeProduto entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Edit(TipoDeProduto entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TipoDeProduto> Get()
        {
            throw new NotImplementedException();
        }

        public TipoDeProduto Get(int id)
        {
            throw new NotImplementedException();
        }
    }

}
