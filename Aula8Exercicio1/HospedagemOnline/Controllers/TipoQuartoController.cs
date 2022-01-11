using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospedagemOnline.Controllers
{
    public class TipoQuartoController : Controller
    {
        private HospedagemBDEntities db = new HospedagemBDEntities();
        public ActionResult Index()
        {
            var tipoQuartos = db.TipoQuarto.Include("Quarto").ToList();
            return View(tipoQuartos);
        }

        public ActionResult Inserir()
        {
            ViewBag.IdQuarto = new SelectList(db.Quarto, "IdQuarto", "NumeroQuarto", "Disponivel");
                                                       
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(TipoQuarto tipoQuarto)
        {
            if (ModelState.IsValid)
            {
                db.TipoQuarto.Add(tipoQuarto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdQuarto = new SelectList(db.Quarto, "IdQuarto", "NumeroQuarto", "Disponivel",
                                                       tipoQuarto.IdQuarto);
            return View(tipoQuarto);
        }

        public ActionResult Alterar(int id)
        {
            TipoQuarto tipoQuarto = db.TipoQuarto.Find(id);
            ViewBag.IdQuarto = new SelectList(db.Quarto, "IdQuarto", "NumeroQuarto", "Disponivel",
                                                       tipoQuarto.IdQuarto);
            return View(tipoQuarto);
        }

        [HttpPost]
        public ActionResult Alterar(TipoQuarto tipoQuarto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoQuarto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdQuarto = new SelectList(db.Quarto, "IdQuarto", "NumeroQuarto", "Disponivel",
                                                       tipoQuarto.IdQuarto);
            return View(tipoQuarto);
        }

        public ActionResult Excluir(int id)
        {
            TipoQuarto tipoQuarto = db.TipoQuarto.Find(id);
            ViewBag.IdQuarto = new SelectList(db.Quarto, "IdQuarto", "NumeroQuarto", "Disponivel",
                                                        tipoQuarto.IdQuarto);
            return View(tipoQuarto);
        }

        [HttpPost, ActionName("Excluir")]
        public ActionResult EfetuarExclusao(int id)
        {
            try
            {
                TipoQuarto tipoQuarto = db.TipoQuarto.Find(id);
                db.Categoria.Remove(tipoQuarto);
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