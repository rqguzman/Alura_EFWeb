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
        private EntidadesContext _contexto;

        public CategoriasDAO(EntidadesContext contexto)
        {
            this._contexto = contexto;
        }

        public void Adiciona(Categoria categoria)
        {
            _contexto.Categorias.Add(categoria);
        }

        public void Remove(Categoria categoria)
        {
            _contexto.Entry(categoria).State = EntityState.Modified;
        }

        public void Atualiza(Categoria categoria)
        {
            _contexto.Entry(categoria).State = EntityState.Modified;
        }

        public Categoria BuscaPorId(int id)
        {
            return _contexto.Categorias.Find(id);
        }

        public IEnumerable<Categoria> Lista()
        {
            return _contexto.Categorias.ToList();
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