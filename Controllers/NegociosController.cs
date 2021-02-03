using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lucky.Controllers;
using Lucky.ServiceReference1;

namespace Lucky.Controllers
{
    public class NegociosController : Controller
    {
        ServicioNegociosClient proxy = new ServicioNegociosClient();

       
        // GET: Negocios
        public ActionResult Producto()
        {
            return View(proxy.Listaproductos());
        }

        public ActionResult Create() {
            return View(new Producto());
        }

        [HttpPost]

        public ActionResult Create(Producto reg) {
            string msg = proxy.AgregarProductos(reg);
            ViewBag.msg = msg;
            return RedirectToAction("Producto");
        }



        public ActionResult Edit() {
            return View(new Producto());
        }

        [HttpPost]

        public ActionResult Edit(Producto reg) {
            string msg = proxy.ActualizarProducto(reg);
            ViewBag.msg = msg;
            return RedirectToAction("Producto");
        }

        public ActionResult Details(string id)
        {
            return View(proxy.DetalleProducto(id));
        }

        public ActionResult Delete(string id)
        {
            string msg = proxy.EliminarProducto(id);
            ViewBag.msg = msg;
            return RedirectToAction("Producto");
        }

    }
}