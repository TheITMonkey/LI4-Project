
using MinhoShine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MinhoShine.Controllers
{
    public class HistoricoController : Controller
    {

        MinhoShineContext db = new MinhoShineContext();

        // GET: Historico
        public ActionResult Index()
        {

            List<Servico> servico = new List<Servico>();

            Cliente currentCliente = db.Clientes.Find(Session["id"]);

            var historico = (from hist in db.Servicos
                             where hist.IdCliente == currentCliente.IdCliente
                             select hist);

            
            foreach(var h in historico)
            {
                servico.Add(h);
            }
            
            return View(servico);
        }
    }
}