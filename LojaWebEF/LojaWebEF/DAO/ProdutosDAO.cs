using LojaWebEF.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
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
            _contexto.SaveChanges();
            _contexto.Dispose();
        }

        public void Remove(Produto produto)
        {
            _contexto.Produtos.Remove(produto);
            _contexto.SaveChanges();
            _contexto.Dispose();
        }

        public void Atualiza(Produto produto)
        {
            _contexto.Entry(produto).State = EntityState.Modified;
            _contexto.SaveChanges();
            _contexto.Dispose();
        }

        public Produto BuscaPorId(int id)
        {
            return _contexto.Produtos.Find(id);
        }

        public IEnumerable<Produto> Lista()
        {
            return _contexto.Produtos.ToList();
        }

        public IEnumerable<Produto> ProdutosComPrecoMaiorDoQue(decimal? preco)
        {
            return new List<Produto>();
        }

        public IEnumerable<Produto> ProdutosDaCategoria(string nomeCategoria)
        {
            return new List<Produto>();
        }

        public IEnumerable<Produto> ProdutosDaCategoriaComPrecoMaiorDoQue(decimal? preco, string nomeCategoria)
        {
            return new List<Produto>();
        }

        public IEnumerable<Produto> ListaPaginada(int paginaAtual)
        {
            return new List<Produto>();
        }

        public IEnumerable<Produto> BuscaPorPrecoCategoriaENome(decimal? preco, string nomeCategoria, string nome)
        {
            return new List<Produto>();
        }
    }
}