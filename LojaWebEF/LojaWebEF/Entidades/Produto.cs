﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWebEF.Entidades
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public int? CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}