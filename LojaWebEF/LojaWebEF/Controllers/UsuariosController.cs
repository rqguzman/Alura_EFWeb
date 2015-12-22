using LojaWebEF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LojaWebEF.DAO;

namespace LojaWebEF.Controllers
{
    public class UsuariosController : Controller
    {
        private UsuariosDAO _dao;

        public UsuariosController()
        {
            _dao = new UsuariosDAO();
        }
        //
        // GET: /Usuarios/

        public ActionResult Index()
        {
            IEnumerable<Usuario> usuarios = _dao.Lista();
            return View(usuarios);
        }

        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Adiciona(Usuario usuario)
        {
            _dao.Adiciona(usuario);
            return RedirectToAction("Index");
        }

        public ActionResult Remove(int id)
        {
            return RedirectToAction("Index");
        }

        public ActionResult Visualiza(int id)
        {
            Usuario usuario = _dao.BuscaPorId(id);
            return View(usuario);
        }

        public ActionResult Atualiza(Usuario usuario)
        {
            return RedirectToAction("Index");
        }

    }
}
