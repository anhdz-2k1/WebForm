using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebForm_lad8.Models;

namespace WebForm_lad8.DAL
{
    public class ProductInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            var product = new List<Product>
            {
                new Product{ID = 1, Name = "Hoi ki Sir Alex", Introduce="...", UrlImage="https://salt.tikicdn.com/cache/280x280/media/catalog/product/i/m/img030_8.jpg", Price=135000.00, CategoryId=1},
                new Product{ID = 2, Name = "Sir Alex Quan li dan dat chu khong lanh dao", Introduce="...", UrlImage="https://salt.tikicdn.com/cache/w390/ts/product/e2/84/52/9a74c9677e08b27dc1f48d1c314e953e.jpg", Price=145000.00, CategoryId=1},
                new Product{ID = 3, Name = "Bill Gates: Tham Vọng Lớn Lao Và Quá Trình Hình Thành Đế Chế Microsoft", Introduce="...", UrlImage="https://salt.tikicdn.com/cache/w390/ts/product/7a/c7/eb/3dec73cecf7e2bb12a9d58eac21c917a.jpg", Price=135000.00, CategoryId = 4},
                new Product{ID = 4, Name = "Fujiko F Fujio Đại Tuyển Tập - Doraemon Truyện Ngắn Tập 20", Introduce="...", UrlImage="https://salt.tikicdn.com/cache/w390/ts/product/8a/b3/8e/33fa0fcb17c8d9634d1c8103ff50812c.jpg", Price=135000.00, CategoryId = 3},


            };
            product.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

            var categories = new List<Category>
            {
               new Category{ Id=1, Namecategory = "Sach The Thao"  },
               new Category{ Id=3, Namecategory = "Sach tre em" },
               new Category{ Id=4, Namecategory = "Sach Kinh Doan"},
            };
            categories.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();
        }
    }
}