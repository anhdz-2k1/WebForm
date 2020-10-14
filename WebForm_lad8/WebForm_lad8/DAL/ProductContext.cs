using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebForm_lad8.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebForm_lad8.DAL
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("ProductContext")
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }
    }
}