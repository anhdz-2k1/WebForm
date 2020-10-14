using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForm_lad8.Models
{

    public class Category
    {
        public int Id { get; set; }
        public string Namecategory { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}