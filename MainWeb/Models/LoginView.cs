using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MainWeb.Models
{

    public class LoginView // goes to LoginPage
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "Email")]
        public string Email { get; set; }



        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Confirm password is required")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Old password is required")]
        [Display(Name = "Old Password")]
        public string OldPassword { get; set; }

        public string ReturnURL { get; set; }
        public bool RememberMe { get; set; }

    }

}
