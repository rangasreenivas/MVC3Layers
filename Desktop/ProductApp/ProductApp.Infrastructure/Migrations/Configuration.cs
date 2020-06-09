namespace ProductApp.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ProductApp.Core;

    internal sealed class Configuration : DbMigrationsConfiguration<ProductApp.Infrastructure.ProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ProductApp.Infrastructure.ProductContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Products.Add(new Product { Id = 1, Name = "Regrigrator", InStock = true, Price = 30 });
            context.Products.Add(new Product { Id = 2, Name = "Air Conditioner", InStock = false, Price = 40 });
            context.SaveChanges();
            base.Seed(context);

        }
    }
}
