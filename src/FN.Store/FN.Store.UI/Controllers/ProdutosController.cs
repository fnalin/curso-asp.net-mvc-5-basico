using FN.Store.UI.Data;
using FN.Store.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FN.Store.UI.Controllers
{
    public class ProdutosController:Controller
    {
        public ViewResult Index()
        {

            IList<Produto> produtos = null;
            using (var ctx = new FNStoreDataContext())
            {
                produtos = ctx.Produtos.ToList();
            }

            return View(produtos);
        }

        [HttpGet]
        public ViewResult Add()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Add(Produto produto)
        {

            //todo add na tabela
            return View();
        }




    }
}
