﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webapplication1.application.DTOs
{
    public class UserRegisterRequestDto
    {
        [Required(ErrorMessage = "User Name is Required")]

        public string? UserName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is Required")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]

        public string? Password { get; set; }

    }
}
