using LojaWebEF.Entidades;
using LojaWebEF.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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
            var busca = from c in _contexto.Categorias.Include("Produtos")
                        select c;

            System.Diagnostics.Trace.WriteLine(busca);
            return busca.ToList();
        }

        public IEnumerable<Categoria> BuscaPorNome(string nome)
        {
            var busca = from c in _contexto.Categorias
                        where c.Nome == nome
                        select c;
            return busca.ToList();
        }

        public IEnumerable<ProdutosPorCategoria> ListaNumeroDeProdutosPorCategoria()
        {
            var busca = from c in _contexto.Categorias
                        select new ProdutosPorCategoria ()
                        {
                            Categoria = c,
                            NumeroDeProdutos = c.Produtos.Count
                        };

            List<ProdutosPorCategoria> resultado = busca.ToList();

            return resultado;
        }
    }   

}