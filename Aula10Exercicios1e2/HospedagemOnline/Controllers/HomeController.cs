using HospedagemOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospedagemOnline.Controllers
{
    public class HomeController : Controller
    {
        private HospedagemBDEntities db = new HospedagemBDEntities();
        public ActionResult Index()
        {
            ViewBag.Categoria = new SelectList(db.Categoria, "IdCategoria", "Descricao");
            ViewBag.Cidade = new SelectList(db.Cidade, "IdCidade", "Nome", "UF");

            return View();
        }

        public ActionResult Pesquisar(Pesquisa pesquisa)
        {
            var estabelecimentos = from e in db.Estabelecimento
                                   where e.IdCidade == pesquisa.IdCidade && e.IdCategoria == pesquisa.IdCategoria
                                   select new ResultadoPesquisa
                                   {
                                       NomeComercial = e.NomeComercial,
                                       RazaoSocial = e.RazaoSocial,
                                       CNPJ = e.CNPJ,
                                       Endereco = e.Endereco,
                                       Telefone = e.Telefone,
                                       Site = e.Site
                                   };
            return Json(estabelecimentos, JsonRequestBehavior.AllowGet);
        }
    }
}