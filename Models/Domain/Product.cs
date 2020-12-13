using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneWeb.Models.Domain
{
    public class Product
    {
      
        public int ProductId { get; set; }
        [DisplayName("Tên sản phẩm")]
        [Required(ErrorMessage = "Phải nhập tên sản phẩm")]
        public string ProductName { get; set; }
        [DisplayName("Số lượng sản phẩm")]
        [Required(ErrorMessage = "Phải nhập số lượng sản phẩm")]
        [Range(1, 500, ErrorMessage = "Số lượng hàng hoá 1-500!!!")]
        public int ProductQuantity { get; set; }
        [DisplayName("Ảnh sản phẩm")]
        public string ProductImage { get; set; }
        [Required]
        [Range(1, 50000000, ErrorMessage = "Giá chỉ trong khoảng 1 - 50.000.000 !!")]
        [DisplayName("Giá sản phẩm")]
        public double ProductPrice { get; set; }
        [DisplayName("Ngày tạo sản phẩm")]
        public DateTime CreateDate { get; set; }
        [DisplayName("Mô tả sản phẩm")]
        public string Descriptions { get; set; }
        [DisplayName("Loại sản phẩm")]
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
