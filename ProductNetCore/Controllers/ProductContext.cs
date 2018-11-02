using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductNetCore.Models;

namespace ProductNetCore.Controllers
{
    public class ProductContext :DbContext
    {
        public ProductContext(DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
    public class Category
    {
        public long id { get; set; }
        public string name { get; set; }

    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
