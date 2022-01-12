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
    public class CidadeController : Controller
    {
        private HospedagemBDEntities db = new HospedagemBDEntities();
        public ActionResult Index()
        {
            var cidades = db.Cidade.Include("Estabelecimento").ToList();
            return View(cidades);
        }

        public ActionResult Inserir()
        {
            ViewBag.IdEstabelecimento = new SelectList(db.Estabelecimento, "IdEstabelecimento", "Nomecomercial", "RazaoSocial",
                                                       "CNPJ", "Endereco", "Telefone", "Site");
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                db.Cidade.Add(cidade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdEstabelecimento = new SelectList(db.Estabelecimento, "IdEstabelecimento", "Nomecomercial", "RazaoSocial",
                                                       "CNPJ", "Endereco", "Telefone", "Site");
            return View(cidade);
        }

        public ActionResult Alterar(int id)
        {
            Cidade cidade = db.Categoria.Find(id);
            ViewBag.IdEstabelecimento = new SelectList(db.Estabelecimento, "IdEstabelecimento", "Nomecomercial", "RazaoSocial",
                                                       "CNPJ", "Endereco", "Telefone", "Site", cidade.IdEstabelecimento);
            return View(cidade);
        }

        [HttpPost]
        public ActionResult Alterar(Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cidade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdEstabelecimento = new SelectList(db.Estabelecimento, "IdEstabelecimento", "Nomecomercial", "RazaoSocial",
                                                       "CNPJ", "Endereco", "Telefone", "Site", cidade.IdEstabelecimento);
            return View(cidade);
        }

        public ActionResult Excluir(int id)
        {
            Cidade cidade = db.Cidade.Find(id);
            ViewBag.IdEstabelecimento = new SelectList(db.Estabelecimento, "IdEstabelecimento", "Nomecomercial", "RazaoSocial",
                                                      "CNPJ", "Endereco", "Telefone", "Site", cidade.IdEstabelecimento);
            return View(cidade);
        }

        [HttpPost, ActionName("Excluir")]
        public ActionResult EfetuarExclusao(int id)
        {
            try
            {
                Cidade cidade = db.Cidade.Find(id);
                db.Cidade.Remove(cidade);
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