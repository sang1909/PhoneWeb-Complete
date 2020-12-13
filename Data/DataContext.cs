using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PhoneWeb.Models;
using PhoneWeb.Models.Domain;

namespace PhoneWeb.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Category>().HasData(
               new Category() { CategoryId = 1, CategoryName = "Iphone" },
                 new Category() { CategoryId = 2, CategoryName = "SamSung" },
                   new Category() { CategoryId = 3, CategoryName = "Vsmart" },
                     new Category() { CategoryId = 4, CategoryName = "Nokia" },
                       new Category() { CategoryId = 5, CategoryName = "Oppo" },
                         new Category() { CategoryId = 6, CategoryName = "Xiaomi" },
                            new Category() { CategoryId = 7, CategoryName = "Huawei" },
                               new Category() { CategoryId = 8, CategoryName = "Vivo" },
                                 new Category() { CategoryId = 9, CategoryName = "LG" });


            //----------------------------------------------------------------------------------------------------------------
            builder.Entity<Product>().HasData(new Product()
            {
                ProductId = 1,
                ProductName = "Iphone11",
                ProductImage = "ip11.jpg",
                Descriptions = "Công nghệ màn hình: OLED, " +
                               "Độ phân giải: 1242 x 2688 Pixels, " +
                               "Màn hình rộng: 6.5 inch, " +
                               "Mặt kính cảm ứng: Kính cường lực oleophobic(ion cường lực), " +
                               "Camera sau: Độ phân giải 3 camera 12 MP, " +
                               "Camera trước: 12 MP, " +
                               "Ram: 4GB, " +
                               "Bộ nhớ trong: 64GB, " +
                               "Không hổ trợ bộ nhớ ngoài" +
                                "Dung lượng pin 3969 mAh",
                ProductQuantity = 100,
                ProductPrice = 20000000,
                CreateDate = DateTime.Now,
                CategoryId = 1

            }, new Product()
            {
                ProductId = 2,
                ProductName = "Iphone X",
                ProductImage = "ipx.jpg",
                Descriptions = "Công nghệ màn hình: OLED, " +
                               "Độ phân giải: 1125 x 2436 Pixels, " +
                               "Màn hình rộng: 5.8 inch, " +
                               "Mặt kính cảm ứng: Kính cường lực oleophobic(ion cường lực), " +
                               "Camera sau: Chính 12 MP & Phụ 12 MP, " +
                               "Camera trước: 7 MP, " +
                               "Ram: 3GB, " +
                               "Bộ nhớ trong: 64GB, " +
                               "Không hổ trợ bộ nhớ ngoài" +
                                "Dung lượng pin 2716 mAh",
                ProductQuantity = 100,
                ProductPrice = 17500000,
                CreateDate = DateTime.Now,
                CategoryId = 1

            }, new Product()
            {
                ProductId = 3,
                ProductName = "Iphone8",
                ProductImage = "ip8.jpg",
                Descriptions = "Công nghệ màn hình: LED-backlit IPS LCD, " +
                               "Độ phân giải: Full HD (1080 x 1920 Pixels), " +
                               "Màn hình rộng: 5.5 inch, " +
                               "Mặt kính cảm ứng: Kính cường lực oleophobic(ion cường lực), " +
                               "Camera sau: Chính 12 MP & Phụ 12 MP, " +
                               "Camera trước: 7 MP, " +
                               "Ram: 3GB, " +
                               "Bộ nhớ trong: 64GB, " +
                               "Không hổ trợ bộ nhớ ngoài" +
                                "Dung lượng pin 2691 mAh",
                ProductQuantity = 100,
                ProductPrice = 14000000,
                CreateDate = DateTime.Now,
                CategoryId = 1
            }, new Product()
            {
                ProductId = 4,
                ProductName = "Samsung Galaxy S20+",
                ProductImage = "ss20.jpg",
                Descriptions = "Công nghệ màn hình: Màn hình 6.7, Quad HD+ (2K+)" +
                               "Độ phân giải: 2K+ (1440 x 3200 Pixels), " +
                               "Hệ điều hành: Android 10, " +
                               "Mặt kính cảm ứng: 	Kính cường lực Corning Gorilla Glass 6, " +
                               "Camera sau: Chính 12 MP & phụ 64 MP, 12 MP, TOF 3D, " +
                               "Camera trước: 10 MP, " +
                               "Ram: 8 GB, " +
                               "Bộ nhớ trong: 128GB, " +
                               "Hổ trợ bộ nhớ ngoài tối đa 1TB" +
                                "Dung lượng pin 4500 mAh",
                ProductQuantity = 100,
                ProductPrice = 18990000,
                CreateDate = DateTime.Now,
                CategoryId = 2
            },
            new Product()
            {
                ProductId = 5,
                ProductName = "Vsmart Joy 3",
                ProductImage = "vsmartjoy3.jpg",
                Descriptions = "Công nghệ màn hình: IPS LCD, " +
                               "Độ phân giải: HD+ (720 x 1600 Pixels), " +
                               "Màn hình rộng: 6.5 inch, " +
                               "Mặt kính cảm ứng: 	Mặt kính cong 2.5D, " +
                               "Camera sau: Chính 13 MP & Phụ 8 MP, 2 MP, " +
                               "Camera trước: 8 MP, " +
                               "Ram: 4 GB, " +
                               "Bộ nhớ trong: 64 GB, " +
                               "Hổ trợ bộ nhớ ngoài tối đa 64GB" +
                                "Dung lượng pin 5000 mAh",
                ProductQuantity = 100,
                ProductPrice = 4000000,
                CreateDate = DateTime.Now,
                CategoryId = 3
            },
            new Product()
            {
                ProductId = 6,
                ProductName = "Nokia 1280",
                ProductImage = "nokia1280.jpg",
                Descriptions = "Nokia 1280 - Legendary, Nghe, Gọi, Nhắn tin, Thay thế đồng hồ báo thức, Chống nước, Chống sốc",
                ProductQuantity = 100,
                ProductPrice = 200000,
                CreateDate = DateTime.Now,
                CategoryId = 4
            },
            new Product()
            {
                ProductId = 7,
                ProductName = "Vsmart Live",
                ProductImage = "vslive.jpg",
                Descriptions = "Công nghệ màn hình: AMOLED, " +
                               "Độ phân giải: Full HD+ (1080 x 2232 Pixels), " +
                               "Màn hình rộng: 6.2 inch, " +
                               "Mặt kính cảm ứng: Mặt kính cong 2.5D, " +
                               "Camera sau: Chính 48 MP & Phụ 8 MP, 5 MP, " +
                               "Camera trước: 20 MP, " +
                               "Ram: 6 GB, " +
                               "Bộ nhớ trong: 64 GB, " +
                               "Không hổ trợ bộ nhớ ngoài " +
                                "Dung lượng pin 4000 mAh",
                ProductQuantity = 100,
                ProductPrice = 7000000,
                CreateDate = DateTime.Now,
                CategoryId = 3
            },
             new Product()
             {
                 ProductId = 8,
                 ProductName = "Samsung Galaxy S20",
                 ProductImage = "ssS20.jpg",
                 Descriptions = "Công nghệ màn hình: Dynamic AMOLED 2X, 6.2 inch, Quad HD+ (2K+), " +
                               "Độ phân giải: Full HD+ (1080 x 2400 Pixels), " +
                               "Màn hình rộng: 6.2 inch, " +
                               "Mặt kính cảm ứng: Kính cường lực Corning Gorilla Glass 6, " +
                               "Camera sau: Chính 12 MP & Phụ 64 MP, 12 MP, " +
                               "Camera trước: 10 MP, " +
                               "Ram: 8 GB, " +
                               "Bộ nhớ trong: 128 GB, " +
                               "Hổ trợ bộ nhớ ngoài tối đa 512 GB " +
                               "Thẻ Sim: 2 Nano SIM hoặc 1 Nano SIM + 1 eSIM, Hỗ trợ 4G" +
                                "Dung lượng pin 4000 mAh" +
                                "Công nghệ pin: Sạc ngược không dây, Sạc pin nhanh, Siêu tiết kiệm pin, Sạc không dây ",
                 ProductQuantity = 100,
                 ProductPrice = 21490000,
                 CreateDate = DateTime.Now,
                 CategoryId = 2
             },
            new Product()
            {
                ProductId = 9,
                ProductName = "Samsung Galaxy M20",
                ProductImage = "ssM20.png",
                Descriptions = "Công nghệ màn hình: PLS TFT LCD, " +
                               "Độ phân giải: 	Full HD+ (1080 x 2340 Pixels), " +
                               "Màn hình rộng: 6.3 inch, " +
                               "Mặt kính cảm ứng: 	Mặt kính cong 2.5D, " +
                               "Camera sau: 	Chính 13 MP & Phụ 5 MP, " +
                               "Camera trước: 8 MP, " +
                               "Ram: 3 GB, " +
                               "Bộ nhớ trong: 31 GB, " +
                               "Hổ trợ bộ nhớ ngoài tối đa 512 GB " +
                                "Dung lượng pin 4000 mAh",
                ProductQuantity = 100,
                ProductPrice = 5490000,
                CreateDate = DateTime.Now,
                CategoryId = 2
            },
            new Product()
            {
                ProductId = 10,
                ProductName = "Samsung Galaxy A71",
                ProductImage = "ssA71.png",
                Descriptions = "Công nghệ màn hình: Super AMOLED, " +
                               "Độ phân giải: 	Full HD+ (1080 x 2400 Pixels), " +
                               "Màn hình rộng: 6.7 inch, " +
                               "Mặt kính cảm ứng: 	Kính cường lực, " +
                               "Camera sau: Chính 64 MP & Phụ 12 MP, 5 MP, 5 MP, " +
                               "Camera trước: 32 MP, " +
                               "Ram: 8 GB, " +
                               "Bộ nhớ trong: 128 GB, " +
                               "Hổ trợ bộ nhớ ngoài tối đa 512 GB " +
                                "Dung lượng pin 5000 mAh",
                ProductQuantity = 100,
                ProductPrice = 10590000,
                CreateDate = DateTime.Now,
                CategoryId = 2
            },
            new Product()
            {
                ProductId = 11,
                ProductName = "Nokia 7.2",
                ProductImage = "nokia72.png",
                Descriptions = "Công nghệ màn hình: IPS LCD, " +
                               "Độ phân giải: 	Full HD+ (1080 x 2340 Pixels), " +
                               "Màn hình rộng: 6.3 inch, " +
                               "Mặt kính cảm ứng: 	Kính cường lực Corning Gorilla Glass 3, " +
                               "Camera sau: Chính 48 MP & Phụ 8 MP, 5 MP, " +
                               "Camera trước: 20 MP, " +
                               "Ram: 4 GB, " +
                               "Bộ nhớ trong: 64 GB, " +
                               "Hổ trợ bộ nhớ ngoài tối đa 400 GB " +
                                "Dung lượng pin 4500 mAh",
                ProductQuantity = 100,
                ProductPrice = 6190000,
                CreateDate = DateTime.Now,
                CategoryId = 4
            },
            new Product()
            {
                ProductId = 12,
                ProductName = "Samsung Galaxy A50s",
                ProductImage = "ssA50s.png",
                Descriptions = "Công nghệ màn hình: Super AMOLED, " +
                               "Độ phân giải: 	Full HD+ (1080 x 2340 Pixels), " +
                               "Màn hình rộng: 6.4 inch, " +
                               "Mặt kính cảm ứng: 	Mặt kính cong 2.5D, " +
                               "Camera sau: Chính 48 MP & Phụ 8 MP, 5 MP, " +
                               "Camera trước: 32 MP, " +
                               "Ram: 4 GB, " +
                               "Bộ nhớ trong: 64 GB, " +
                               "Hổ trợ bộ nhớ ngoài tối đa 512 GB " +
                               "Dung lượng pin 4000 mAh",
                ProductQuantity = 100,
                ProductPrice = 6990000,
                CreateDate = DateTime.Now,
                CategoryId = 2
            },
            new Product()
            {
                ProductId = 13,
                ProductName = "Vsmart Active 3",
                ProductImage = "vsActive3.jpg",
                Descriptions = "Công nghệ màn hình: AMOLED, " +
                               "Độ phân giải: Full HD+ (1080 x 2340 Pixels), " +
                               "Màn hình rộng: 6.39 inch, " +
                               "Mặt kính cảm ứng: Mặt kính cong 2.5D, " +
                               "Camera sau: Chính 48 MP & Phụ 8 MP, 5 MP, " +
                               "Camera trước: 16 MP, " +
                               "Ram: 6 GB, " +
                               "Bộ nhớ trong: 64 GB, " +
                               "Hổ trợ bộ nhớ ngoài tối đa 256GB " +
                                "Dung lượng pin 4020 mAh",
                ProductQuantity = 100,
                ProductPrice = 3790000,
                CreateDate = DateTime.Now,
                CategoryId = 3
            },
            new Product()
            {
                ProductId = 14,
                ProductName = "Vsmart Star",
                ProductImage = "vsStar.jpg",
                Descriptions = "Công nghệ màn hình: IPS LCD, " +
                               "Độ phân giải: HD+ (720 x 1520 Pixels), " +
                               "Màn hình rộng: 5.7 inch, " +
                               "Mặt kính cảm ứng: Mặt kính cong 2.5D, " +
                               "Camera sau: Chính 8 MP & Phụ 2 MP, " +
                               "Camera trước: 5 MP, " +
                               "Ram: 2 GB, " +
                               "Bộ nhớ trong: 16 GB, " +
                               "Hổ trợ bộ nhớ ngoài tối đa 256GB " +
                                "Dung lượng pin 3000 mAh",
                ProductQuantity = 100,
                ProductPrice = 1390000,
                CreateDate = DateTime.Now,
                CategoryId = 3
            },
                    new Product()
                    {
                        ProductId = 15,
                        ProductName = "Vsmart Bee",
                        ProductImage = "vsBee.jpg",
                        Descriptions = "Công nghệ màn hình: IPS LCD, " +
                               "Độ phân giải: HD+ (720 x 1440 Pixels), " +
                               "Màn hình rộng: 6.0 inch, " +
                               "Mặt kính cảm ứng: Mặt kính cong 2.5D, " +
                               "Camera sau: Chính 8 MP, " +
                               "Camera trước: 5 MP, " +
                               "Ram: 2 GB, " +
                               "Bộ nhớ trong: 16 GB, " +
                               "Hổ trợ bộ nhớ ngoài tối đa 64GB " +
                                "Dung lượng pin 3000 mAh",
                        ProductQuantity = 100,
                        ProductPrice = 1000000,
                        CreateDate = DateTime.Now,
                        CategoryId = 3
                    },
                    new Product()
                    {
                        ProductId = 16,
                        ProductName = "OPPO Reno3",
                        ProductImage = "oppoReno3.png",
                        Descriptions = "Công nghệ màn hình: AMOLED, " +
                               "Độ phân giải: Full HD+ (1080 x 2400 Pixels), " +
                               "Màn hình rộng: 6.4 inch, " +
                               "Mặt kính cảm ứng: Kính cường lực Corning Gorilla Glass 5, " +
                               "Camera sau: Chính 48 MP & Phụ 13 MP, 8 MP, 2 MP, " +
                               "Camera trước: 44 MP, " +
                               "Ram: 8 GB, " +
                               "Bộ nhớ trong: 128 GB, " +
                               "Hổ trợ bộ nhớ ngoài tối đa 256GB " +
                                "Dung lượng pin 4025 mAh",
                        ProductQuantity = 100,
                        ProductPrice = 8490000,
                        CreateDate = DateTime.Now,
                        CategoryId = 5
                    },
                      new Product()
                      {
                          ProductId = 17,
                          ProductName = "OPPO A91",
                          ProductImage = "oppoA91.jpg",
                          Descriptions = "Công nghệ màn hình: AMOLED, " +
                               "Độ phân giải: Full HD+ (1080 x 2400 Pixels), " +
                               "Màn hình rộng: 6.4 inch, " +
                               "Mặt kính cảm ứng: Kính cường lực Corning Gorilla Glass 5, " +
                               "Camera sau: Chính 48 MP & Phụ 13 MP, 8 MP, 2 MP, " +
                               "Camera trước: 16 MP, " +
                               "Ram: 8 GB, " +
                               "Bộ nhớ trong: 128 GB, " +
                               "Hổ trợ bộ nhớ ngoài tối đa 256GB " +
                                "Dung lượng pin 4025 mAh",
                          ProductQuantity = 100,
                          ProductPrice = 5990000,
                          CreateDate = DateTime.Now,
                          CategoryId = 5
                      },
                       new Product()
                       {
                           ProductId = 18,
                           ProductName = "OPPO Find X2",
                           ProductImage = "oppoFindx2.png",
                           Descriptions = "Công nghệ màn hình: AMOLED, " +
                               "Độ phân giải: 2K+ (1440 x 3168 Pixels), " +
                               "Màn hình rộng: 6.78 inch, " +
                               "Mặt kính cảm ứng: Kính cường lực Corning Gorilla Glass 6, " +
                               "Camera sau: Chính 48 MP & Phụ 13 MP, 12 MP, " +
                               "Camera trước: 32 MP, " +
                               "Ram: 12 GB, " +
                               "Bộ nhớ trong: 256 GB, " +
                               "Không hổ trợ bộ nhớ ngoài" +
                                "Dung lượng pin 4200 mAh",
                           ProductQuantity = 100,
                           ProductPrice = 23990000,
                           CreateDate = DateTime.Now,
                           CategoryId = 5
                       },
                         new Product()
                         {
                             ProductId = 19,
                             ProductName = "OPPO A31",
                             ProductImage = "oppoA31.png",
                             Descriptions = "Công nghệ màn hình: IPS LCD, " +
                               "Độ phân giải: HD+ (720 x 1600 Pixels), " +
                               "Màn hình rộng: 6.5 inch, " +
                               "Mặt kính cảm ứng: Mặt kính cong 2.5D, " +
                               "Camera sau: Chính 12 MP & Phụ 2 MP, 2 MP, " +
                               "Camera trước: 8 MP, " +
                               "Ram: 6 GB, " +
                               "Bộ nhớ trong: 128 GB, " +
                               "Hổ trợ bộ nhớ ngoài tối đa 256GB" +
                                "Dung lượng pin 4230 mAh",
                             ProductQuantity = 100,
                             ProductPrice = 4990000,
                             CreateDate = DateTime.Now,
                             CategoryId = 5
                         },
                             new Product()
                             {
                                 ProductId = 20,
                                 ProductName = "Nokia 2.3",
                                 ProductImage = "nokia2.3.jpeg",
                                 Descriptions = "Công nghệ màn hình: 	TFT, " +
                               "Độ phân giải: HD+ (720 x 1520 Pixels), " +
                               "Màn hình rộng: 6.2 inch, " +
                               "Mặt kính cảm ứng: Mặt kính cong 2.5D, " +
                               "Camera sau: Chính 13 MP & Phụ 2 MP, " +
                               "Camera trước: 5 MP, " +
                               "Ram: 2 GB, " +
                               "Bộ nhớ trong: 32 GB, " +
                               "Hổ trợ bộ nhớ ngoài tối đa 512GB" +
                                "Dung lượng pin 4000 mAh",
                                 ProductQuantity = 100,
                                 ProductPrice = 2290000,
                                 CreateDate = DateTime.Now,
                                 CategoryId = 4
                             },
                              new Product()
                              {
                                  ProductId = 21,
                                  ProductName = "SamSung Galaxy A21s",
                                  ProductImage = "ssA21.png",
                                  Descriptions = "Công nghệ màn hình: 	TFT, " +
                               "Độ phân giải: HD+ (720 x 1520 Pixels), " +
                               "Màn hình rộng: 6.2 inch, " +
                               "Mặt kính cảm ứng: Mặt kính cong 2.5D, " +
                               "Camera sau: Chính 13 MP & Phụ 2 MP, " +
                               "Camera trước: 5 MP, " +
                               "Ram: 2 GB, " +
                               "Bộ nhớ trong: 32 GB, " +
                               "Hổ trợ bộ nhớ ngoài tối đa 512GB" +
                                "Dung lượng pin 4000 mAh",
                                  ProductQuantity = 100,
                                  ProductPrice = 5690000,
                                  CreateDate = DateTime.Now,
                                  CategoryId = 2
                              },
                                  new Product()
                                  {
                                      ProductId = 22,
                                      ProductName = "SamSung Galaxy A80",
                                      ProductImage = "ssA80.png",
                                      Descriptions = "Công nghệ màn hình: 	TFT, " +
                               "Độ phân giải: HD+ (720 x 1520 Pixels), " +
                               "Màn hình rộng: 6.2 inch, " +
                               "Mặt kính cảm ứng: Mặt kính cong 2.5D, " +
                               "Camera sau: Chính 13 MP & Phụ 2 MP, " +
                               "Camera trước: 5 MP, " +
                               "Ram: 2 GB, " +
                               "Bộ nhớ trong: 32 GB, " +
                               "Hổ trợ bộ nhớ ngoài tối đa 512GB" +
                                "Dung lượng pin 4000 mAh",
                                      ProductQuantity = 100,
                                      ProductPrice = 8990000,
                                      CreateDate = DateTime.Now,
                                      CategoryId = 2
                                  },
                                   new Product()
                                   {
                                       ProductId = 23,
                                       ProductName = "SamSung Galaxy Z Flip",
                                       ProductImage = "ssZFlip.png",
                                       Descriptions = "Công nghệ màn hình: 	TFT, " +
                               "Độ phân giải: HD+ (720 x 1520 Pixels), " +
                               "Màn hình rộng: 6.2 inch, " +
                               "Mặt kính cảm ứng: Mặt kính cong 2.5D, " +
                               "Camera sau: Chính 13 MP & Phụ 2 MP, " +
                               "Camera trước: 5 MP, " +
                               "Ram: 2 GB, " +
                               "Bộ nhớ trong: 32 GB, " +
                               "Hổ trợ bộ nhớ ngoài tối đa 512GB" +
                                "Dung lượng pin 4000 mAh",
                                       ProductQuantity = 100,
                                       ProductPrice = 36000000,
                                       CreateDate = DateTime.Now,
                                       CategoryId = 2
                                   },
                                       new Product()
                                       {
                                           ProductId = 24,
                                           ProductName = "Samsung Galaxy A10",
                                           ProductImage = "SsA10.jpg",
                                           Descriptions = "Công nghệ màn hình: PLS TFT , " +
                                   "Độ phân giải: 	Full HD+ (720 x 1520 Pixels), " +
                                   "Màn hình rộng: 6.2 inch, " +
                                   "Mặt kính cảm ứng: 	Mặt kính cong 2.5D, " +
                                   "Camera sau: 	Chính 13 MP & Phụ 5 MP, " +
                                   "Camera trước: 8 MP, " +
                                   "Ram: 2 GB, " +
                                   "Bộ nhớ trong: 32 GB, " +
                                   "Hổ trợ bộ nhớ ngoài tối đa 512 GB " +
                                    "Dung lượng pin 4000 mAh",
                                           ProductQuantity = 100,
                                           ProductPrice = 3690000,
                                           CreateDate = DateTime.Now,
                                           CategoryId = 2
                                       },
                                       new Product()
                                       {
                                           ProductId = 25,
                                           ProductName = "Xiaomi Redmi 9",
                                           ProductImage = "XmR9.jpg",
                                           Descriptions = "Công nghệ màn hình: IPS LCD, " +
                                   "Độ phân giải: 	Full HD+ (1080 x 2340 Pixels), " +
                                   "Màn hình rộng: 6.53 inch, " +
                                   "Mặt kính cảm ứng: 	Kính cường lực Corning Gorilla Glass 3, " +
                                   "Camera sau: 	Chính 13 MP & Phụ 8 MP, 5MP, 2MP, " +
                                   "Camera trước: 20 MP, " +
                                   "Ram: 8 GB, " +
                                   "Bộ nhớ trong: 256 GB, " +
                                   "Hổ trợ bộ nhớ ngoài tối đa 512 GB " +
                                    "Dung lượng pin 5000 mAh",
                                           ProductQuantity = 100,
                                           ProductPrice = 3790000,
                                           CreateDate = DateTime.Now,
                                           CategoryId = 6
                                       },
                                       new Product()
                                       {
                                           ProductId = 26,
                                           ProductName = "Xiaomi Redmi Note 9",
                                           ProductImage = "XmN9.jpg",
                                           Descriptions = "Công nghệ màn hình: ILS LCD, " +
                                   "Độ phân giải: 	Full HD+ (1080 x 2340 Pixels), " +
                                   "Màn hình rộng: 6.53 inch, " +
                                   "Mặt kính cảm ứng: 	Kính cường lực Corning Gorilla Glass 5, " +
                                   "Camera sau: 	Chính 108 MP & Phụ 13 MP, 5MP, " +
                                   "Camera trước: 13 MP, " +
                                   "Ram: 4 GB, " +
                                   "Bộ nhớ trong: 128 GB, " +
                                   "Hổ trợ bộ nhớ ngoài tối đa 512 GB " +
                                    "Dung lượng pin 5020 mAh",
                                           ProductQuantity = 100,
                                           ProductPrice = 4790000,
                                           CreateDate = DateTime.Now,
                                           CategoryId = 6
                                       },
                                        new Product()
                                        {
                                            ProductId = 27,
                                            ProductName = "Xiaomi Mi 10T",
                                            ProductImage = "Xm10T.png",
                                            Descriptions = "Công nghệ màn hình: ILS LCD, " +
                                   "Độ phân giải: 	Full HD+ (1080 x 2440 Pixels), " +
                                   "Màn hình rộng: 6.53 inch, " +
                                   "Mặt kính cảm ứng: 	Kính cường lực Corning Gorilla Glass 5, " +
                                   "Camera sau: 	Chính 48 MP & Phụ 8 MP, 2MP, 2MP " +
                                   "Camera trước: 13 MP, " +
                                   "Ram: 4 GB, " +
                                   "Bộ nhớ trong: 128 GB, " +
                                   "Hổ trợ bộ nhớ ngoài tối đa 512 GB " +
                                    "Dung lượng pin 5020 mAh",
                                            ProductQuantity = 100,
                                            ProductPrice = 12990000,
                                            CreateDate = DateTime.Now,
                                            CategoryId = 6
                                        },
                                         new Product()
                                         {
                                             ProductId = 28,
                                             ProductName = "Xiaomi POCO X3 NFC",
                                             ProductImage = "XPX3.jpg",
                                             Descriptions = "Công nghệ màn hình: IPS LCD, " +
                                   "Độ phân giải: 	Full HD+ (1080 x 2400 Pixels), " +
                                   "Màn hình rộng: 6.67 inch, " +
                                   "Mặt kính cảm ứng: 	Kính cường lực Corning Gorilla Glass 5, " +
                                   "Camera sau: 	Chính 64 MP & Phụ 13 MP, 2MP, 2MP, " +
                                   "Camera trước: 20 MP, " +
                                   "Ram: 6 GB, " +
                                   "Bộ nhớ trong: 128 GB, " +
                                   "Hổ trợ bộ nhớ ngoài tối đa 256 GB " +
                                    "Dung lượng pin 5160 mAh",
                                             ProductQuantity = 100,
                                             ProductPrice = 6990000,
                                             CreateDate = DateTime.Now,
                                             CategoryId = 6
                                         },
                                           new Product()
                                           {
                                               ProductId = 29,
                                               ProductName = "Xiaomi Redmi Note 9S",
                                               ProductImage = "XRN9S.jpg",
                                               Descriptions = "Công nghệ màn hình: IPS LCD, " +
                                   "Độ phân giải: 	Full HD+ (1080 x 2400 Pixels), " +
                                   "Màn hình rộng: 6.67 inch, " +
                                   "Mặt kính cảm ứng: 	Kính cường lực Corning Gorilla Glass 5, " +
                                   "Camera sau: 	Chính 48 MP & Phụ 8 MP, 5MP, 2MP, " +
                                   "Camera trước: 16 MP, " +
                                   "Ram: 6 GB, " +
                                   "Bộ nhớ trong: 128 GB, " +
                                   "Hổ trợ bộ nhớ ngoài tối đa 256 GB " +
                                    "Dung lượng pin 5020 mAh",
                                               ProductQuantity = 100,
                                               ProductPrice = 5690000,
                                               CreateDate = DateTime.Now,
                                               CategoryId = 6
                                           },
                                           new Product()
                                           {
                                               ProductId = 30,
                                               ProductName = "Huawei Nova 7i",
                                               ProductImage = "HN7.jpg",
                                               Descriptions = "Công nghệ màn hình: LTPS LCD, " +
                                   "Độ phân giải: 	Full HD+ (720 x 1600 Pixels), " +
                                   "Màn hình rộng: 6.4 inch, " +
                                   "Mặt kính cảm ứng: 	Mặt kính cong 2.5D, " +
                                   "Camera sau: 	Chính 13 MP & Phụ 5 MP, 2MP, " +
                                   "Camera trước: 8 MP, " +
                                   "Ram: 4 GB, " +
                                   "Bộ nhớ trong: 64 GB, " +
                                   "Hổ trợ bộ nhớ ngoài tối đa 256 GB " +
                                    "Dung lượng pin 5000 mAh",
                                               ProductQuantity = 100,
                                               ProductPrice = 3340000,
                                               CreateDate = DateTime.Now,
                                               CategoryId = 7
                                           },
                                            new Product()
                                            {
                                                ProductId = 31,
                                                ProductName = "Huawei Y6p",
                                                ProductImage = "HY6.png",
                                                Descriptions = "Công nghệ màn hình: IPS LCD, " +
                                   "Độ phân giải: 	Full HD+ (1080 x 2310 Pixels), " +
                                   "Màn hình rộng: 6.3 inch, " +
                                   "Mặt kính cảm ứng: 	Mặt kính cong 2.5D, " +
                                   "Camera sau: 	Chính 48 MP & Phụ 8 MP, 2MP, 2MP, " +
                                   "Camera trước: 16 MP, " +
                                   "Ram: 8 GB, " +
                                   "Bộ nhớ trong: 128 GB, " +
                                   "Hổ trợ bộ nhớ ngoài tối đa 256 GB " +
                                    "Dung lượng pin 4200 mAh",
                                                ProductQuantity = 100,
                                                ProductPrice = 5990000,
                                                CreateDate = DateTime.Now,
                                                CategoryId = 7
                                            },
                                              new Product()
                                              {
                                                  ProductId = 32,
                                                  ProductName = "Huawei P30 Pro",
                                                  ProductImage = "HP30Pro.jpg",
                                                  Descriptions = "Công nghệ màn hình: OLED, " +
                                   "Độ phân giải: 	Full HD+ (1080 x 2340 Pixels), " +
                                   "Màn hình rộng: 6.3 inch, " +
                                   "Mặt kính cảm ứng: 	Mặt kính cong 2.5D, " +
                                   "Camera sau: 	Chính 40 MP & Phụ 20 MP, 8MP, " +
                                   "Camera trước: 32 MP, " +
                                   "Ram: 8 GB, " +
                                   "Bộ nhớ trong: 256 GB, " +
                                   "Hổ trợ bộ nhớ ngoài tối đa 512 GB " +
                                    "Dung lượng pin 4200 mAh",
                                                  ProductQuantity = 100,
                                                  ProductPrice = 13990000,
                                                  CreateDate = DateTime.Now,
                                                  CategoryId = 7
                                              },
                                               new Product()
                                               {
                                                   ProductId = 33,
                                                   ProductName = "Huawei Nova 5T",
                                                   ProductImage = "HN5T.jpg",
                                                   Descriptions = "Công nghệ màn hình: LTPS, " +
                                   "Độ phân giải: 	Full HD+ (1080 x 2340 Pixels), " +
                                   "Màn hình rộng: 6.26 inch, " +
                                   "Mặt kính cảm ứng: 	Mặt kính cong 3D, " +
                                   "Camera sau: 	Chính 48 MP & Phụ 16 MP, 2MP, 2MP, " +
                                   "Camera trước: 32 MP, " +
                                   "Ram: 8 GB, " +
                                   "Bộ nhớ trong: 128 GB, " +
                                   "Hổ trợ bộ nhớ ngoài tối đa 512 GB " +
                                    "Dung lượng pin 3750 mAh",
                                                   ProductQuantity = 100,
                                                   ProductPrice = 8990000,
                                                   CreateDate = DateTime.Now,
                                                   CategoryId = 7
                                               },
                                               new Product()
                                               {
                                                   ProductId = 34,
                                                   ProductName = "Vivo Y12s",
                                                   ProductImage = "VY12s.jpg",
                                                   Descriptions = "Công nghệ màn hình: LTPS, " +
                                   "Độ phân giải: 	Full HD+ (720 x 1600 Pixels), " +
                                   "Màn hình rộng: 6.51 inch, " +
                                   "Mặt kính cảm ứng: 	Mặt kính cong 2.5D, " +
                                   "Camera sau: 	Chính 13 MP & 2MP, " +
                                   "Camera trước: 8 MP, " +
                                   "Ram: 3 GB, " +
                                   "Bộ nhớ trong: 32 GB, " +
                                   "Hổ trợ bộ nhớ ngoài tối đa 256 GB " +
                                    "Dung lượng pin 5000 mAh",
                                                   ProductQuantity = 100,
                                                   ProductPrice = 3290000,
                                                   CreateDate = DateTime.Now,
                                                   CategoryId = 8
                                               },
                                                  new Product()
                                                  {
                                                      ProductId = 35,
                                                      ProductName = "Vivo X50 Pro",
                                                      ProductImage = "VYX50Pro.jpg",
                                                      Descriptions = "Công nghệ màn hình: AMOLED, " +
                                   "Độ phân giải: 	Full HD+ (1080 x 2376 Pixels), " +
                                   "Màn hình rộng: 6.56 inch, " +
                                   "Mặt kính cảm ứng: 	Kính cường lực Schott Xensation UP, " +
                                   "Camera sau: Chính 48 MP & Phụ 13 MP, 8 MP, 8 MP, " +
                                   "Camera trước: 32 MP, " +
                                   "Ram: 8 GB, " +
                                   "Bộ nhớ trong: 256 GB, " +
                                   "Hổ trợ bộ nhớ ngoài tối đa 512 GB " +
                                    "Dung lượng pin 4315 mAh",
                                                      ProductQuantity = 100,
                                                      ProductPrice = 18990000,
                                                      CreateDate = DateTime.Now,
                                                      CategoryId = 8
                                                  },
                                     new Product()
                                     {
                                         ProductId = 36,
                                         ProductName = "Vivo V20 SE",
                                         ProductImage = "VYS20se.jpg",
                                         Descriptions = "Công nghệ màn hình: AMOLED, " +
                                   "Độ phân giải: 	Full HD+ (1080 x 2400 Pixels), " +
                                   "Màn hình rộng: 6.44 inch, " +
                                   "Mặt kính cảm ứng: 	Kính cường lực Schott Xensation UP, " +
                                   "Camera sau: Chính 48 MP & Phụ 13 MP, 2 MP, " +
                                   "Camera trước: 32 MP, " +
                                   "Ram: 8 GB, " +
                                   "Bộ nhớ trong: 128 GB, " +
                                   "Hổ trợ bộ nhớ ngoài tối đa 256 GB " +
                                    "Dung lượng pin 4100 mAh",
                                         ProductQuantity = 100,
                                         ProductPrice = 7190000,
                                         CreateDate = DateTime.Now,
                                         CategoryId = 8
                                     },
                                      new Product()
                                      {
                                          ProductId = 37,
                                          ProductName = "Vivo Y20s",
                                          ProductImage = "VY20s.jpg",
                                          Descriptions = "Công nghệ màn hình: IPS LCD, " +
                                   "Độ phân giải: 	Full HD+ (720 x 1600 Pixels), " +
                                   "Màn hình rộng: 6.51 inch, " +
                                   "Mặt kính cảm ứng: 	Mặt kính cong 2.5D, " +
                                   "Camera sau: Chính 13 MP & Phụ 2 MP, 2 MP, " +
                                   "Camera trước: 8 MP, " +
                                   "Ram: 6 GB, " +
                                   "Bộ nhớ trong: 128 GB, " +
                                   "Hổ trợ bộ nhớ ngoài tối đa 256 GB " +
                                    "Dung lượng pin 5000 mAh",
                                          ProductQuantity = 100,
                                          ProductPrice = 7190000,
                                          CreateDate = DateTime.Now,
                                          CategoryId = 8
                                      },
                                      new Product()
                                      {
                                          ProductId = 38,
                                          ProductName = "LG Extravert",
                                          ProductImage = "LGE.jpg",
                                          Descriptions = "Độ phân giải: Full HD+(240 x 400 Pixels), " +
                                   "Màn hình rộng: 2.8 inch, " +
                                   "Bộ nhớ trong: Đang cập nhật," +
                                   "Thiết kế: Pin rời," +
                                    "Dung lượng pin 1000 mAh",
                                          ProductQuantity = 100,
                                          ProductPrice = 2500000,
                                          CreateDate = DateTime.Now,
                                          CategoryId = 9
                                      },

                                      new Product()
                                      {
                                          ProductId = 39,
                                          ProductName = "LG Q31",
                                          ProductImage = "LG_Q31.png",
                                          Descriptions = "Màn hình:IPS LCD, 5.7" +
                                                        "Hệ điều hành:Android 10," +
                                                        "Camera sau:Chính 13 MP & Phụ 5 MP," +
                                                        "Camera trước:5 MP," +
                                                        "CPU:MediaTek MT6762 8 nhân (Helio P22)," +
                                                        "RAM:3 GB," +
                                                        "Bộ nhớ trong:32 GB," +
                                                        "Thẻ nhớ:MicroSD,hỗ trợ tối đa 2 TB," +
                                                        "Thẻ SIM:Hỗ trợ 4G," +
                                                        "Dung lượng pin:3000 mAh",
                                          ProductQuantity = 100,
                                          ProductPrice = 7900000,
                                          CreateDate = DateTime.Now,
                                          CategoryId = 9
                                      },
                                      new Product()
                                      {
                                          ProductId = 40,
                                          ProductName = "LG G3000",
                                          ProductImage = "LG_G3000.png",
                                          Descriptions = "Thiết Kế: Pin rời," +
                                                        "Kích thước:102 x 45 x 20 mm," +
                                                        "Trọng lượng: 79," +
                                                        "Dung lượng pin:850 mAh",
                                          ProductQuantity = 100,
                                          ProductPrice = 350000,
                                          CreateDate = DateTime.Now,
                                          CategoryId = 9
                                      },
                                       new Product()
                                       {
                                           ProductId = 41,
                                           ProductName = "LG G7",
                                           ProductImage = "LG7.png",
                                           Descriptions = "Màn hình:OLED" +
                                                        "Hệ điều hành:Android 8," +
                                                        "Camera sau:16 MP " +
                                                        "Camera trước:8 MP," +
                                                        "RAM:6 GB," +
                                                        "Bộ nhớ trong:32 GB," +
                                                        "Thẻ nhớ:MicroSD,hỗ trợ tối đa 2 TB," +
                                                        "Dung lượng pin:3000 mAh",
                                           ProductQuantity = 100,
                                           ProductPrice = 6500000,
                                           CreateDate = DateTime.Now,
                                           CategoryId = 9
                                       },
                                        new Product()
                                        {
                                            ProductId = 42,
                                            ProductName = "Nokia 5310",
                                            ProductImage = "nokia 5310.jpg",
                                            Descriptions = "Nokia 5310, Nghe, Gọi, Nhắn tin, Thay thế đồng hồ báo thức, Chống nước, Chống sốc",
                                            ProductQuantity = 100,
                                            ProductPrice = 1000000,
                                            CreateDate = DateTime.Now,
                                            CategoryId = 4
                                        },
                                        new Product()
                                        {
                                            ProductId = 43,
                                            ProductName = "Iphone12",
                                            ProductImage = "iphone12.jpeg",
                                            Descriptions = "Công nghệ màn hình: OLED, " +
                                                           "Độ phân giải: 1242 x 2688 Pixels, " +
                                                           "Màn hình rộng: 6.5 inch, " +
                                                           "Mặt kính cảm ứng: Kính cường lực oleophobic(ion cường lực), " +
                                                           "Camera sau: Độ phân giải 3 camera 12 MP, " +
                                                           "Camera trước: 12 MP, " +
                                                           "Ram: 4GB, " +
                                                           "Bộ nhớ trong: 64GB, " +
                                                           "Không hổ trợ bộ nhớ ngoài" +
                                                            "Dung lượng pin 3969 mAh",
                                            ProductQuantity = 100,
                                            ProductPrice = 26000000,
                                            CreateDate = DateTime.Now,
                                            CategoryId = 1});                                 


            //----------------------------------------------------------------------------------------------------------------
            builder.Entity<IdentityRole>().HasData(
              new IdentityRole
              {
                  Name = "Visitor",
                  NormalizedName = "VISITOR"
              },
             new IdentityRole
             {
                 Name = "Administrator",
                 NormalizedName = "ADMINISTRATOR"
             });


        }
    }
}
