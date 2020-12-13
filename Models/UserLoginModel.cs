﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneWeb.Models
{
    public class UserLoginModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        [StringLength((10), MinimumLength = 6)]
        public string Password { get; set; }
        public bool RememberMe { get; internal set; }
    }
}
