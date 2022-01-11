using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospedagemOnline.Controllers
{
    public class CategoriaController : Controller
    {
        private HospedagemBDEntities db = new HospedagemBDEntities();
        public ActionResult Index()
        {
            var categorias = db.Categoria.Include("Estabelecimento").ToList();
            return View(categorias);
        }

        public ActionResult Inserir()
        {
            ViewBag.IdEstabelecimento = new SelectList(db.Estabelecimento, "IdEstabelecimento", "Nomecomercial", "RazaoSocial",
                                                       "CNPJ", "Endereco", "Telefone", "Site");
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                db.Categoria.Add(categoria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdEstabelecimento = new SelectList(db.Estabelecimento, "IdEstabelecimento", "Nomecomercial", "RazaoSocial",
                                                       "CNPJ", "Endereco", "Telefone", "Site", categoria.IdEstabelecimento);
           return View(categoria);
        }

        public ActionResult Alterar(int id)
        {
            Categoria categoria = db.Categoria.Find(id); 
            ViewBag.IdEstabelecimento = new SelectList(db.Estabelecimento, "IdEstabelecimento", "Nomecomercial", "RazaoSocial",
                                                       "CNPJ", "Endereco", "Telefone", "Site", categoria.IdEstabelecimento);
            return View(categoria);
        }

        [HttpPost]
        public ActionResult Alterar(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdEstabelecimento = new SelectList(db.Estabelecimento, "IdEstabelecimento", "Nomecomercial", "RazaoSocial",
                                                       "CNPJ", "Endereco", "Telefone", "Site", categoria.IdEstabelecimento);
            return View(categoria);
        }

        public ActionResult Excluir(int id)
        {
            Categoria categoria = db.Categoria.Find(id);
            ViewBag.IdEstabelecimento = new SelectList(db.Estabelecimento, "IdEstabelecimento", "Nomecomercial", "RazaoSocial",
                                                      "CNPJ", "Endereco", "Telefone", "Site", categoria.IdEstabelecimento);
            return View(categoria);
        }

        [HttpPost, ActionName("Excluir")]
        public ActionResult EfetuarExclusao(int id)
        {
            try
            {
                Categoria categoria = db.Categoria.Find(id);
                db.Categoria.Remove(categoria);
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