using MinhoShine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MinhoShine.Controllers
{
    public class RequisitarController : Controller
    {

        MinhoShineContext db = new MinhoShineContext();

        // GET: Requisitar
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Requisitar([Bind(Include = "Morada, Duracao, Preco, Descricao, Dia, Mes, Ano, Hora, Minutos, Limpeza, Colchoes, Lavandaria, Engomaria, IdCliente, IdFuncionario")] Servico servico)
        {

            var referencia = randomReferencia();
            var funcionario = randomFuncionario();

            servico.Duracao = 0;
            servico.Preco = 0;
            servico.Preco += servico.Limpeza * 30 + servico.Colchoes * 20 + servico.Lavandaria * 5 + servico.Engomaria * 10;
            servico.IdCliente = (int) Session["id"];
            servico.IdFuncionario = funcionario;

            if (ModelState.IsValid) {

                db.Servicos.Add(servico);
                db.SaveChanges();
                Session["preco"] = servico.Preco;
                Session["referencia"] = referencia;
                return RedirectToAction("DadosPagamento", "Requisitar");

            }
            return RedirectToAction("Index");
        }

        public int randomReferencia()
        {
            Random r = new Random();
            int random = r.Next(111111111, 999999999);
            return random;

        }

        public int randomFuncionario()
        {
            Random r = new Random();
            int random = r.Next(1, 20);
            return random;
        }

        public ActionResult DadosPagamento()
        {
            return View();
        }

        public ActionResult Concluir()
        {
            return RedirectToAction("LoginPage","Login");
        }
    }
}