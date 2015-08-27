namespace Test.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Test.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<Test.Dao.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Test.Dao.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var operadoras = new List<Operadora>();
            operadoras.Add(new Operadora() { Nome = "Oi", Codigo = 14, Categoria = "Celular" });
            operadoras.Add(new Operadora() { Nome = "Vivo", Codigo = 15, Categoria = "Celular" });
            operadoras.Add(new Operadora() { Nome = "Tim", Codigo = 41, Categoria = "Celular" });
            operadoras.Add(new Operadora() { Nome = "GVT", Codigo = 25, Categoria = "Telefone" });
            operadoras.Add(new Operadora() { Nome = "Embratel", Codigo = 21, Categoria = "Telefone" });

            foreach (var x in operadoras)
            {
                context.Operadora.AddOrUpdate(x);
            }

            var contatos = new List<Contato>();
            contatos.Add(new Contato() { Nome = "Gustavo", Data = new DateTime(2015, 5, 10), Telefone = "2679-5578", Operadora = context.Operadora.Find(1) });
            contatos.Add(new Contato() { Nome = "Laviola", Data = new DateTime(2012, 1, 5), Telefone = "96541-5555", Operadora = context.Operadora.Find(2) });
            contatos.Add(new Contato() { Nome = "Sanches", Data = new DateTime(2010, 12, 1), Telefone = "95654-5648", Operadora = context.Operadora.Find(3) });
            contatos.Add(new Contato() { Nome = "Lucas", Data = new DateTime(2007, 7, 8), Telefone = "2679-5461", Operadora = context.Operadora.Find(4) });

            foreach (var x in contatos)
            {
                context.Contato.AddOrUpdate(x);
            }
        }
    }
}
