using FN.Store.Data.EF;
using FN.Store.Domain.Entities;
using System.Linq;
using System.Web.Mvc;

namespace FN.Store.UI.Controllers
{

    [Authorize]
    public class ProdutosController : Controller
    {
        private readonly FNStoreDataContext _ctx = new FNStoreDataContext();


        public ViewResult Index()
        {
            var produtos = _ctx.Produtos.ToList();
            return View(produtos);
        }

        [HttpGet]
        public ViewResult AddEdit(int? id)
        {
            var produto = new Produto();

            if (id != null)
            {
                produto = _ctx.Produtos.Find(id);
            }

            var tipos = _ctx.TipoDeProdutos.ToList();
            ViewBag.Tipos = tipos;
            return View(produto);
        }


        [HttpPost]
        public ActionResult AddEdit(Produto produto)
        {
            if (ModelState.IsValid)
            {
                if (produto.Id == 0)
                {
                    _ctx.Produtos.Add(produto);
                }
                else
                {
                    _ctx.Entry(produto).State = System.Data.Entity.EntityState.Modified;
                }
                _ctx.SaveChanges();

                return RedirectToAction("Index");
            }

            var tipos = _ctx.TipoDeProdutos.ToList();
            ViewBag.Tipos = tipos;

            return View(produto);
        }


        public ActionResult DelProd(int id)
        {

            var produto = _ctx.Produtos.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }

            _ctx.Produtos.Remove(produto);
            _ctx.SaveChanges();

            return null;
        }


        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
        }




    }
}
