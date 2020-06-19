using MinhoShine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MinhoShine.Controllers
{
    public class RegisterController : Controller
    {

        MinhoShineContext db = new MinhoShineContext();

        // GET: Register

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register([Bind(Include = "Nome,Email,Morada,Password,Contacto")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                db.Clientes.Add(cliente);
                db.SaveChanges();
                TempData["registo"] = 1;
                return RedirectToAction("Index", "Login");
            }
            return RedirectToAction("Index");
        }
    }
}