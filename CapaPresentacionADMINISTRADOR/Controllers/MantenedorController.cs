﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacionADMINISTRADOR.Controllers
{
    public class MantenedorController : Controller
    {
        // GET: Mantenedor
        public ActionResult Categorias()
        {
            return View();
        }

        public ActionResult Marca() {
        
            return View();
        
        }

       public ActionResult Producto()
        {

            return View();  
        }

    }
}