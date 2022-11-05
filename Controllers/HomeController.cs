using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Servicio1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Principal()
        {
            return View();
        }

        //public ActionResult ValidarUsuario(string usuario, string contraseña)
        //{
        //    Trabajador obj=new Trabajador();
        //    if()
        //    obj.Usuario = usuario;
        //    return RedirectToAction("Principal", "Home"); ;
        //}
    }
}