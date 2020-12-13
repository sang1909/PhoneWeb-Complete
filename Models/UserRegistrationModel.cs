﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static PhoneWeb.Models.ListIdentityUser;

namespace PhoneWeb.Models
{
    public class UserRegistrationModel
    {
        [Required]
        [StringLength(15, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "Phải có ký tự in hoa đầu câu ")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(maximumLength: 10, MinimumLength = 0, ErrorMessage = "Số điện thoại chỉ có 10 số!!")]
        [RegularExpression(@"^\(?([0-9]{3})\(?([0-9]{7})$", ErrorMessage = "Hãy nhập số điện thoại, tối đa 10 ký tự số !!!")]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength((10), MinimumLength = 6)]
        public string Password { get; set; }
        [Required]
        [NotMapped]
        [Compare("Password")]
        public string ComfirmPassword { get; set; }
        public RoleType Type { get; set; }
        public List<SelectListItem> RoleTypes { get; set; }

        public UserRegistrationModel()
        {
            RoleTypes = new List<SelectListItem>();
            RoleTypes.Add(new SelectListItem
            {
                Value = ((int)RoleType.Admin).ToString(),
                Text = RoleType.Admin.ToString()
            });
            RoleTypes.Add(new SelectListItem
            {
                Value = ((int)RoleType.User).ToString(),
                Text = RoleType.User.ToString()
            });
        }
    }
}
