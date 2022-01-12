using HospedagemOnline.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace HospedagemOnline.Controllers
{
    [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
    public class QuartoController : Controller
    {
        private HospedagemBDEntities db = new HospedagemBDEntities();
        public ActionResult Index()
        {           
            var quartos = db.Quarto.Include("Estabelecimento").Include("TipoQuarto").ToList();
            return View(quartos);
        }

        public ActionResult Inserir()
        {
            ViewBag.IdEstabelecimento = new SelectList(db.Estabelecimento, "IdEstabelecimento", "Nomecomercial", "RazaoSocial",
                                                      "CNPJ", "Endereco", "Telefone", "Site");
            ViewBag.IdTipoQuarto = new SelectList(db.TipoQuarto, "IdTipoQuarto", "Descricao", "ValorDiaria",
                                                  "CafeManha");
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(Quarto quarto)
        {
            if (ModelState.IsValid)
            {
                db.Quarto.Add(quarto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdEstabelecimento = new SelectList(db.Estabelecimento, "IdEstabelecimento", "Nomecomercial", "RazaoSocial",
                                                       "CNPJ", "Endereco", "Telefone", "Site", quarto.IdEstabelecimento);
            ViewBag.IdTipoQuarto = new SelectList(db.TipoQuarto, "IdTipoQuarto", "Descricao", "ValorDiaria",
                                                  "CafeManha", quarto.IdTipoQuarto);
            return View(quarto);
        }

        public ActionResult Alterar(int id)
        {
            Quarto quarto = db.Quarto.Find(id);
            ViewBag.IdEstabelecimento = new SelectList(db.Estabelecimento, "IdEstabelecimento", "Nomecomercial", "RazaoSocial",
                                                       "CNPJ", "Endereco", "Telefone", "Site", quarto.IdEstabelecimento);
            ViewBag.IdTipoQuarto = new SelectList(db.TipoQuarto, "IdTipoQuarto", "Descricao", "ValorDiaria",
                                                  "CafeManha", quarto.IdTipoQuarto);
            return View(quarto);
        }

        [HttpPost]
        public ActionResult Alterar(Quarto quarto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quarto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdEstabelecimento = new SelectList(db.Estabelecimento, "IdEstabelecimento", "Nomecomercial", "RazaoSocial",
                                                      "CNPJ", "Endereco", "Telefone", "Site", quarto.IdEstabelecimento);
            ViewBag.IdTipoQuarto = new SelectList(db.TipoQuarto, "IdTipoQuarto", "Descricao", "ValorDiaria",
                                                 "CafeManha", quarto.IdTipoQuarto);
            return View(quarto);
        }

        public ActionResult Excluir(int id)
        {
            Quarto quarto = db.Quarto.Find(id);
            ViewBag.IdEstabelecimento = new SelectList(db.Estabelecimento, "IdEstabelecimento", "Nomecomercial", "RazaoSocial",
                                                       "CNPJ", "Endereco", "Telefone", "Site", quarto.IdEstabelecimento);
            ViewBag.IdTipoQuarto = new SelectList(db.TipoQuarto, "IdTipoQuarto", "Descricao", "ValorDiaria",
                                                 "CafeManha", quarto.IdTipoQuarto);
            return View(quarto);
        }

        [HttpPost, ActionName("Excluir")]
        public ActionResult EfetuarExclusao(int id)
        {
            try
            {
                Quarto quarto = db.Quarto.Find(id);
                db.Categoria.Remove(quarto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("ErroExcluir");
            }
        }

        public ActionResult ErroExcluir()
        {
            return View();
        }

        public ActionResult VerificaSeNumeroQuartoNaoExiste(int idEstabelecimento, int numeroQuarto)
        {
            var quarto = db.Quarto.Where(q => q.NumeroQuarto == numeroQuarto).FirstOrDefault();

            if (quarto != null)
                return Json(false, JsonRequestBehavior.AllowGet); // O número do quarto já existe.
            else
                return Json(true, JsonRequestBehavior.AllowGet); // O número do quarto não existe.
        }
    }
}