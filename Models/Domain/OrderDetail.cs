using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneWeb.Models.Domain
{
    public class OrderDetail
    {       
        public int OrderDetailId { get; set; }
        [DisplayName("Hoá đơn")]
        public int OrderId { get; set; }
        [DisplayName("Sản phẩm")]
        public int ProductId { get; set; }
        [DisplayName("Số lượng")]
        public int Quantity { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
