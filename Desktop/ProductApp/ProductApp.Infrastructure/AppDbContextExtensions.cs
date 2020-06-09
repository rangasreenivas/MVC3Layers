using ProductApp.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Infrastructure
{
    public class AppDbContextExtensions : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context) 
        { 
            context.Products.Add(new Product { Id = 1, Name = "Regrigrator", InStock = true, Price = 30 }); 
            context.Products.Add(new Product { Id = 2, Name = "Air Conditioner", InStock = false, Price = 40 }); 
            context.SaveChanges(); 
            base.Seed(context); 
        }
    }
}
