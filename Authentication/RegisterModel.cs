using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ContactApplication.Authentication
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }


        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        
        [Required(ErrorMessage = "UserNumber is required")]
        public int UserNumber { get; set; }



    }
}