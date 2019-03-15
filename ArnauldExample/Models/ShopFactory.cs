using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace ArnauldExample.Models
{
    public class ShopFactory : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ShopFactory()
        {
            Database.SetInitializer(new ProductInitializer());
        }
    }

    public class ProductInitializer : DropCreateDatabaseIfModelChanges<ShopFactory>
    {
        protected override void Seed(ShopFactory context)
        {
            context.Products.Add(new Product { Name = "Product name1", Description = "Description of product", Price = 200, ImageName = "kat.jpg" });
            context.Products.Add(new Product { Name = "Product name2", Description = "Description of product", Price = 150, ImageName = "kat.jpg" });
        }
    }
}