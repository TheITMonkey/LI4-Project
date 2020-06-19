using MinhoShine.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MinhoShine.Controllers
{
    public class ModificarController : Controller
    {

        MinhoShineContext db = new MinhoShineContext();

        // GET: Modificar
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Modificar([Bind(Include = "Nome,Email,Morada,Password,Contacto")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                Cliente currentCliente = db.Clientes.Find(Session["id"]);

                currentCliente.Nome = cliente.Nome; Session["username"] = cliente.Nome;
                currentCliente.Email = cliente.Email; Session["email"] = cliente.Email;
                currentCliente.Morada = cliente.Morada; Session["morada"] = cliente.Morada;
                currentCliente.Password = cliente.Password; Session["password"] = cliente.Password;
                currentCliente.Contacto = cliente.Contacto; Session["contacto"] = cliente.Contacto;

                db.SaveChanges();
                return RedirectToAction("LoginPage","Login");
            }
            return RedirectToAction("Index");
        }
    }
}