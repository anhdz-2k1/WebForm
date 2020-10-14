using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForm_lad8.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Introduce { get; set; }
        public string UrlImage { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

    }
}