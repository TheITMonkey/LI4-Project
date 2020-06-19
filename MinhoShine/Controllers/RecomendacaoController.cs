using MinhoShine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MinhoShine.Controllers
{
    public class RecomendacaoController : Controller
    {

        MinhoShineContext db = new MinhoShineContext();

        // GET: Classificacao
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Recomendacao([Bind(Include = "Email,Mensagem,IdCliente")] Recomendacao recomendacao)
        {

            recomendacao.IdCliente = (int)Session["id"];

            if (ModelState.IsValid)
            {
                db.Recomendacoes.Add(recomendacao);
                db.SaveChanges();
                return RedirectToAction("LoginPage", "Login");
            }

            return View("Index");
        }
    }
}