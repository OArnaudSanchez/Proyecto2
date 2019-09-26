using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyectoo2.Models;

namespace Proyectoo2.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }
		public ActionResult Opciones()
		{
			return View();
		}
		public ActionResult Inicio()
		{
			return View();
		}
		public ActionResult Nosotros()
		{
			return View();
		}
		public ActionResult Servicios()
		{
			return View();
		}
		public ActionResult Contacto()
		{
			return View();
		}
		public ActionResult DatosFormulario()
		{
			Datos data = new Datos();
			data.nombre = Request.Form["nombre"];
			data.apellido = Request.Form["apellido"];
			data.email = Request.Form["correo"];
			return View(data);
		}
	}
}