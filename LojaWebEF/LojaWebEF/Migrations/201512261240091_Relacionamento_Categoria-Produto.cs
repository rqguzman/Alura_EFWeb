namespace LojaWebEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Relacionamento_CategoriaProduto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produtoes", "CategoriaId", c => c.Int());
            CreateIndex("dbo.Produtoes", "CategoriaId");
            AddForeignKey("dbo.Produtoes", "CategoriaId", "dbo.Categorias", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtoes", "CategoriaId", "dbo.Categorias");
            DropIndex("dbo.Produtoes", new[] { "CategoriaId" });
            DropColumn("dbo.Produtoes", "CategoriaId");
        }
    }
}
