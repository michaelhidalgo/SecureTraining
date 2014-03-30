using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace insecureReferences.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Voto (string cedula)
        {
            if (String.IsNullOrEmpty(User.Identity.Name))
            {
                throw new Exception("Acceso denegado...");
            }
            var context = new directobjectEntities();
            var data = context.votoes.FirstOrDefault(x => x.Cedula == cedula);
            return Json(new
                            {
                                name = data.Nombre,
                                apellidos = data.Apellidos,
                                edad = data.Edad,
                                vota = data.Vota
                            }, JsonRequestBehavior.AllowGet);
        }
    }
}
