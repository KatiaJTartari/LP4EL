using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospedagemOnline.Controllers
{
    public class EstabelecimentoController : Controller
    {
        private HospedagemBDEntities db = new HospedagemBDEntities();

        public ActionResult Index()
        {
            var estabelecimentos = db.Estabelecimento.Include("Categoria").Include("Cidade").
                Include("Quarto").Include("TipoQuarto").ToList();
            return View(estabelecimentos);
        }

        public ActionResult Inserir()
        {
            ViewBag.IdCategoria = new SelectList(db.Categoria, "IdCategoria", "Descricao");
            ViewBag.IdCidade = new SelectList(db.Cidade, "IdCidade", "Nome", "UF");
            ViewBag.IdQuarto = new SelectList(db.Quarto, "IdQuarto", "NumeroQuarto", "Disponivel");
            ViewBag.IdTipoQuarto = new SelectList(db.TipoQuarto, "IdTipoQuarto", "Descricao", "ValorDiario", "CafeManha");
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(Estabelecimento estabelecimento) 
        {
            if (ModelState.IsValid)
            {
                db.Estabelecimento.Add(estabelecimento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCategoria = new SelectList(db.Categoria, "IdCategoria", "Descricao", estabelecimento.IdCategoria);
            ViewBag.IdCidade = new SelectList(db.Cidade, "IdCidade", "Nome", "UF", estabelecimento.IdCidade);
            ViewBag.IdQuarto = new SelectList(db.Quarto, "IdQuarto", "NumeroQuarto", "Disponivel", estabelecimento.IdQuarto);
            ViewBag.IdTipoQuarto = new SelectList(db.TipoQuarto, "IdTipoQuarto", "Descricao", "ValorDiario", "CafeManha", estabelecimento.IdTipoQuarto);
            return View(estabelecimento);
        }

        public ActionResult Alterar(int id)
        {
            Estabelecimento estabelecimento = db.Estabelecimento.Find(id);                  
            ViewBag.IdCategoria = new SelectList(db.Categoria, "IdCategoria", "Descricao", estabelecimento.IdCategoria);
            ViewBag.IdCidade = new SelectList(db.Cidade, "IdCidade", "Nome", "UF", estabelecimento.IdCidade);
            ViewBag.IdQuarto = new SelectList(db.Quarto, "IdQuarto", "NumeroQuarto", "Disponivel", estabelecimento.IdQuarto);
            ViewBag.IdTipoQuarto = new SelectList(db.TipoQuarto, "IdTipoQuarto", "Descricao", "ValorDiario", "CafeManha", estabelecimento.IdTipoQuarto);
            return View(estabelecimento);
        }

        [HttpPost]
        public ActionResult Alterar(Estabelecimento estabelecimento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estabelecimento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCategoria = new SelectList(db.Categoria, "IdCategoria", "Descricao", estabelecimento.IdCategoria);
            ViewBag.IdCidade = new SelectList(db.Cidade, "IdCidade", "Nome", "UF", estabelecimento.IdCidade);
            ViewBag.IdQuarto = new SelectList(db.Quarto, "IdQuarto", "NumeroQuarto", "Disponivel", estabelecimento.IdQuarto);
            ViewBag.IdTipoQuarto = new SelectList(db.TipoQuarto, "IdTipoQuarto", "Descricao", "ValorDiario", "CafeManha", estabelecimento.IdTipoQuarto);
            return View(estabelecimento);
        }

        public ActionResult Excluir(int id)
        {
            Estabelecimento estabelecimento = db.Estabelecimento.Find(id);
            ViewBag.IdCategoria = new SelectList(db.Categoria, "IdCategoria", "Descricao", estabelecimento.IdCategoria);
            ViewBag.IdCidade = new SelectList(db.Cidade, "IdCidade", "Nome", "UF", estabelecimento.IdCidade);
            ViewBag.IdQuarto = new SelectList(db.Quarto, "IdQuarto", "NumeroQuarto", "Disponivel", estabelecimento.IdQuarto);
            ViewBag.IdTipoQuarto = new SelectList(db.TipoQuarto, "IdTipoQuarto", "Descricao", "ValorDiario", "CafeManha", estabelecimento.IdTipoQuarto);
            return View(estabelecimento);
        }

        [HttpPost, ActionName("Excluir")]
        public ActionResult EfetuarExclusao(int id)
        {
            try
            {
                Estabelecimento estabelecimento = db.Estabelecimento.Find(id);
                db.Estabelecimento.Remove(estabelecimento);
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
    }
}