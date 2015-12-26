using System.Collections.Generic;

namespace LojaWebEF.Entidades
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public virtual IList<Produto> Produtos { get; set; } 
    }
}