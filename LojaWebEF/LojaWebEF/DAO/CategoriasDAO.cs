using LojaWebEF.Entidades;
using LojaWebEF.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LojaWebEF.DAO
{
    public class CategoriasDAO
    {
        private EntidadesContext contexto;

        public CategoriasDAO()
        {
            this.contexto = new EntidadesContext();
        }

        public void Adiciona(Categoria categoria)
        {
            contexto.Categorias.Add(categoria);
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public void Remove(Categoria categoria)
        {
            contexto.Entry(categoria).State = EntityState.Modified;
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public void Atualiza(Categoria categoria)
        {
            contexto.Entry(categoria).State = EntityState.Modified;
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public Categoria BuscaPorId(int id)
        {
            return contexto.Categorias.Find(id);
        }

        public IEnumerable<Categoria> Lista()
        {
            return contexto.Categorias.ToList();
        }

        public IEnumerable<Categoria> BuscaPorNome(string nome)
        {
            return new List<Categoria>();
        }

        public IEnumerable<ProdutosPorCategoria> ListaNumeroDeProdutosPorCategoria()
        {
            return new List<ProdutosPorCategoria>();
        }
    }

}