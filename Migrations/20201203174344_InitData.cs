using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneWeb.Migrations
{
    public partial class InitData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    TenKhachHang = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    SoDienThoai = table.Column<string>(maxLength: 10, nullable: false),
                    DiaChiGiaoHang = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: false),
                    ProductQuantity = table.Column<int>(nullable: false),
                    ProductImage = table.Column<string>(nullable: true),
                    ProductPrice = table.Column<double>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Descriptions = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "38a91b1a-d324-4ae1-9c95-fcdbf2d39825", "02dcecf5-513b-4a85-9625-2570fc4830d9", "Visitor", "VISITOR" },
                    { "b324255c-902a-472d-87d0-0f20f40c14d3", "89515eed-de79-47e0-8542-dbd68d1cc890", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Iphone" },
                    { 2, "SamSung" },
                    { 3, "Vsmart" },
                    { 4, "Nokia" },
                    { 5, "Oppo" },
                    { 6, "Xiaomi" },
                    { 7, "Huawei" },
                    { 8, "Vivo" },
                    { 9, "LG" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "CreateDate", "Descriptions", "ProductImage", "ProductName", "ProductPrice", "ProductQuantity" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 12, 4, 0, 43, 44, 215, DateTimeKind.Local).AddTicks(4729), "Công nghệ màn hình: OLED, Độ phân giải: 1242 x 2688 Pixels, Màn hình rộng: 6.5 inch, Mặt kính cảm ứng: Kính cường lực oleophobic(ion cường lực), Camera sau: Độ phân giải 3 camera 12 MP, Camera trước: 12 MP, Ram: 4GB, Bộ nhớ trong: 64GB, Không hổ trợ bộ nhớ ngoàiDung lượng pin 3969 mAh", "ip11.jpg", "Iphone11", 20000000.0, 100 },
                    { 17, 5, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5338), "Công nghệ màn hình: AMOLED, Độ phân giải: Full HD+ (1080 x 2400 Pixels), Màn hình rộng: 6.4 inch, Mặt kính cảm ứng: Kính cường lực Corning Gorilla Glass 5, Camera sau: Chính 48 MP & Phụ 13 MP, 8 MP, 2 MP, Camera trước: 16 MP, Ram: 8 GB, Bộ nhớ trong: 128 GB, Hổ trợ bộ nhớ ngoài tối đa 256GB Dung lượng pin 4025 mAh", "oppoA91.jpg", "OPPO A91", 5990000.0, 100 },
                    { 18, 5, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5340), "Công nghệ màn hình: AMOLED, Độ phân giải: 2K+ (1440 x 3168 Pixels), Màn hình rộng: 6.78 inch, Mặt kính cảm ứng: Kính cường lực Corning Gorilla Glass 6, Camera sau: Chính 48 MP & Phụ 13 MP, 12 MP, Camera trước: 32 MP, Ram: 12 GB, Bộ nhớ trong: 256 GB, Không hổ trợ bộ nhớ ngoàiDung lượng pin 4200 mAh", "oppoFindx2.png", "OPPO Find X2", 23990000.0, 100 },
                    { 19, 5, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5342), "Công nghệ màn hình: IPS LCD, Độ phân giải: HD+ (720 x 1600 Pixels), Màn hình rộng: 6.5 inch, Mặt kính cảm ứng: Mặt kính cong 2.5D, Camera sau: Chính 12 MP & Phụ 2 MP, 2 MP, Camera trước: 8 MP, Ram: 6 GB, Bộ nhớ trong: 128 GB, Hổ trợ bộ nhớ ngoài tối đa 256GBDung lượng pin 4230 mAh", "oppoA31.png", "OPPO A31", 4990000.0, 100 },
                    { 25, 6, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5353), "Công nghệ màn hình: IPS LCD, Độ phân giải: 	Full HD+ (1080 x 2340 Pixels), Màn hình rộng: 6.53 inch, Mặt kính cảm ứng: 	Kính cường lực Corning Gorilla Glass 3, Camera sau: 	Chính 13 MP & Phụ 8 MP, 5MP, 2MP, Camera trước: 20 MP, Ram: 8 GB, Bộ nhớ trong: 256 GB, Hổ trợ bộ nhớ ngoài tối đa 512 GB Dung lượng pin 5000 mAh", "XmR9.jpg", "Xiaomi Redmi 9", 3790000.0, 100 },
                    { 26, 6, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5355), "Công nghệ màn hình: ILS LCD, Độ phân giải: 	Full HD+ (1080 x 2340 Pixels), Màn hình rộng: 6.53 inch, Mặt kính cảm ứng: 	Kính cường lực Corning Gorilla Glass 5, Camera sau: 	Chính 108 MP & Phụ 13 MP, 5MP, Camera trước: 13 MP, Ram: 4 GB, Bộ nhớ trong: 128 GB, Hổ trợ bộ nhớ ngoài tối đa 512 GB Dung lượng pin 5020 mAh", "XmN9.jpg", "Xiaomi Redmi Note 9", 4790000.0, 100 },
                    { 27, 6, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5357), "Công nghệ màn hình: ILS LCD, Độ phân giải: 	Full HD+ (1080 x 2440 Pixels), Màn hình rộng: 6.53 inch, Mặt kính cảm ứng: 	Kính cường lực Corning Gorilla Glass 5, Camera sau: 	Chính 48 MP & Phụ 8 MP, 2MP, 2MP Camera trước: 13 MP, Ram: 4 GB, Bộ nhớ trong: 128 GB, Hổ trợ bộ nhớ ngoài tối đa 512 GB Dung lượng pin 5020 mAh", "Xm10T.png", "Xiaomi Mi 10T", 12990000.0, 100 },
                    { 28, 6, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5359), "Công nghệ màn hình: IPS LCD, Độ phân giải: 	Full HD+ (1080 x 2400 Pixels), Màn hình rộng: 6.67 inch, Mặt kính cảm ứng: 	Kính cường lực Corning Gorilla Glass 5, Camera sau: 	Chính 64 MP & Phụ 13 MP, 2MP, 2MP, Camera trước: 20 MP, Ram: 6 GB, Bộ nhớ trong: 128 GB, Hổ trợ bộ nhớ ngoài tối đa 256 GB Dung lượng pin 5160 mAh", "XPX3.jpg", "Xiaomi POCO X3 NFC", 6990000.0, 100 },
                    { 29, 6, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5360), "Công nghệ màn hình: IPS LCD, Độ phân giải: 	Full HD+ (1080 x 2400 Pixels), Màn hình rộng: 6.67 inch, Mặt kính cảm ứng: 	Kính cường lực Corning Gorilla Glass 5, Camera sau: 	Chính 48 MP & Phụ 8 MP, 5MP, 2MP, Camera trước: 16 MP, Ram: 6 GB, Bộ nhớ trong: 128 GB, Hổ trợ bộ nhớ ngoài tối đa 256 GB Dung lượng pin 5020 mAh", "XRN9S.jpg", "Xiaomi Redmi Note 9S", 5690000.0, 100 },
                    { 16, 5, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5336), "Công nghệ màn hình: AMOLED, Độ phân giải: Full HD+ (1080 x 2400 Pixels), Màn hình rộng: 6.4 inch, Mặt kính cảm ứng: Kính cường lực Corning Gorilla Glass 5, Camera sau: Chính 48 MP & Phụ 13 MP, 8 MP, 2 MP, Camera trước: 44 MP, Ram: 8 GB, Bộ nhớ trong: 128 GB, Hổ trợ bộ nhớ ngoài tối đa 256GB Dung lượng pin 4025 mAh", "oppoReno3.png", "OPPO Reno3", 8490000.0, 100 },
                    { 30, 7, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5362), "Công nghệ màn hình: LTPS LCD, Độ phân giải: 	Full HD+ (720 x 1600 Pixels), Màn hình rộng: 6.4 inch, Mặt kính cảm ứng: 	Mặt kính cong 2.5D, Camera sau: 	Chính 13 MP & Phụ 5 MP, 2MP, Camera trước: 8 MP, Ram: 4 GB, Bộ nhớ trong: 64 GB, Hổ trợ bộ nhớ ngoài tối đa 256 GB Dung lượng pin 5000 mAh", "HN7.jpg", "Huawei Nova 7i", 3340000.0, 100 },
                    { 32, 7, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5453), "Công nghệ màn hình: OLED, Độ phân giải: 	Full HD+ (1080 x 2340 Pixels), Màn hình rộng: 6.3 inch, Mặt kính cảm ứng: 	Mặt kính cong 2.5D, Camera sau: 	Chính 40 MP & Phụ 20 MP, 8MP, Camera trước: 32 MP, Ram: 8 GB, Bộ nhớ trong: 256 GB, Hổ trợ bộ nhớ ngoài tối đa 512 GB Dung lượng pin 4200 mAh", "HP30Pro.jpg", "Huawei P30 Pro", 13990000.0, 100 },
                    { 33, 7, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5455), "Công nghệ màn hình: LTPS, Độ phân giải: 	Full HD+ (1080 x 2340 Pixels), Màn hình rộng: 6.26 inch, Mặt kính cảm ứng: 	Mặt kính cong 3D, Camera sau: 	Chính 48 MP & Phụ 16 MP, 2MP, 2MP, Camera trước: 32 MP, Ram: 8 GB, Bộ nhớ trong: 128 GB, Hổ trợ bộ nhớ ngoài tối đa 512 GB Dung lượng pin 3750 mAh", "HN5T.jpg", "Huawei Nova 5T", 8990000.0, 100 },
                    { 34, 8, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5457), "Công nghệ màn hình: LTPS, Độ phân giải: 	Full HD+ (720 x 1600 Pixels), Màn hình rộng: 6.51 inch, Mặt kính cảm ứng: 	Mặt kính cong 2.5D, Camera sau: 	Chính 13 MP & 2MP, Camera trước: 8 MP, Ram: 3 GB, Bộ nhớ trong: 32 GB, Hổ trợ bộ nhớ ngoài tối đa 256 GB Dung lượng pin 5000 mAh", "VY12s.jpg", "Vivo Y12s", 3290000.0, 100 },
                    { 35, 8, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5459), "Công nghệ màn hình: AMOLED, Độ phân giải: 	Full HD+ (1080 x 2376 Pixels), Màn hình rộng: 6.56 inch, Mặt kính cảm ứng: 	Kính cường lực Schott Xensation UP, Camera sau: Chính 48 MP & Phụ 13 MP, 8 MP, 8 MP, Camera trước: 32 MP, Ram: 8 GB, Bộ nhớ trong: 256 GB, Hổ trợ bộ nhớ ngoài tối đa 512 GB Dung lượng pin 4315 mAh", "VYX50Pro.jpg", "Vivo X50 Pro", 18990000.0, 100 },
                    { 36, 8, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5461), "Công nghệ màn hình: AMOLED, Độ phân giải: 	Full HD+ (1080 x 2400 Pixels), Màn hình rộng: 6.44 inch, Mặt kính cảm ứng: 	Kính cường lực Schott Xensation UP, Camera sau: Chính 48 MP & Phụ 13 MP, 2 MP, Camera trước: 32 MP, Ram: 8 GB, Bộ nhớ trong: 128 GB, Hổ trợ bộ nhớ ngoài tối đa 256 GB Dung lượng pin 4100 mAh", "VYS20se.jpg", "Vivo V20 SE", 7190000.0, 100 },
                    { 37, 8, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5463), "Công nghệ màn hình: IPS LCD, Độ phân giải: 	Full HD+ (720 x 1600 Pixels), Màn hình rộng: 6.51 inch, Mặt kính cảm ứng: 	Mặt kính cong 2.5D, Camera sau: Chính 13 MP & Phụ 2 MP, 2 MP, Camera trước: 8 MP, Ram: 6 GB, Bộ nhớ trong: 128 GB, Hổ trợ bộ nhớ ngoài tối đa 256 GB Dung lượng pin 5000 mAh", "VY20s.jpg", "Vivo Y20s", 7190000.0, 100 },
                    { 38, 9, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5466), "Độ phân giải: Full HD+(240 x 400 Pixels), Màn hình rộng: 2.8 inch, Bộ nhớ trong: Đang cập nhật,Thiết kế: Pin rời,Dung lượng pin 1000 mAh", "LGE.jpg", "LG Extravert", 2500000.0, 100 },
                    { 39, 9, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5470), "Màn hình:IPS LCD, 5.7Hệ điều hành:Android 10,Camera sau:Chính 13 MP & Phụ 5 MP,Camera trước:5 MP,CPU:MediaTek MT6762 8 nhân (Helio P22),RAM:3 GB,Bộ nhớ trong:32 GB,Thẻ nhớ:MicroSD,hỗ trợ tối đa 2 TB,Thẻ SIM:Hỗ trợ 4G,Dung lượng pin:3000 mAh", "LG_Q31.png", "LG Q31", 7900000.0, 100 },
                    { 31, 7, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5450), "Công nghệ màn hình: IPS LCD, Độ phân giải: 	Full HD+ (1080 x 2310 Pixels), Màn hình rộng: 6.3 inch, Mặt kính cảm ứng: 	Mặt kính cong 2.5D, Camera sau: 	Chính 48 MP & Phụ 8 MP, 2MP, 2MP, Camera trước: 16 MP, Ram: 8 GB, Bộ nhớ trong: 128 GB, Hổ trợ bộ nhớ ngoài tối đa 256 GB Dung lượng pin 4200 mAh", "HY6.png", "Huawei Y6p", 5990000.0, 100 },
                    { 40, 9, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5472), "Thiết Kế: Pin rời,Kích thước:102 x 45 x 20 mm,Trọng lượng: 79,Dung lượng pin:850 mAh", "LG_G3000.png", "LG G3000", 350000.0, 100 },
                    { 42, 4, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5476), "Nokia 5310, Nghe, Gọi, Nhắn tin, Thay thế đồng hồ báo thức, Chống nước, Chống sốc", "nokia 5310.jpg", "Nokia 5310", 1000000.0, 100 },
                    { 11, 4, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5321), "Công nghệ màn hình: IPS LCD, Độ phân giải: 	Full HD+ (1080 x 2340 Pixels), Màn hình rộng: 6.3 inch, Mặt kính cảm ứng: 	Kính cường lực Corning Gorilla Glass 3, Camera sau: Chính 48 MP & Phụ 8 MP, 5 MP, Camera trước: 20 MP, Ram: 4 GB, Bộ nhớ trong: 64 GB, Hổ trợ bộ nhớ ngoài tối đa 400 GB Dung lượng pin 4500 mAh", "nokia72.png", "Nokia 7.2", 6190000.0, 100 },
                    { 2, 1, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5258), "Công nghệ màn hình: OLED, Độ phân giải: 1125 x 2436 Pixels, Màn hình rộng: 5.8 inch, Mặt kính cảm ứng: Kính cường lực oleophobic(ion cường lực), Camera sau: Chính 12 MP & Phụ 12 MP, Camera trước: 7 MP, Ram: 3GB, Bộ nhớ trong: 64GB, Không hổ trợ bộ nhớ ngoàiDung lượng pin 2716 mAh", "ipx.jpg", "Iphone X", 17500000.0, 100 },
                    { 3, 1, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5303), "Công nghệ màn hình: LED-backlit IPS LCD, Độ phân giải: Full HD (1080 x 1920 Pixels), Màn hình rộng: 5.5 inch, Mặt kính cảm ứng: Kính cường lực oleophobic(ion cường lực), Camera sau: Chính 12 MP & Phụ 12 MP, Camera trước: 7 MP, Ram: 3GB, Bộ nhớ trong: 64GB, Không hổ trợ bộ nhớ ngoàiDung lượng pin 2691 mAh", "ip8.jpg", "Iphone8", 14000000.0, 100 },
                    { 43, 1, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5478), "Công nghệ màn hình: OLED, Độ phân giải: 1242 x 2688 Pixels, Màn hình rộng: 6.5 inch, Mặt kính cảm ứng: Kính cường lực oleophobic(ion cường lực), Camera sau: Độ phân giải 3 camera 12 MP, Camera trước: 12 MP, Ram: 4GB, Bộ nhớ trong: 64GB, Không hổ trợ bộ nhớ ngoàiDung lượng pin 3969 mAh", "iphone12.jpeg", "Iphone12", 26000000.0, 100 },
                    { 4, 2, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5307), "Công nghệ màn hình: Màn hình 6.7, Quad HD+ (2K+)Độ phân giải: 2K+ (1440 x 3200 Pixels), Hệ điều hành: Android 10, Mặt kính cảm ứng: 	Kính cường lực Corning Gorilla Glass 6, Camera sau: Chính 12 MP & phụ 64 MP, 12 MP, TOF 3D, Camera trước: 10 MP, Ram: 8 GB, Bộ nhớ trong: 128GB, Hổ trợ bộ nhớ ngoài tối đa 1TBDung lượng pin 4500 mAh", "ss20.jpg", "Samsung Galaxy S20+", 18990000.0, 100 },
                    { 8, 2, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5315), "Công nghệ màn hình: Dynamic AMOLED 2X, 6.2 inch, Quad HD+ (2K+), Độ phân giải: Full HD+ (1080 x 2400 Pixels), Màn hình rộng: 6.2 inch, Mặt kính cảm ứng: Kính cường lực Corning Gorilla Glass 6, Camera sau: Chính 12 MP & Phụ 64 MP, 12 MP, Camera trước: 10 MP, Ram: 8 GB, Bộ nhớ trong: 128 GB, Hổ trợ bộ nhớ ngoài tối đa 512 GB Thẻ Sim: 2 Nano SIM hoặc 1 Nano SIM + 1 eSIM, Hỗ trợ 4GDung lượng pin 4000 mAhCông nghệ pin: Sạc ngược không dây, Sạc pin nhanh, Siêu tiết kiệm pin, Sạc không dây ", "ssS20.jpg", "Samsung Galaxy S20", 21490000.0, 100 },
                    { 9, 2, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5317), "Công nghệ màn hình: PLS TFT LCD, Độ phân giải: 	Full HD+ (1080 x 2340 Pixels), Màn hình rộng: 6.3 inch, Mặt kính cảm ứng: 	Mặt kính cong 2.5D, Camera sau: 	Chính 13 MP & Phụ 5 MP, Camera trước: 8 MP, Ram: 3 GB, Bộ nhớ trong: 31 GB, Hổ trợ bộ nhớ ngoài tối đa 512 GB Dung lượng pin 4000 mAh", "ssM20.png", "Samsung Galaxy M20", 5490000.0, 100 },
                    { 10, 2, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5319), "Công nghệ màn hình: Super AMOLED, Độ phân giải: 	Full HD+ (1080 x 2400 Pixels), Màn hình rộng: 6.7 inch, Mặt kính cảm ứng: 	Kính cường lực, Camera sau: Chính 64 MP & Phụ 12 MP, 5 MP, 5 MP, Camera trước: 32 MP, Ram: 8 GB, Bộ nhớ trong: 128 GB, Hổ trợ bộ nhớ ngoài tối đa 512 GB Dung lượng pin 5000 mAh", "ssA71.png", "Samsung Galaxy A71", 10590000.0, 100 },
                    { 12, 2, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5328), "Công nghệ màn hình: Super AMOLED, Độ phân giải: 	Full HD+ (1080 x 2340 Pixels), Màn hình rộng: 6.4 inch, Mặt kính cảm ứng: 	Mặt kính cong 2.5D, Camera sau: Chính 48 MP & Phụ 8 MP, 5 MP, Camera trước: 32 MP, Ram: 4 GB, Bộ nhớ trong: 64 GB, Hổ trợ bộ nhớ ngoài tối đa 512 GB Dung lượng pin 4000 mAh", "ssA50s.png", "Samsung Galaxy A50s", 6990000.0, 100 },
                    { 20, 4, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5344), "Công nghệ màn hình: 	TFT, Độ phân giải: HD+ (720 x 1520 Pixels), Màn hình rộng: 6.2 inch, Mặt kính cảm ứng: Mặt kính cong 2.5D, Camera sau: Chính 13 MP & Phụ 2 MP, Camera trước: 5 MP, Ram: 2 GB, Bộ nhớ trong: 32 GB, Hổ trợ bộ nhớ ngoài tối đa 512GBDung lượng pin 4000 mAh", "nokia2.3.jpeg", "Nokia 2.3", 2290000.0, 100 },
                    { 21, 2, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5346), "Công nghệ màn hình: 	TFT, Độ phân giải: HD+ (720 x 1520 Pixels), Màn hình rộng: 6.2 inch, Mặt kính cảm ứng: Mặt kính cong 2.5D, Camera sau: Chính 13 MP & Phụ 2 MP, Camera trước: 5 MP, Ram: 2 GB, Bộ nhớ trong: 32 GB, Hổ trợ bộ nhớ ngoài tối đa 512GBDung lượng pin 4000 mAh", "ssA21.png", "SamSung Galaxy A21s", 5690000.0, 100 },
                    { 23, 2, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5350), "Công nghệ màn hình: 	TFT, Độ phân giải: HD+ (720 x 1520 Pixels), Màn hình rộng: 6.2 inch, Mặt kính cảm ứng: Mặt kính cong 2.5D, Camera sau: Chính 13 MP & Phụ 2 MP, Camera trước: 5 MP, Ram: 2 GB, Bộ nhớ trong: 32 GB, Hổ trợ bộ nhớ ngoài tối đa 512GBDung lượng pin 4000 mAh", "ssZFlip.png", "SamSung Galaxy Z Flip", 36000000.0, 100 },
                    { 24, 2, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5351), "Công nghệ màn hình: PLS TFT , Độ phân giải: 	Full HD+ (720 x 1520 Pixels), Màn hình rộng: 6.2 inch, Mặt kính cảm ứng: 	Mặt kính cong 2.5D, Camera sau: 	Chính 13 MP & Phụ 5 MP, Camera trước: 8 MP, Ram: 2 GB, Bộ nhớ trong: 32 GB, Hổ trợ bộ nhớ ngoài tối đa 512 GB Dung lượng pin 4000 mAh", "SsA10.jpg", "Samsung Galaxy A10", 3690000.0, 100 },
                    { 5, 3, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5309), "Công nghệ màn hình: IPS LCD, Độ phân giải: HD+ (720 x 1600 Pixels), Màn hình rộng: 6.5 inch, Mặt kính cảm ứng: 	Mặt kính cong 2.5D, Camera sau: Chính 13 MP & Phụ 8 MP, 2 MP, Camera trước: 8 MP, Ram: 4 GB, Bộ nhớ trong: 64 GB, Hổ trợ bộ nhớ ngoài tối đa 64GBDung lượng pin 5000 mAh", "vsmartjoy3.jpg", "Vsmart Joy 3", 4000000.0, 100 },
                    { 7, 3, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5313), "Công nghệ màn hình: AMOLED, Độ phân giải: Full HD+ (1080 x 2232 Pixels), Màn hình rộng: 6.2 inch, Mặt kính cảm ứng: Mặt kính cong 2.5D, Camera sau: Chính 48 MP & Phụ 8 MP, 5 MP, Camera trước: 20 MP, Ram: 6 GB, Bộ nhớ trong: 64 GB, Không hổ trợ bộ nhớ ngoài Dung lượng pin 4000 mAh", "vslive.jpg", "Vsmart Live", 7000000.0, 100 },
                    { 13, 3, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5330), "Công nghệ màn hình: AMOLED, Độ phân giải: Full HD+ (1080 x 2340 Pixels), Màn hình rộng: 6.39 inch, Mặt kính cảm ứng: Mặt kính cong 2.5D, Camera sau: Chính 48 MP & Phụ 8 MP, 5 MP, Camera trước: 16 MP, Ram: 6 GB, Bộ nhớ trong: 64 GB, Hổ trợ bộ nhớ ngoài tối đa 256GB Dung lượng pin 4020 mAh", "vsActive3.jpg", "Vsmart Active 3", 3790000.0, 100 },
                    { 14, 3, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5333), "Công nghệ màn hình: IPS LCD, Độ phân giải: HD+ (720 x 1520 Pixels), Màn hình rộng: 5.7 inch, Mặt kính cảm ứng: Mặt kính cong 2.5D, Camera sau: Chính 8 MP & Phụ 2 MP, Camera trước: 5 MP, Ram: 2 GB, Bộ nhớ trong: 16 GB, Hổ trợ bộ nhớ ngoài tối đa 256GB Dung lượng pin 3000 mAh", "vsStar.jpg", "Vsmart Star", 1390000.0, 100 },
                    { 15, 3, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5335), "Công nghệ màn hình: IPS LCD, Độ phân giải: HD+ (720 x 1440 Pixels), Màn hình rộng: 6.0 inch, Mặt kính cảm ứng: Mặt kính cong 2.5D, Camera sau: Chính 8 MP, Camera trước: 5 MP, Ram: 2 GB, Bộ nhớ trong: 16 GB, Hổ trợ bộ nhớ ngoài tối đa 64GB Dung lượng pin 3000 mAh", "vsBee.jpg", "Vsmart Bee", 1000000.0, 100 },
                    { 6, 4, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5311), "Nokia 1280 - Legendary, Nghe, Gọi, Nhắn tin, Thay thế đồng hồ báo thức, Chống nước, Chống sốc", "nokia1280.jpg", "Nokia 1280", 200000.0, 100 },
                    { 22, 2, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5348), "Công nghệ màn hình: 	TFT, Độ phân giải: HD+ (720 x 1520 Pixels), Màn hình rộng: 6.2 inch, Mặt kính cảm ứng: Mặt kính cong 2.5D, Camera sau: Chính 13 MP & Phụ 2 MP, Camera trước: 5 MP, Ram: 2 GB, Bộ nhớ trong: 32 GB, Hổ trợ bộ nhớ ngoài tối đa 512GBDung lượng pin 4000 mAh", "ssA80.png", "SamSung Galaxy A80", 8990000.0, 100 },
                    { 41, 9, new DateTime(2020, 12, 4, 0, 43, 44, 216, DateTimeKind.Local).AddTicks(5474), "Màn hình:OLEDHệ điều hành:Android 8,Camera sau:16 MP Camera trước:8 MP,RAM:6 GB,Bộ nhớ trong:32 GB,Thẻ nhớ:MicroSD,hỗ trợ tối đa 2 TB,Dung lượng pin:3000 mAh", "LG7.png", "LG G7", 6500000.0, 100 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
