using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneWeb.Models
{
    public class Email
    {
        [Required]
        [DisplayName("Đến")]
        public string To { get; set; }
        [Required]
        [DisplayName("Chủ đề")]
        public string Subject { get; set; }
        [Required]
        [DisplayName("Nội dung")]
        public string Body { get; set; }
    }
}
