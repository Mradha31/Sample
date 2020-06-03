namespace Demo.Migrations
{
    using Demo.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Demo.Models.RecordContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Demo.Models.RecordContext context)
        {
            var book = new List<Book1>
            {
                new Book1{Title="Madhu",Author="Hiremath",ISBN="2564",Publisher="joseh",Year="1777"}
            };
            book.ForEach(b=>context.Books.Add(b));
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

        }
    }
}
