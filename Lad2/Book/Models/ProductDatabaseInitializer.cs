using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Book.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Khoa học viễn tưởng"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Hài"
                },
                new Category{
                    CategoryID = 3,
                    CategoryName = "Hành động"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Hoạt hình"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Ma"
                },
            };
            return categories;
        }
        private static List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                    ProductName = "BIỆT ĐỘI SIÊU ANH HÙNG 3: CUỘC CHIẾN VÔ CỰC",
                    Description = "Sau chuyến hành trình độc nhất vô nhị không ngừng mở rộng và phát triển vụ trũ điện ảnh Marvel, bộ phim Avengers: Cuộc Chiến Vô Cực sẽ mang đến màn ảnh trận chiến cuối cùng khốc liệt nhất mọi thời đại. Biệt đội Avengers và các đồng minh siêu anh hùng của họ phải chấp nhận hy sinh tất cả để có thể chống lại kẻ thù hùng mạnh Thanos trước tham vọng hủy diệt toàn bộ vũ trụ của hắn.",
                    ImagePath="khvt1.jpg",
                    link="http://www.phimmoizz.net/phim/biet-doi-sieu-anh-hung-3-cuoc-chien-vo-cuc-i9-3244/",
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 2,
                    ProductName = "BIỆT ĐỘI SIÊU ANH HÙNG 4: HỒI KẾT",
                    Description = "Biệt Đội Siêu Anh Hùng 4: Tàn Cuộc (Avengers 4: Endgame) ra mắt vào tháng 4/2019 sẽ giải quyết triệt để những khúc mắc đã vạch ra suốt 22 bộ phim trước đó của Vụ trụ điện ảnh Marvel (MCU). Hai tháng sau đó, Người Nhện 2 là khởi đầu hoàn toàn mới dành cho MCU.",
                    ImagePath="khvt2.jpg",
                    link="http://www.phimmoizz.net/phim/biet-doi-sieu-anh-hung-4-hoi-ket-i0-7166/",
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 3,
                    ProductName = "BIỆT ĐỘI SIÊU ANH HÙNG",
                    Description = "Marvel’s The Avengers là bộ phim giả tưởng kể về một nhóm siêu anh hùng với những khả năng đặc biệt, họ bao gồm: Người Sắt, Thor, Captain America, và Người Khổng Lồ được gọi chung với cái tên SHIELD. Mục đích của SHIELD là nhằm bảo vệ Trái đất khỏi âm mưu hủy hoại của những thế lực xấu từ ngoài địa cầu mà kẻ cầm đầu là Loki. Marvel’s The Avengers Là một trong những phim được mong đợi nhất hè 2012, phim quy tụ dàn diễn viên đẹp với những cảnh quay sống động đã mang về cho nhà sản xuất hơn 1 tỷ USD. Nếu bạn đã từng là Fan của những siêu phẩm như: Spider-Man, Batman thì Marvel’s The Avengers quả là một bộ phim khó có thể bỏ qua.",
                    ImagePath="khvt3.jpg",
                    link="http://www.phimmoizz.net/phim/biet-doi-sieu-anh-hung-i8-44/",
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Mr bean",
                    Description = "Nhắc tới Mr. Bean hẳn ai cũng đã từng nghe qua đúng không? Mr. Bean: The Animated Series là loạt series phim hoạt hình hài hước, vui nhộn về những câu chuyện đời thường của",
                    ImagePath="hai1.jpg",
                    link="http://www.phimmoizz.net/phim/mr-bean-the-animated-series-5268/",
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "THÁM TỬ MAIGRET",
                    Description = "ạo dựng danh tiếng nhờ bộ phim hài đình đám “Mr. Bean” nhưng Rowan Atkinson tái ngộ khán giả qua một tác phẩm thuộc thể loại tâm lý tội phạm “Maigret sets a trap”. Loạt phim về thám tử Maigret được làm lại từ bản phim nổi tiếng trong thập niên 60 do nam tài tử Rupert Davies thủ vai chính." ,                  
                    ImagePath = "hai2.jpg",
                    link="http://www.phimmoizz.net/phim/tham-tu-maigret-4937/",
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "QUÁ NHANH, QUÁ NGUY HIỂM 5",
                    Description = "Chuyện phim Fast Five tiếp nối từ phần 4 “Fast and Furious”. Vì cứu Dom ra khỏi ngục tù, Brian và Mia Toretto phải trôi dạt qua nước khác. Giờ đây tại Rio de Janeiro, cả ba tập hợp thành một đội đua xe gồm toàn những tay đua cự phách để thực hiện phi vụ cuối cùng để giành lấy tự do, đó là vụ trộm trị giá 100 triệu đô. Không chỉ đối mặt với tay trùm khét tiếng nhất thành phố Rio, họ còn phải đối đầu với sự truy đuổi ráo riết của điệp viên liên bang Luke Hobbs – người chưa bao giờ đánh mất mục tiêu… Với những pha hành động trơn tru trong một diễn biến đầy hồi hộp và sự trợ giúp đắc lực của âm nhạc, Fast Five là món ăn tinh thần hấp dẫn dành cho những người hâm mộ dòng phim tốc độ.",
                    ImagePath="hd1.jpg",
                    link="http://www.phimmoizz.net/phim/qua-nhanh-qua-nguy-hiem-5-i3-70/",
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "QUÁ NHANH, QUÁ NGUY HIỂM 7",
                    Description = "Dom và Letty hiện đang đi hưởng tuần trăng mật. Brian cùng Mia đã quyết định từ giã sự nghiệp. Các thành viên còn lại của nhóm cũng đã được minh oan và dần trở về với cuộc sống bình thường. Nhưng một người phụ nữ bí ẩn (do nữ diễn viên đoạt giải Oscar Charlize Theron thủ vai) đã dẫn dụ Dom vào thế giới tội phạm mà anh dường như không thể thoát ra được và thậm chí phản bội lại cả những người thân thiết nhất, họ sẽ phải trải qua những thử thách cam go mà họ chưa từng đối mặt.",
                    ImagePath="hd2.jpg",
                    link="http://www.phimmoizz.net/phim/qua-nhanh-qua-nguy-hiem-8-i5-3618/",
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "GIA ĐÌNH SIÊU NHÂN",
                    Description = "he Incredibles là bộ phim nói về gia đình siêu anh hùng Parr, mỗi người có một quyền năng khác nhau. Sau khi chính phủ ra lệnh các siêu anh hùng phải sống ẩn dật trong đời thường, Robert Parr, trước kia là siêu anh hùng có biệt hiệu là Mr. Incredible, đã phải từ bỏ sự nghiệp cứu giúp mọi người khỏi cái xấu, cái ác để làm một nhân viên bảo hiểm bình thường..",
                    ImagePath = "hh1.jpg",
                    link="http://www.phimmoizz.net/phim/gia-dinh-sieu-nhan-i1-471/",
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "GIA ĐÌNH SIÊU NHÂN 2",
                    Description = "Gia Đình Siêu Nhân 2 đánh dấu những chuyến phiêu lưu anh hùng đầy hấp dẫn với sự đổi vai đầy táo bạo. Lần này, mẹ dẻo Helen (Elastigirl) sẽ đi thực chiến giải cứu thế giới trong khi bố khỏe Bob (Mr. Incredible) lùi về hậu phương trông nom những đứa con siêu nhân láu lỉnh gồm: con gái Violet ( siêu năng lực tàng hình và tạo ra từ trường làm chắn bảo vệ), con trai Dash (chạy siêu nhanh) và cậu út Jack-Jack với sức mạnh chưa được khám phá. Một ác nhân bí ẩn xuất hiện với một âm mưu đáng sợ khiến cho gia đình siêu nhân phải “tái xuất giang hồ”. Liệu gia đình siêu nhân sẽ vượt qua khó khăn này như thế nào?",
                    ImagePath = "hh2.jpg",
                    link="http://www.phimmoizz.net/phim/gia-dinh-sieu-nhan-2-i3-6375/",
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "LỜI NGUYỀN 2 (LỜI NGUYỀN QUỶ ÁM 2)",
                    Description = "Truyện phim kể về một sinh viên 24 tuổi tốt nghiệp ngành tâm lý học tên Ando Fuuko (Takimoto đóng) phải nuôi đứa cháu gái 4 tuổi (Hirasawa Kokoro) đóng, con gái của người anh trai Takanori (Seto đóng) và người vợ Akane (Ishihara đóng).",
                    ImagePath = "ma1.jpg",
                   link="http://www.phimmoizz.net/phim/loi-nguyen-2-loi-nguyen-quy-am-2-870/",
                    CategoryID = 5
                },
               
              
            };
            return products;
        }
    }
}