using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using capaEntidad;
using capaNegocio;

namespace CapaPresentacionADMINISTRADOR.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Usuarios() {
            return View();
        }

        [HttpGet]

        public JsonResult ListarUsuarios()
        {
            List<Usuario> Olistar = new List<Usuario>();

            Olistar = new CN_Usuarios().listar();

            return Json(new { data = Olistar},JsonRequestBehavior.AllowGet);
        }
    }
}