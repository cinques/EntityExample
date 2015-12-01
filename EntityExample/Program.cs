using System;
using System.Data.Entity;
using System.Linq;

namespace EntityExample
{
    class Program
    {
        public class Product
        {
            public int Id { get; set; } 

            public string Name { get; set; }
        }

        public class EntityDB : DbContext
        {
            public EntityDB() : base("name=DefaultConnection")
            {
            }

            public DbSet<Product> Products { get; set; }
        }

        static void Main(string[] args)
        {
            using (var entityDB = new EntityDB())
            {
                entityDB.Products.Add(new Product { Name = "Milk" });

                entityDB.SaveChanges();

                foreach (var product in entityDB.Products.ToList())
                {
                    Console.WriteLine(product.Name);   
                }
            }
        }
    }
}
