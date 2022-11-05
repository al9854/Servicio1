using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.Web.Mvc;
using System.Web.ModelBinding;

namespace Servicio1.Controllers
{
    public class RegistrarController : Controller
    {

        private Sistema db = new Sistema();
        // GET: Registrar
        public ActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateRegister(FormCollection fc)
        {
            if (ModelState.IsValid)
            {
                Trabajador obj = new Trabajador();
                obj.Nombres = fc["txtnombres"];
                obj.Apellidos = fc["txtapellidos"];
                obj.Celular = Convert.ToInt32(fc["txtcelular"]);
                obj.Correo = fc["txtcorreo"];
                obj.Usuario = fc["txtusuario"];
                obj.Contraseña = fc["txtcontraseña"];
                obj.Estado = "Activo";
                obj.FechaCrea = DateTime.Now.Date;
                db.Trabajador.Add(obj);
                db.SaveChanges();
                return RedirectToAction("Trabajadores", "Trabajadores"); ;
            }

            return View();
        }




    }
}