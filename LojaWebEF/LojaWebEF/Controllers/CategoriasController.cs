using LojaWebEF.Entidades;
using LojaWebEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaWebEF.DAO;

namespace LojaWebEF.Controllers
{
    public class CategoriasController : Controller
    {
        private CategoriasDAO _dao;

        public CategoriasController(CategoriasDAO dao)
        {
            _dao = dao;
        }
        //
        // GET: /Categorias/

        public ActionResult Index()
        {
            IEnumerable<Categoria> categorias = new List<Categoria>();
            return View(categorias);
        }

        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Adiciona(Categoria categoria)
        {
            _dao.Adiciona(categoria);
            return RedirectToAction("Index");
        }

        public ActionResult Remove(int id)
        {
     
            return RedirectToAction("Index");
        }

        public ActionResult Visualiza(int id)
        {
            Categoria categoria = _dao.BuscaPorId(id);
            return View(categoria);
        }

        public ActionResult Atualiza(Categoria categoria)
        {
            
            return RedirectToAction("Index");
        }

        public ActionResult CategoriasEProdutos()
        {
            IEnumerable<Categoria> categorias = new List<Categoria>();
            return View(categorias);
        }

        public ActionResult BuscaPorNome(string nome)
        {
            ViewBag.Nome = nome;

            IEnumerable<Categoria> categorias = _dao.BuscaPorNome(nome);
            return View(categorias);
        }

        public ActionResult NumeroDeProdutosPorCategoria()
        {
            IEnumerable<ProdutosPorCategoria> produtosPorCategoria = _dao.ListaNumeroDeProdutosPorCategoria();
            return View(produtosPorCategoria);
        }
    }
}
