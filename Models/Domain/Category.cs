using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneWeb.Models.Domain
{
    public class Category
    {
        public int CategoryId { get; set; }
        [DisplayName("Loại sản phẩm")]
        [Required(ErrorMessage = "Phải nhập loại sản phẩm")]
        public string CategoryName { get; set; }
        public List<Product> Products { get; set; }
    }
}
