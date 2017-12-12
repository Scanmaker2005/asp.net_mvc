namespace CalculoFrete.Web.Migrations
{
    using CalculoFrete.Web.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CalculoFrete.Web.Core;

    internal sealed class Configuration : DbMigrationsConfiguration<CalculoFrete.Web.Models.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CalculoFrete.Web.Models.Context context)
        {
            context.Usuarios.AddOrUpdate(x => x.id,
                new Usuario()
                {
                    nome  = "Administrador",
                    email = "administrador@admin.com",
                    senha = Crypt.MD5("123")
                }
            );
        }
    }
}
