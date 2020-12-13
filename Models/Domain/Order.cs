using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneWeb.Models.Domain
{
    public class Order
    {
        public int OrderId { get; set; }
        [DisplayName("Ngày tạo hoá đơn")]
        public DateTime OrderDate { get; set; }
        [DisplayName("Tên khách hàng")]
        [Required]
        public string TenKhachHang { get; set; }
        [DisplayName("Email")]
        [Required]
        [DataType(DataType.EmailAddress)]       
        public string Email { get; set; }
        [DisplayName("Số điện thoại")]
        [Required]
        [StringLength(maximumLength: 10, MinimumLength = 0, ErrorMessage = "Phải có 10 số !!")]
        [RegularExpression(@"^\(?([0-9]{3})\(?([0-9]{7})$", ErrorMessage = "Phải nhập sô!!!!!")]
        public string SoDienThoai { get; set; }
        [DisplayName("Địa chỉ giao hàng")]
        [Required]
        public string DiaChiGiaoHang { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
