﻿using LojaWebEF.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LojaWebEF.DAO
{
    public class ProdutosDAO
    {
        private EntidadesContext contexto;

        public ProdutosDAO()
        {
            this.contexto = new EntidadesContext();
        }

        public void Adiciona(Produto produto)
        {
            contexto.Produtos.Add(produto);
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public void Remove(Produto produto)
        {
            contexto.Produtos.Remove(produto);
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public void Atualiza(Produto produto)
        {
            contexto.Entry(produto).State = EntityState.Modified;
            contexto.SaveChanges();
            contexto.Dispose();
        }

        public Produto BuscaPorId(int id)
        {
            return contexto.Produtos.Find(id);
        }

        public IEnumerable<Produto> Lista()
        {
            return contexto.Produtos.ToList();
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