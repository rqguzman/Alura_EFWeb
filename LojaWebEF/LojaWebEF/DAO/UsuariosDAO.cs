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
        private EntidadesContext contexto;

        public UsuariosDAO()
        {
            this.contexto = new EntidadesContext();
        }

        public void Adiciona(Usuario usuario)
        {
            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public void Remove(Usuario usuario)
        {
            contexto.Usuarios.Remove(usuario);
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public void Atualiza(Usuario usuario)
        {
            contexto.Entry(usuario).State = EntityState.Modified;
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public Usuario BuscaPorId(int id)
        {

            return contexto.Usuarios.Find(id);
        }

        public IEnumerable<Usuario> Lista()
        {
            return contexto.Usuarios.ToList();
        }
    }
}