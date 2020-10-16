using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProductManager.Models
{
    public class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}
