using MinhoShine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MinhoShine.Controllers
{
    public class LoginController : Controller
    {
        MinhoShineContext db = new MinhoShineContext();
        
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            var username = "";
            var id = 1;
            var morada = "";
            var contacto = "";

            var clientes = (from m in db.Clientes
                            where m.Email == email && m.Password == password
                            select m);

            foreach (var item in clientes)
            {
                id = item.IdCliente;
                username = item.Nome;
                morada = item.Morada;
                contacto = item.Contacto;

            }

            if (ModelState.IsValid)
            {
                if (clientes.ToList<Cliente>().Count > 0)
                {
                    Cliente cliente = clientes.ToList<Cliente>().ElementAt(0);
                }
                else
                {
                    ViewData["failed"] = 1;
                    return View("Index");
                }
            }
            ViewData["login"] = 1;
            Session["id"] = id;
            Session["username"] = username;
            Session["email"] = email;
            Session["morada"] = morada;
            Session["password"] = password;
            Session["contacto"] = contacto;
            return View("LoginPage");
        }

        public ActionResult Logout()
        {
            //FormsAuthentication.SignOut();
            Session.Clear();
            return RedirectToAction("Index", "Login");
        }

        public ActionResult LoginPage()
        {
            return View();
        }
    }
}