namespace CalculoFrete.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Transportadora : DbMigration
    {
        internal string nome;

        public override void Up()
        {
            CreateTable(
                "dbo.Transportadoras",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Transportadoras");
        }
    }
}
