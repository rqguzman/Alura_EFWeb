using LojaWebEF.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LojaWebEF.DAO
{
    public class UsuariosDAO
    {
        private EntidadesContext _contexto;

        public UsuariosDAO(EntidadesContext contexto)
        {
            this._contexto = contexto;
        }

        public void Adiciona(Usuario usuario)
        {
            _contexto.Usuarios.Add(usuario);
            _contexto.SaveChanges();
            _contexto.Dispose();
        }

        public void Remove(Usuario usuario)
        {
            _contexto.Usuarios.Remove(usuario);
            _contexto.SaveChanges();
            _contexto.Dispose();
        }

        public void Atualiza(Usuario usuario)
        {
            _contexto.Entry(usuario).State = EntityState.Modified;
            _contexto.SaveChanges();
            _contexto.Dispose();
        }

        public Usuario BuscaPorId(int id)
        {

            return _contexto.Usuarios.Find(id);
        }

        public IEnumerable<Usuario> Lista()
        {
            return _contexto.Usuarios.ToList();
        }
    }
}