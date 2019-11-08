using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityAPI.Models.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username required")]
        [MinLength(6, ErrorMessage = "Min 6 chars required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password required")]
        [MinLength(8, ErrorMessage = "Min 8 chars required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
