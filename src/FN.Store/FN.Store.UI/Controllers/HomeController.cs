using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FN.Store.UI.Controllers
{
    public class HomeController:Controller
    {

        // localhost:xxxx
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Sobre()
        {
            return View();
        }

    }
}
