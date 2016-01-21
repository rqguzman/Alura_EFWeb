using LojaWebEF.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LojaWebEF.DAO
{
    public class ProdutosDAO
    {
        private EntidadesContext _contexto;

        public ProdutosDAO(EntidadesContext contexto)
        {
            this._contexto = contexto;
        }

        public void Adiciona(Produto produto)
        {
            _contexto.Produtos.Add(produto);
        }

        public void Remove(Produto produto)
        {
            _contexto.Produtos.Remove(produto);
        }

        public void Atualiza(Produto produto)
        {
            _contexto.Entry(produto).State = EntityState.Modified;
        }

        public Produto BuscaPorId(int id)
        {
            return _contexto.Produtos.Find(id);
        }

        public IEnumerable<Produto> Lista()
        {
            var busca = from p in _contexto.Produtos.Include("Categoria")
                        select p;

            return busca.ToList();
        }

        public IEnumerable<Produto> ProdutosComPrecoMaiorDoQue(decimal? preco)
        {
            decimal minimo = preco.GetValueOrDefault(0);

            var busca = from p in _contexto.Produtos
                where p.Preco > minimo
                select p;
            return busca.ToList();
        }

        public IEnumerable<Produto> ProdutosDaCategoria(string nomeCategoria)
        {
            var busca = from p in _contexto.Produtos
                        where p.Categoria.Nome == nomeCategoria
                        select p;
            return busca.ToList();
        }

        public IEnumerable<Produto> ProdutosDaCategoriaComPrecoMaiorDoQue(decimal? preco, string nomeCategoria)
        {
            decimal minimo = preco.GetValueOrDefault(0);

            var busca = from p in _contexto.Produtos
                        where p.Categoria.Nome == nomeCategoria && p.Preco > minimo
                        select p;

            return busca.ToList();
        }

        public IEnumerable<Produto> ListaPaginada(int paginaAtual)
        {
            var busca = from p in _contexto.Produtos
                        orderby p.Id
                        select p;
            
                busca.Skip(10 * (paginaAtual - 1));
                return busca.Take(10).ToList();                     
        }

        public IEnumerable<Produto> BuscaPorPrecoCategoriaENome(decimal? preco, string nomeCategoria, string nome)
        {
            return new List<Produto>();
        }
    }
}