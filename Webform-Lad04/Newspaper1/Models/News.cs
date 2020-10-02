using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Newspaper1.Models
{
    public partial class News
    {
        public News() 
        {
            Post = new HashCode<Post>();
        }

        public int NewId { get; set; }
        public string Sections { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
