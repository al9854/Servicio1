using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Servicio1.Controllers
{
    public class TrabajadoresController : Controller
    {
        private Sistema db = new Sistema();
        // GET: Trabajadores
        public ActionResult Trabajadores()
        {
            return View(db.Trabajador.ToList());
        }
        // Para listar solo debo ejecutar el comando TOList que se organizara en la vista

    }
}