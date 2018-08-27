using FN.Store.Domain.Contracts.Repositories;
using FN.Store.UI.Infra.Helpers;
using FN.Store.UI.ViewModels.Conta.Login;
using System.Web.Mvc;
using System.Web.Security;

namespace FN.Store.UI.Controllers
{
    public class ContaController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public ContaController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }


        [HttpGet]
        public ActionResult Login(string returnURL)
        {
            var model = new LoginVM() { ReturnURL = returnURL };
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginVM model)
        {
            var usuario = _usuarioRepository.Get(model.Email);

            if (usuario == null)
                ModelState.AddModelError("Email", "O e-mail não localizado");
            else
            {
                if (usuario.Senha != model.Senha.Encrypt())
                    ModelState.AddModelError("Senha", "Senha inválida");
            }


            if (ModelState.IsValid)
            {
                FormsAuthentication.SetAuthCookie(model.Email, model.PermanecerLogado);

                if (!string.IsNullOrEmpty(model.ReturnURL) && Url.IsLocalUrl(model.ReturnURL))
                {
                    return Redirect(model.ReturnURL);
                }

                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        protected override void Dispose(bool disposing)
        {
            _usuarioRepository.Dispose();
        }

    }
}
