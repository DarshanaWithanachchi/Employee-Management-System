using EmployeeManagement.Utilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Remote(action: "IsEmailIsUse",controller:"Account")]
        [ValidEmailDomain(allowedDomain:"paragimtech.com", ErrorMessage = "Email domain must be paragimtech.com")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [Compare("Password",ErrorMessage ="Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string City { get; set; }
    }
}
